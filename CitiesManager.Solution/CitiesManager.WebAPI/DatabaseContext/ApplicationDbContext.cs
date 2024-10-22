using CitiesManager.WebAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Runtime.InteropServices.Marshalling;

namespace CitiesManager.WebAPI.DatabaseContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options) 
        { 
        }

        public ApplicationDbContext() { }

        public virtual DbSet<City> Cities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<City>().HasData(
                new City() { CityID = Guid.NewGuid(), CityName = "City One" },
                new City() { CityID = Guid.NewGuid(), CityName = "City Two" });
        }
    }
}
