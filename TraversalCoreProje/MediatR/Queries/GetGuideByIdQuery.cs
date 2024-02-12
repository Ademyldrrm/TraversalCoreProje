using MediatR;
using TraversalCoreProje.MediatR.Results;

namespace TraversalCoreProje.MediatR.Queries
{
    public class GetGuideByIdQuery:IRequest<GetGuideByIdQueryResult>
    {
        public GetGuideByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
