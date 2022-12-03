﻿using DesignPattern.CQRS.PresantationLayer.CQRS.Commands.UniversityCommands;
using DesignPattern.CQRS.PresantationLayer.DAL.Concrete;

namespace DesignPattern.CQRS.PresantationLayer.CQRS.Handlers.UniversityHandlers
{
    public class UpdateUniversityHandler
    {
        private readonly Context _context;

        public UpdateUniversityHandler(Context context)
        {
            _context = context;
        }

        public void Handle(UpdateUniversityCommand command)
        {
            var values = _context.Universities.Find(command.UniversityID);
            values.City = command.City;
            values.Country = command.Country;
            values.Name = command.Name;
            values.Population = command.Population;
            values.Region = command.Region;
            _context.SaveChanges();
        }
    }
}
