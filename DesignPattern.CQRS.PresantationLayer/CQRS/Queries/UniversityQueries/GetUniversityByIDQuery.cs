namespace DesignPattern.CQRS.PresantationLayer.CQRS.Queries.UniversityQueries
{
    public class GetUniversityByIDQuery
    {
        public GetUniversityByIDQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; } 
    }
}
