using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RESTFull.Domain;
using RESTFull.Infrastructure;

namespace RESTFull.Infrastructure
{
    public class PersonRepository
    {
        private readonly Context _context;
        public Context UnitOfWork
        {
            get
            {
                return _context;
            }
        }
        public PersonRepository(Context context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public async Task<List<Person>> GetAllAsync()
        {
            return await _context.Persons.OrderBy(p => p.Personid).ToListAsync();
        }
        public async Task<Person> GetByIdAsync(int id)
        {
            return await _context.Persons.Where(p => p.Personid == id)
                .Include(p => p.Achievement)
                .FirstOrDefaultAsync();
        }

        public async Task<Person> GetByPassportAsync(string Passport)
        {
            return await _context.Persons
                .Where(p => p.Passport == Passport)
                .Include(p => p.Achievement)
                .FirstOrDefaultAsync();
        }

        public async Task<Person> GetBySurnameAsync(string surname)
        {
            return await _context.Persons
                .Where(p => p.surname == surname)
                .Include(p => p.Achievement)
                .FirstOrDefaultAsync();
        }

        public async Task AddAsync(Person person)
        {
            _context.Persons.Add(person);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateAsync(Person NewPerson)
        {
            var existPerson = GetByIdAsync(NewPerson.Personid).Result;
            if (existPerson != null)
            {
                _context.Entry(existPerson).CurrentValues.SetValues(NewPerson);
                foreach (var NewAchievement in NewPerson.Achievement)
                {
                    var existAchievement = existPerson.Achievement.FirstOrDefault(pn => pn.id == NewAchievement.id);
                    if (existAchievement == null)
                    {
                        _context.Achievements.Add(NewAchievement);
                        existPerson.Achievement.Add(NewAchievement);
                    }
                    else
                    {
                        _context.Entry(existAchievement).CurrentValues.SetValues(NewAchievement);
                    }
                }
                foreach (var existAchievement in existPerson.Achievement)
                {
                    if (!NewPerson.Achievement.Any(pn => pn.id == existAchievement.id))
                    {
                        _context.Remove(existAchievement);
                    }
                }
            }

            await _context.SaveChangesAsync();
        }
        public async Task DeleteAsync(int id)
        {
            Person person = await _context.Persons.FindAsync(id);
            _context.Remove(person);
            await _context.SaveChangesAsync();
        }

        public void ChangeTrackerClear()
        {
            _context.ChangeTracker.Clear();
        }
    }
}
