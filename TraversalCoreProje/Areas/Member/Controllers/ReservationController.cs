using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCoreProje.Areas.Member.Controllers
{
    [Area("Member")]
    public class ReservationController : Controller
    {
        ReservationManager reservationManager = new ReservationManager(new EfReservationDal());
        private readonly IDestinationService _destinationService;
        private readonly UserManager<AppUser> _userManager;
        public ReservationController(IDestinationService destinationService, UserManager<AppUser> userManager)
        {
            _destinationService = destinationService;
            _userManager = userManager;
        }

        public async Task<IActionResult> MyCurrentReservation()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            var valuesList = reservationManager.TGetListReservationByAccepted(values.Id);
            return View(valuesList);
        }



        public async Task< IActionResult> MyOldReservation()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            var valuesList = reservationManager.TGetListReservatonByPrevious(values.Id);
            return View(valuesList);
        }



        public async Task<IActionResult> MyApprovalReservation()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            var valuesList = reservationManager.TGetListReservationByWithApproval(values.Id);
            return View(valuesList);
        }


        [HttpGet]
        public IActionResult NewReservation()
        {
            List<SelectListItem> values = (from x in _destinationService.TGetList()
                                           select new SelectListItem
                                           {
                                               Text=x.City,
                                               Value=x.DestinationId.ToString()
                                               
                                           }
                                           ).ToList();
            ViewBag.v=values;
            return View();
        }
        [HttpPost]
        public IActionResult NewReservation(Reservation reservation)
        {
            reservation.AppUserId = 5;
            reservation.Status = "Onay Bekleniyor";
            reservationManager.TInsert(reservation);
            return RedirectToAction("MyCurrentReservation");
        }
    }
}
