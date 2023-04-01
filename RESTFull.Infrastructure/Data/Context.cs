using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RESTFull.Domain;

namespace RESTFull.Infrastructure
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }
        public DbSet<Achievement> Achievements { get; set; }
        public DbSet<CreativeActivities> CreativeActivitiess { get; set; }
        public DbSet<IntellectualContests> IntellectualContestss { get; set; }
        public DbSet<Olympiads> Olympiads { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<ScienceActivities> ScienceActivitiess { get; set; }
        public DbSet<SocioCultural> SocioCulturals { get; set; }
        public DbSet<Sport> Sports { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<CreativeActivities>().ToTable(nameof(CreativeActivities));
            modelBuilder.Entity<IntellectualContests>().ToTable(nameof(IntellectualContests));
            modelBuilder.Entity<Olympiads>().ToTable(nameof(Olympiads));
            modelBuilder.Entity<ScienceActivities>().ToTable(nameof(ScienceActivities));
            modelBuilder.Entity<SocioCultural>().ToTable(nameof(SocioCulturals));
            modelBuilder.Entity<Sport>().ToTable(nameof(Sports));
/*
            var person1 = new Person
            {
                Personid = 934,
                name = "Harry",
                surname = "Potter",

            };

            var olimp = new Domain.Olympiads { id = 1, Achievements = "IDK", Date = DateTime.Now, Link = "idk", Form = "Something", Theme = "Math", Person = person1 };
            person1.Achievement.Add(olimp);
            modelBuilder.Entity<Person>().HasData(person1);
            modelBuilder.Entity<Olympiads>().HasData(olimp);*/
        }
    }

}