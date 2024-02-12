using DataAccessLayer.Concrete;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using TraversalCoreProje.MediatR.Queries;
using TraversalCoreProje.MediatR.Results;
using TraversalCoreProje.Models;

namespace TraversalCoreProje.MediatR.Handlers
{
    public class GetGuideByIdQueryHandler : IRequestHandler<GetGuideByIdQuery, GetGuideByIdQueryResult>
    {
        private readonly Context _context;

        public GetGuideByIdQueryHandler(Context context)
        {
            _context = context;
        }

        public async Task<GetGuideByIdQueryResult> Handle(GetGuideByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _context.Guides.FindAsync(request.Id);
            return new GetGuideByIdQueryResult
            {
                GuideId = values.GuideId,
                Description = values.Description,
                Image = values.Image,
                NameSurname = values.NameSurname
            };
        }
    }
}
