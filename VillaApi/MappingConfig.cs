﻿using AutoMapper;
using VillaApi.Models;
using VillaApi.Models.DTO;

namespace VillaApi
{
    public class MappingConfig : Profile
    {
        public MappingConfig()
        {
            CreateMap<Villa, VillaDTO>().ReverseMap();
            CreateMap<Villa, VillaCreateDTO>().ReverseMap();
            CreateMap<Villa, VillaCreateDTO>().ReverseMap();
        }
    }
}