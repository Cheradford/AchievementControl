using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RESTFull.Domain;
using RESTFull.Infrastructure;
using RESTFull.DTO;
using System.Security.AccessControl;

namespace RESTFull.API.Controllers
{
    [Route("/api/[controller]")]
    [ApiController]
    public class PersonController : Controller
    {

        private readonly Context context;
        private readonly PersonRepository personRepository;
        private readonly IMapper mapper;

        public PersonController(Context context, IMapper mapper)
        {
            this.context = context;
            personRepository = new PersonRepository(context);
            this.mapper = mapper;
        }
        [HttpGet("/AllPersons")]
        public async Task<PersonDTO[]> GetPeople()
        {
            return mapper.Map<List<Person>, List<PersonDTO>>(await personRepository.GetAllAsync()).ToArray();
        }

        [HttpGet("/Person/{id}")]
        public async Task<ActionResult<PersonDTO>> GetPerson(int id){
            var person = personRepository.GetByIdAsync(id).Result;
            if (person != null)
                return Ok(mapper.Map<PersonDTO>(personRepository.GetByIdAsync(id).Result));
            else return NotFound();
        }

        [HttpGet("/Person/{id}/Achievement")]
        public async Task<ActionResult<AchievementDTO[]>> GetAchievementList(int id)
        {
            try
            {
                var person = personRepository.GetByIdAsync(id).Result;
                if (person != null)
                    return Ok(mapper.Map<AchievementDTO[]>(person.Achievement.ToArray()));
                else return NotFound();
            } catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost("/NewPerson")]
        public async Task<ActionResult> PostPerson(PersonDTO person)
        {
            try
            {
                if(personRepository.GetByIdAsync(person.Personid)==null)
                {
                    await personRepository.AddAsync(mapper.Map<Person>(person));
                    return Ok();
                }
                else
                {
                    return Conflict();
                }
            }catch(Exception ex) {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("/{id}/NewAchievement")]
        public async Task<ActionResult> PersonAchievementRedact(int id, Tuple<int, bool>[] NewList)
        {
            try
            {
                var person = personRepository.GetByIdAsync(id).Result;
                if (person == null) return NotFound("Person not found");
                foreach (var temp in NewList)
                    if (!context.Achievements.Any(ach => ach.id == temp.Item1))
                        return NotFound($"Achievement with id {temp.Item1} not found");
                foreach (var temp in NewList) {
                    Achievement achiev = context.Achievements.Find(temp.Item1);
                    if (temp.Item2)
                    {
                    person.Achievement.Add(achiev);
                    }
                    else
                    {
                    person.Achievement.Remove(achiev);
                    }
                }
                await personRepository.UpdateAsync(person);
                return Ok();


            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("/{id}/Update")]
        public async Task<ActionResult> PersonUpdate(int id, PersonDTO person)
        {
            try
            {
                if (personRepository.GetByIdAsync(id) == null) return NotFound($"Person with id {id} not found");
                if (person == null) return BadRequest("Empty request");
                if (person.Personid != id) return BadRequest("Ids do not match");

                await personRepository.UpdateAsync(mapper.Map<Person>(person));
                return Ok();

            }catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("/{id}/Remove")]
        public async Task<ActionResult> PersonDelete(int id)
        {
            try
            {
                var person = personRepository.GetByIdAsync(id); 
                if (person == null) return NotFound($"Person with id {id} not found");
                await personRepository.DeleteAsync(id);
                return Ok();
            }catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

      
    }
}
