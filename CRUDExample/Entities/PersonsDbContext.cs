using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Entities
{
    public class PersonsDbContext :DbContext
    {
        public PersonsDbContext(DbContextOptions options) : base(options)
        {
        }


        public DbSet<Country> Countries { get; set; }

        public DbSet<Person> Persons { get; set; }

        protected override void OnModelCreating
            (ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Country>().ToTable("Countries");

            modelBuilder.Entity<Person>().ToTable("Persons");


            // Seed Data
            string countries = System.IO.File.ReadAllText("countries.json");

            List<Country> countryList = System.Text.Json.JsonSerializer.Deserialize<List<Country>>(countries);

            foreach(Country country in countryList)
            {
                modelBuilder.Entity<Country>().HasData(country);
            }

            string persons = System.IO.File.ReadAllText("persons.json");

            List<Person> personList = System.Text.Json.JsonSerializer.Deserialize<List<Person>>(persons);

            foreach(Person person in personList)
            {
                modelBuilder.Entity<Person>().HasData(person);
            }
        }
    }
}
