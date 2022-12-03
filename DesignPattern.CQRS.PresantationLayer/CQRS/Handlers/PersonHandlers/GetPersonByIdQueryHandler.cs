using DesignPattern.CQRS.PresantationLayer.CQRS.Queries.PersonQueries;
using DesignPattern.CQRS.PresantationLayer.CQRS.Results.PersonResult;
using DesignPattern.CQRS.PresantationLayer.DAL.Concrete;
using DesignPattern.CQRS.PresantationLayer.DAL.Entity;

namespace DesignPattern.CQRS.PresantationLayer.CQRS.Handlers.PersonHandlers
{
    public class GetPersonByIdQueryHandler
    {
        private readonly Context _context;

        public GetPersonByIdQueryHandler(Context context)
        {
            _context = context;
        }

        public GetPersonByIDQueryResult Handle(GetPersonByIDQuery query)
        {
            var values = _context.Set<Person>().Find(query.Id);
            return new GetPersonByIDQueryResult
            {
                PersonID = values.PersonID,
                Name = values.Name,
                Surname = values.Surname
            };
        }
    }
}
