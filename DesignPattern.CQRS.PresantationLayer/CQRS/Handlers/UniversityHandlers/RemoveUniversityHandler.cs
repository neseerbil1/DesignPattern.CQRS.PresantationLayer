using DesignPattern.CQRS.PresantationLayer.CQRS.Commands.UniversityCommands;
using DesignPattern.CQRS.PresantationLayer.DAL.Concrete;
using DesignPattern.CQRS.PresantationLayer.DAL.Entity;

namespace DesignPattern.CQRS.PresantationLayer.CQRS.Handlers.UniversityHandlers
{
    public class RemoveUniversityHandler
    {
        private readonly Context _context;
        public RemoveUniversityHandler(Context context)
        {
            _context = context;
        }

        public void Handle(RemoveUniversityCommands command)
        {
            var values = _context.Universities.Find(command.Id);
            _context.Universities.Remove(values);
            _context.SaveChanges();
        }
    }
}
