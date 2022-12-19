using DesignPattern.CQRS.PresantationLayer.CQRS.Queries.StudentQueries;
using DesignPattern.CQRS.PresantationLayer.CQRS.Results.StudentResult;
using DesignPattern.CQRS.PresantationLayer.DAL.Concrete;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace DesignPattern.CQRS.PresantationLayer.CQRS.Handlers.StudentHandlers
{
    public class GetAllStudentQueryHandler:IRequestHandler<GetAllStudentQuery, List<GetAllStudentQueryResult>>
    {
        private readonly Context _context;

        public GetAllStudentQueryHandler(Context context)
        {
            _context = context;
        }

        public async Task<List<GetAllStudentQueryResult>> Handle(GetAllStudentQuery request, CancellationToken cancellationToken)
        {
            return await _context.Students.Select(x => new GetAllStudentQueryResult
            {
                StudentID = x.StudentID,
                City = x.City,
                Name = x.Name,
                Surname = x.Surname
            }).AsNoTracking().ToListAsync();
        }
    }
}
