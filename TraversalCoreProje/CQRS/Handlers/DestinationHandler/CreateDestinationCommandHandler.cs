using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using TraversalCoreProje.CQRS.Commands.DestinationCommands;

namespace TraversalCoreProje.CQRS.Handlers.DestinationHandler
{
    public class CreateDestinationCommandHandler
    {
        private readonly Context _context;

        public CreateDestinationCommandHandler(Context context)
        {
            _context = context;
        }
        public void Handle(CreateDestinationCommand destinationCommand)
        {
            _context.Destinations.Add(new Destination
            {
                City = destinationCommand.City,
                Price = destinationCommand.Price,
                DayNight = destinationCommand.DayNight,
                Capacity = destinationCommand.Capacity,
                Status = true
            });
            _context.SaveChanges();
        }
    }
}
