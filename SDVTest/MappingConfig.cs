using AutoMapper;
using SDVTest.Dto;
using SDVTest.Models;


namespace SDVTest
{
    public class MappingConfig
    {
        public static MapperConfiguration registerMap() 
        { 
            var mapingConfig = new MapperConfiguration( config => {
                config.CreateMap<People, PeopleDto>();
                config.CreateMap<PeopleDto, People>();
                config.CreateMap<Materia, MateriaDto>();
                config.CreateMap<MateriaDto, Materia>();
                config.CreateMap<Vehicles, VehiclesDto>();
                config.CreateMap<VehiclesDto, Vehicles>();
                config.CreateMap<Weapons, WeaponsDto>();
                config.CreateMap<WeaponsDto, Weapons>();
                config.CreateMap<Professions, ProfessionsDto>();
                config.CreateMap<ProfessionsDto, Professions>();
                config.CreateMap<Enemies, EnemiesDto>();
                config.CreateMap<EnemiesDto, Enemies>();
                config.CreateMap<People_Materia, PeopleMateriaDto>().ForMember(dest => dest.NameMateria, opt => opt.MapFrom(src =>src.Materia.Name)).ForMember(dest => dest.namePeople, opt => opt.MapFrom(src => src.People.Name));
                config.CreateMap<PeopleMateriaDto, People_Materia>();
            });
            return mapingConfig;
        }
    }
}
