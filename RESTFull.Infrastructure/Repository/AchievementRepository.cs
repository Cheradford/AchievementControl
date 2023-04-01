using Microsoft.EntityFrameworkCore;
using RESTFull.Domain;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace RESTFull.Infrastructure.Repository
{
    public class AchievementRepository
    {
        private readonly Context _context;
        public Context UnitOfWork
        {
            get
            {
                return _context;
            }
        }
        public AchievementRepository(Context context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<List<Achievement>> GetAll()
        {
            return await _context.Achievements.OrderBy(ach => ach.id).ToListAsync();
        }

        public async Task<List<Achievement>> GetByUserId(int id = 0 )
        {
            return await _context.Achievements.OrderBy(ach => ach.id).Where(ach => ach.Person.Personid == id || id == 0).ToListAsync();
        }

        public async Task<List<Sport>> GetSports()
        {
            return await _context.Sports.OrderBy(ach => ach.id).ToListAsync();
        }

        public async Task<List<CreativeActivities>> GetCreativeActivities()
        {
            return await _context.CreativeActivitiess.OrderBy(ach => ach.id).ToListAsync();
        }

        public async Task Add(dynamic Achiev)
        {
            _context.Add(Achiev);
            await _context.SaveChangesAsync();
        }
        public async Task Update(int id, int Personid, dynamic Achiev, Type type)
        {
            dynamic CurAchiev = _context.Find(type, id);
            Person person = _context.Persons.FirstOrDefault(pr => pr.Personid == Personid);
            if (CurAchiev != null && person != null && Achiev != null)
            {
                Achiev.Person = person;
                _context.Entry(CurAchiev).CurrentValues.SetValues(Achiev);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<String> Delete(int id, Type type)
        {
            dynamic CurAchiev = _context.Find(type, id);
            if(CurAchiev== null)
            {
                return "Achievement not found";
            }
            _context.Remove(CurAchiev);
            await _context.SaveChangesAsync();
            return "Ok";
        }

        /*public async Task<List<IntellectualContests>> Get*/
    }
}
