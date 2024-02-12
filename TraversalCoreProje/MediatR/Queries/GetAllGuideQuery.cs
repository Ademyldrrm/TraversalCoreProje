using DocumentFormat.OpenXml.Office2010.ExcelAc;
using MediatR;
using System.Collections.Generic;
using TraversalCoreProje.MediatR.Results;

namespace TraversalCoreProje.MediatR.Queries
{
    public class GetAllGuideQuery:IRequest<List<GetAllGuideQueryResult>>
    {
    }
}
