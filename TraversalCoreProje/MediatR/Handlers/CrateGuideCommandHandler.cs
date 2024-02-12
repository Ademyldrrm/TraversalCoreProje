using DataAccessLayer.Concrete;
using DocumentFormat.OpenXml.Wordprocessing;
using EntityLayer.Concrete;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading;
using System.Threading.Tasks;
using TraversalCoreProje.MediatR.Commands;

namespace TraversalCoreProje.MediatR.Handlers
{
    public class CrateGuideCommandHandler : IRequestHandler<CreateGuideCommand>
    {
        private readonly Context _context;

        public CrateGuideCommandHandler(Context context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(CreateGuideCommand request, CancellationToken cancellationToken)
        {
            _context.Guides.Add(new Guide
            {
                Description = request.Description,
                NameSurname = request.NameSurname,
                Image = request.Image,
            });
            await _context.SaveChangesAsync();
            return Unit.Value;
           
        }
        
    }
}
