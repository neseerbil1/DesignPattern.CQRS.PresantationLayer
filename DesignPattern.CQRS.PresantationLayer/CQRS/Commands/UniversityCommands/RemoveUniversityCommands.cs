namespace DesignPattern.CQRS.PresantationLayer.CQRS.Commands.UniversityCommands
{
    public class RemoveUniversityCommands
    {
        public RemoveUniversityCommands(int id)
        {
            Id = id;
        }

        public int Id { get; set; } 
    }
}
