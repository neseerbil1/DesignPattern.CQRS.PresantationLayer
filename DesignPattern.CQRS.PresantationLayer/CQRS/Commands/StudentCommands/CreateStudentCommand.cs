using MediatR;

namespace DesignPattern.CQRS.PresantationLayer.CQRS.Commands.StudentCommands
{
    public class CreateStudentCommand:IRequest
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Status { get; set; }
      
    }
}
