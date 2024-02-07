using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace TraversalCoreProje.ViewComponents.MemberDashborad
{
    public class _ProfileInformationPartial:ViewComponent
    {
        private readonly UserManager<AppUser> _userManager;

        public _ProfileInformationPartial(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values =await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.membername = values.Name+""+values.SurName;
            ViewBag.memberphone = values.PhoneNumber;
            ViewBag.mail = values.Email;

            return View();
        }
    }
}
