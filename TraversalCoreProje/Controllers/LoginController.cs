using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TraversalCoreProje.Models;

namespace TraversalCoreProje.Controllers
{
	[AllowAnonymous]
	public class LoginController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
		private readonly SignInManager<AppUser> _signInManager;

        public LoginController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }
		[HttpPost]
		public async Task<IActionResult> SignUp(UserResigterViewModel userResigterView)
		{
			AppUser appUser = new AppUser()
			{
				Name = userResigterView.Name,
				SurName = userResigterView.Surname,
				Email = userResigterView.Mail,
				UserName = userResigterView.UserName
			};

			if (userResigterView.Password == userResigterView.ConfirmPassword)
			{
				var result = await _userManager.CreateAsync(appUser, userResigterView.Password);
				if (result.Succeeded)
				{
					return RedirectToAction("SignIn");
				}
				else
				{
					foreach (var error in result.Errors)
					{
						ModelState.AddModelError("", error.Description);
					}
				}
			}
			return View(userResigterView);
		}

		[HttpGet]
        public IActionResult SignIn()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SignIn(UserSignViewModel userSignViewModel)
        {
			if (ModelState.IsValid)
			{
				var result = await _signInManager.PasswordSignInAsync(userSignViewModel.UserName, userSignViewModel.Password, false,true);
				if (result.Succeeded)
				{
					return RedirectToAction("Index", "Profile", new {area="Member"});
				}
				else
				{
					return RedirectToAction("SignIn", "Login");
				}
			}
            return View();
        }

    }
}
