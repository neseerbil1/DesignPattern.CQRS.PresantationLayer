using DesignPattern.CQRS.PresantationLayer.DAL.Entity;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace DesignPattern.CQRS.PresantationLayer.DAL.Concrete
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-T0I7RRL;initial catalog=CQRSDb;integrated security=true");
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<University> Universities { get; set; }
    }

}

