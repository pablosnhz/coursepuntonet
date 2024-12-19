using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Core.Dto;
using Core.Entidades;

namespace API.Helpers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // CreateMap<Compania, CompaniaDto>();
            // CreateMap<CompaniaDto, Compania>();

            CreateMap<Compania, CompaniaDto>().ReverseMap();
        }
    }
}