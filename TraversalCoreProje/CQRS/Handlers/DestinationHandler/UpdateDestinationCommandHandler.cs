using DataAccessLayer.Concrete;
using TraversalCoreProje.CQRS.Commands.DestinationCommands;

namespace TraversalCoreProje.CQRS.Handlers.DestinationHandler
{
    public class UpdateDestinationCommandHandler
    {
        private readonly Context _context;

        public UpdateDestinationCommandHandler(Context context)
        {
            _context = context;
        }
        public void Handle(UpdateDestinationCommand destinationCommand)
        {
            var values = _context.Destinations.Find(destinationCommand.Id);
            values.City=destinationCommand.City;
            values.DayNight=destinationCommand.DayNight;
            values.Price=destinationCommand.Price;
            values.DestinationId = destinationCommand.Id;
            _context.Update(values);
            _context.SaveChanges();
        }
    }
}
