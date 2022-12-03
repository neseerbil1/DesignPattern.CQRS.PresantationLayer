using DesignPattern.CQRS.PresantationLayer.CQRS.Commands.PersonCommands;
using DesignPattern.CQRS.PresantationLayer.CQRS.Commands.UniversityCommands;
using DesignPattern.CQRS.PresantationLayer.DAL.Concrete;
using DesignPattern.CQRS.PresantationLayer.DAL.Entity;
using System;

namespace DesignPattern.CQRS.PresantationLayer.CQRS.Handlers.UniversityHandlers
{
    public class CreateUniversityHandler
    {
        private readonly Context _context;

        public CreateUniversityHandler(Context context)
        {
            _context = context;
        }
        public void Handle(CreateUniversityCommand command)
        {
            _context.Universities.Add(new University
            {
               Name = command.Name,
               Population=command.Population,  
            });
            _context.SaveChanges();
        }
    }
}
