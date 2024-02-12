using MediatR;

namespace TraversalCoreProje.MediatR.Commands
{
    public class CreateGuideCommand:IRequest
    {
        public string NameSurname { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
    }
}
