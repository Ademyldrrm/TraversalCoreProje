using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.ViewComponents.MemberDashborad
{
    public class _LastDestinationComponent:ViewComponent
    {
        private readonly IDestinationService _destinationService;

        public _LastDestinationComponent(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }

        public IViewComponentResult Invoke()
        {
           var values= _destinationService.TGetLast4Destination();
            return View(values);
        }
    }
}
