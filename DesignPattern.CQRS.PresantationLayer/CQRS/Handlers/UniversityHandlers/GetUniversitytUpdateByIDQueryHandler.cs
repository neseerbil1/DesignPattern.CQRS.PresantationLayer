using DesignPattern.CQRS.PresantationLayer.CQRS.Commands.UniversityCommands;
using DesignPattern.CQRS.PresantationLayer.CQRS.Queries.UniversityQueries;
using DesignPattern.CQRS.PresantationLayer.CQRS.Results.UniversityResult;
using DesignPattern.CQRS.PresantationLayer.DAL.Concrete;
using DesignPattern.CQRS.PresantationLayer.DAL.Entity;

namespace DesignPattern.CQRS.PresantationLayer.CQRS.Handlers.UniversityHandlers
{
    public class GetUniversitytUpdateByIDQueryHandler
    {
        private readonly Context _context;

        public GetUniversitytUpdateByIDQueryHandler(Context context)
        {
            _context = context;
        }

        public GetUniversityUpdateByIDQuerResult Handle(GetUniversityUpdateByIDQuery query)
        {
            var values = _context.Set<University>().Find(query.Id);
            return new GetUniversityUpdateByIDQuerResult
            {
                UniversityID = values.UniversityID,
                City = values.City,
                Country = values.Country,
                Name = values.Name,
                Population = values.Population,
                Region = values.Region
            };
        }
    }
}
