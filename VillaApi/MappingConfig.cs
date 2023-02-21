using AutoMapper;
using VillaApi.Models;
using VillaApi.Models.DTO.VillaDTOs;

namespace VillaApi
{
    public class MappingConfig : Profile
    {
        public MappingConfig()
        {
            CreateMap<Villa, VillaDTO>().ReverseMap();
            CreateMap<Villa, VillaUpdateDTO>().ReverseMap();
            CreateMap<Villa, VillaCreateDTO>().ReverseMap();
        }
    }
}
