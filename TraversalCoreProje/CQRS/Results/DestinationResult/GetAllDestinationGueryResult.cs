using System.Data;

namespace TraversalCoreProje.CQRS.Results.DestinationResult
{
    public class GetAllDestinationGueryResult
    {
        public int DestinationId { get; set; }
        public string City { get; set; }
        public double Price { get; set; }
        public int CapaCity { get; set; }
        public string DayNight  { get; set; }
    }
}
