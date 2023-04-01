using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using RESTFull.Domain;
using RESTFull.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace TestProject1
{
    public class TestHelper
    {
        private readonly Context _context;
        public TestHelper()
        {

            var contextOptions = new DbContextOptionsBuilder<Context>()
                .UseMySql(@"server=localhost;user=App;password=1234567890!;database=TestDB", new MySqlServerVersion(new Version(8, 0, 31)))
                .Options;

            _context = new Context(contextOptions);


            _context.Database.EnsureDeleted();
            _context.Database.EnsureCreated();


            var person1 = new Person
            {
                name = "Harry",
                surname = "Potter",
                Personid = 934
            };
            var person2 = new Person
            {
                name = "Eleven",
                surname = "Hopper",
                Personid = 1111,
                Passport = "06071971",
                patronymic = "Jimovna",

            };
            person1.Achievement.Add(new Olympiads { id = 1, Achievements = "IDK", Date = DateTime.Now, Link = "idk", Form = "Something", Theme = "Math" });
            person1.Achievement.Add(new Achievement { id = 7, Achievements = "Quidditch", Date = DateTime.ParseExact("05.11.2022", "dd.MM.yyyy", null), Link = "https://www.wizardingworld.com/" });
            person2.Achievement.Add(new Achievement { id = 34, Achievements = "Best Show", Date = DateTime.ParseExact("12.11.2022", "dd.MM.yyyy", null), Link = "https://www.netflix.com/ru/title/80057281" });

            _context.Persons.Add(person1);
            _context.Persons.Add(person2);
            _context.SaveChanges();
            _context.ChangeTracker.Clear();
        }

        public PersonRepository PersonRepository
        {
            get
            {
                return new PersonRepository(_context);
            }
        }
    }
}
