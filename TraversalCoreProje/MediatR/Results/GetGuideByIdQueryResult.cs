namespace TraversalCoreProje.MediatR.Results
{
    public class GetGuideByIdQueryResult
    {
        public int GuideId { get; set; }
        public string NameSurname { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
    }
}
