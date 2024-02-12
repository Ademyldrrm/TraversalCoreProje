using DataAccessLayer.Concrete;
using TraversalCoreProje.CQRS.Queries.DestinationQueries;
using TraversalCoreProje.CQRS.Results.DestinationResult;

namespace TraversalCoreProje.CQRS.Handlers.DestinationHandler
{
    public class GetDestinationByIdQueryHandler
    {
        private readonly Context _context;

        public GetDestinationByIdQueryHandler(Context context)
        {
            _context = context;
        }
        public GetByIdDestinationQueryresult Handle(GetDestinationByIdQuery byIdQuery)
        {
            var values = _context.Destinations.Find(byIdQuery.id);
            return new GetByIdDestinationQueryresult
            {
                Id = values.DestinationId,
                City = values.City,
                DayNight = values.DayNight,
                Price = values.Price
            };
        }
    }
}
