namespace DesignPattern.CQRS.PresantationLayer.CQRS.Commands.UniversityCommands
{
    public class CreateUniversityCommand
    {
        public int UniversityID { get; set; }
        public string Name { get; set; }
        public int Population { get; set; }
    }
}
