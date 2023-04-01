using AutoMapper;
using System;
using System.Reflection;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RESTFull.DTO;
using RESTFull.Infrastructure;
using RESTFull.Infrastructure.Repository;
using Microsoft.EntityFrameworkCore.Infrastructure;
using RESTFull.Domain;
using System.Text.Json;
using Newtonsoft.Json;
using System.Collections.Generic;
using Microsoft.OpenApi.Validations;

namespace RESTFull.API.Controllers
{
    [Route("/api/[controller]")]
    [ApiController]
    public class AchievementController : Controller
    {
        private readonly Context context;
        private readonly AchievementRepository achievementRepository;
        private readonly IMapper mapper;
        private readonly List<Type> types;
        private readonly List<Type> typesDTO;

        public AchievementController(Context context, IMapper mapper)
        {
            this.context = context;
            achievementRepository = new AchievementRepository(context);
            this.mapper = mapper;

            types = context.Model.GetEntityTypes().
                Select(t => t.ClrType).
                Where(t=> (t!= typeof(Person) && t != typeof(Achievement))).ToList();

            typesDTO = AppDomain.CurrentDomain.GetAssemblies()
               .SelectMany(t => t.GetTypes())
               .Where(t => t.IsClass && t.Namespace == "RESTFull.DTO" && t!=typeof(MapperProfile)).ToList();

        }

        [HttpGet("/Types")]
        public String[] GetTypes()
        {
            return types.Select(tp => tp.Name).ToArray();
        }

        [HttpGet("/TypesDTO")]
        public String[] GetTypesDTO()
        {
            return typesDTO.Select(tp => tp.Name).ToArray();
        }

        [HttpGet("/All")]
        public async Task<SportDTO[]> GetAll()
        {
            return mapper.Map<SportDTO[]>(achievementRepository.GetSports().Result.ToArray());
        }

        [HttpGet("/AllSports")]
        public async Task<AchievementDTO[]> GetAllSp()
        {
            return mapper.Map<AchievementDTO[]>(achievementRepository.GetAll().Result.ToArray());
        }

        [HttpGet("/AllDet")]
        public async Task<Tuple<AchievementDTO, string>[]> GetAllDet(int id = 0)
        {
            List<Tuple<AchievementDTO, string>> list = new List<Tuple<AchievementDTO, string>>();
            List<AchievementDTO> achievements;

            achievements = mapper.Map<List<AchievementDTO>>(achievementRepository.GetByUserId(id).Result);

            foreach (AchievementDTO temp in achievements)
            {
                foreach (var type in types)
                {
                    var obj = context.Find(type, temp.id);
                    if (obj != null)
                    {
                        list.Add(Tuple.Create(temp, obj.GetType().Name));
                    }
                }
            }
            return list.ToArray();

        }

        [HttpGet("/Determinator")]
        public async Task<ActionResult<Tuple<Tuple<string,string>, string>>> DetAchievement(int id)
        {

            foreach (var type in types)
            {
                var obj = context.Find(type, id);
                if (obj != null)
                {
                    return Ok(Tuple.Create(Tuple.Create(obj.GetType().AssemblyQualifiedName, typesDTO.FirstOrDefault(dto => dto.Name.Contains(obj.GetType().Name)).AssemblyQualifiedName), JsonConvert.SerializeObject(obj)));
                }
            }

            return NotFound();

        }

        [HttpPost("/Add/{PersonId}/{TypeName}")]
        public async Task<ActionResult> Add(int PersonId, string TypeName, JsonElement NewAchiev)
        {
            var type = types.FirstOrDefault(tp => tp.Name.Contains(TypeName));
            var typeDTO = typesDTO.FirstOrDefault(tp => tp.Name.Contains(TypeName));
            Person person = context.Persons.FirstOrDefault(p => p.Personid == PersonId);
            if(type == null)
            {
                return NotFound($"Type with name {TypeName} not found");
            }
            if (person == null)
            {
                return NotFound($"Person with id {PersonId} not found");
            }
            if (typeDTO == null)
            {
                return NotFound($"TypeDTO with name {TypeName} not found");
            }
            dynamic DTOAchiev = JsonConvert.DeserializeObject(NewAchiev.GetRawText(), typeDTO);
            dynamic ThisAchiev = mapper.Map(DTOAchiev, typeDTO,type);
            if (ThisAchiev != null)
            {
                ThisAchiev.Person = person;
                await achievementRepository.Add(ThisAchiev);
                return Ok();
            }
            else return BadRequest("Wrong Json format");
        }

        [HttpPut("/Update/{PersonId}/{TypeName}/{AchievId}")]
        public async Task<ActionResult> Redact(int PersonId, int AchievId, string TypeName, JsonElement achiev)
        {
            try
            {
                var TypeDTO = typesDTO.FirstOrDefault(tp => tp.Name.Contains(TypeName));
                var Type = types.FirstOrDefault(tp => tp.Name.Contains(TypeName));

                if (TypeDTO == null || Type == null)
                {
                    return NotFound("Type not found");
                }

                dynamic DTOAchiev = JsonConvert.DeserializeObject(achiev.GetRawText(), TypeDTO);
                if (DTOAchiev == null)
                {
                    return NotFound("Json cannot be deserialized.");
                }

                dynamic Achiev = mapper.Map(DTOAchiev, TypeDTO, Type);
                await achievementRepository.Update(AchievId, PersonId, Achiev, Type);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }

        }

        [HttpDelete("/Delete/{TypeName}/{AchievId}")]
        public async Task<ActionResult> Delete(int AchievId, string TypeName)
        {
            var Type = types.FirstOrDefault(tp => tp.Name.Contains(TypeName));
            if(Type == null)
            {
                return NotFound("Type not found");
            }
            var Result = await achievementRepository.Delete(AchievId, Type);
            return Ok(Result);
        }
    }
}
