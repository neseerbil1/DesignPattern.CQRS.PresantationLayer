using DesignPattern.CQRS.PresantationLayer.CQRS.Commands.StudentCommands;
using DesignPattern.CQRS.PresantationLayer.DAL.Concrete;
using DesignPattern.CQRS.PresantationLayer.DAL.Entity;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace DesignPattern.CQRS.PresantationLayer.CQRS.Handlers.StudentHandlers
{
    public class CreateStudentCommandHandler : IRequestHandler<CreateStudentCommand>
    {
        private readonly Context _context;

        public CreateStudentCommandHandler(Context context)
        {
            _context = context;
        }

        public async  Task<Unit> Handle(CreateStudentCommand request, CancellationToken cancellationToken)
        {
           await _context.Students.AddAsync(new Student
            {
                Name = request.Name,
                Surname = request.Surname,
                Status = true
            }
                );
            await _context.SaveChangesAsync();
            return Unit.Value;
        }
    }
}
