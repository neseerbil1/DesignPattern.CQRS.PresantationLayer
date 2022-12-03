using DesignPattern.CQRS.PresantationLayer.CQRS.Queries.PersonQueries;
using DesignPattern.CQRS.PresantationLayer.CQRS.Queries.UniversityQueries;
using DesignPattern.CQRS.PresantationLayer.CQRS.Results.PersonResult;
using DesignPattern.CQRS.PresantationLayer.CQRS.Results.UniversityResult;
using DesignPattern.CQRS.PresantationLayer.DAL.Concrete;
using DesignPattern.CQRS.PresantationLayer.DAL.Entity;

namespace DesignPattern.CQRS.PresantationLayer.CQRS.Handlers.UniversityHandlers
{
    public class GetUniversityByIDQueryHandler
    {
        private readonly Context _context;

        public GetUniversityByIDQueryHandler(Context context)
        {
            _context = context;
        }

        public GetUniversityByIDQueryResult Handle(GetUniversityByIDQuery query)
        {
            var values = _context.Set<University>().Find(query.Id);
            return new GetUniversityByIDQueryResult
            {
                UniversityID = values.UniversityID,
                Name = values.Name,
                Population = values.Population
            };
        }
    }
}
