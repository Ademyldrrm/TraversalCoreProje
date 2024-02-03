using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
