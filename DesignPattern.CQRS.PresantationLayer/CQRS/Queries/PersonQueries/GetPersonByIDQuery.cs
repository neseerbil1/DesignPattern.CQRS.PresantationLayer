namespace DesignPattern.CQRS.PresantationLayer.CQRS.Queries.PersonQueries
{
    public class GetPersonByIDQuery
    {
        public GetPersonByIDQuery(int ıd)
        {
            Id = ıd;
        }

        public int Id { get; set; }
    }
}
