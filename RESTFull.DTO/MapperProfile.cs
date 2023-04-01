using AutoMapper;
using RESTFull.Domain;

namespace RESTFull.DTO
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Person, PersonDTO>().ReverseMap();
            CreateMap<Achievement, AchievementDTO>().ReverseMap();
            CreateMap<IntellectualContests, IntellectualContestsDTO>().ReverseMap();
            CreateMap<CreativeActivities, CreativeActivitiesDTO>().ReverseMap();
            CreateMap<Olympiads, OlympiadsDTO>().ReverseMap();
            CreateMap<ScienceActivities, ScienceActivitiesDTO>().ReverseMap();
            CreateMap<SocioCultural, SocioCulturalDTO>().ReverseMap();
            CreateMap<Sport, SportDTO>().ReverseMap();

        }
    }
}