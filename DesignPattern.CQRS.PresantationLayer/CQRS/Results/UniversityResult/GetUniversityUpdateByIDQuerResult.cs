namespace DesignPattern.CQRS.PresantationLayer.CQRS.Results.UniversityResult
{
    public class GetUniversityUpdateByIDQuerResult
    {
        public int UniversityID { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Region { get; set; }
        public int Population { get; set; }
    }
}
