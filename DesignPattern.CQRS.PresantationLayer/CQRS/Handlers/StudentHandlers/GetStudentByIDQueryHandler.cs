using DesignPattern.CQRS.PresantationLayer.CQRS.Queries.StudentQueries;
using DesignPattern.CQRS.PresantationLayer.CQRS.Results.StudentResult;
using DesignPattern.CQRS.PresantationLayer.DAL.Concrete;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace DesignPattern.CQRS.PresantationLayer.CQRS.Handlers.StudentHandlers
{
    public class GetStudentByIDQueryHandler : IRequestHandler<GetStudentByIDQuery, GetStudentByIDQueryResult>
    {
        private readonly Context _context;

        public GetStudentByIDQueryHandler(Context context)
        {
            _context = context;
        }

        public async Task<GetStudentByIDQueryResult> Handle(GetStudentByIDQuery request, CancellationToken cancellationToken)
        {
            var values = await _context.Students.FindAsync(request.Id);
            return new GetStudentByIDQueryResult
            {
              StudentID=values.StudentID,
              Mail=values.Mail, 
              Name=values.Name,
              Surname=values.Surname,   
            };
        }
    }
}
