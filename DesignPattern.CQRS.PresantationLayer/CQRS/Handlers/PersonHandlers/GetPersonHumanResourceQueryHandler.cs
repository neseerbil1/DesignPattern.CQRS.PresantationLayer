using DesignPattern.CQRS.PresantationLayer.CQRS.Queries.PersonQueries;
using DesignPattern.CQRS.PresantationLayer.CQRS.Results.PersonResult;
using DesignPattern.CQRS.PresantationLayer.DAL.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace DesignPattern.CQRS.PresantationLayer.CQRS.Handlers.PersonHandlers
{
    public class GetPersonHumanResourceQueryHandler
    {
        private readonly Context _context;

        public GetPersonHumanResourceQueryHandler(Context context)
        {
            _context = context;
        }

        public List<GetPersonHumanResourceQueryResult> Handle(GetPersonHumanResourceQuery query)
        {
            var values = _context.Persons.Select(x => new GetPersonHumanResourceQueryResult
            {
                City = x.City,
                Department = x.Department,
                Mail = x.Mail,
                Name = x.Name,
                Surname = x.Surname,
                PersonID = x.PersonID,
                Phone = x.Phone
            }).AsNoTracking().ToList();

            return values;
        }
        }
}
