using AutoMapper;
using CapacitacionWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CapacitacionWebApi.Mappings
{
    public class DomainToModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DomainToModelMappings"; }
        }

        public DomainToModelMappingProfile()
        {
            this.CreateMap<Provincia, ProvinciaModel>()
            .ForMember(dest => dest.Id, opts => opts.MapFrom(src => src.Id))
        .ForMember(dest => dest.Nombre, opts => opts.MapFrom(src => src.Nombre));

            this.CreateMap<Municipio, MunicipioModel>()
               .ForMember(dest => dest.Id, opts => opts.MapFrom(src => src.Id))
              .ForMember(dest => dest.Nombre, opts => opts.MapFrom(src => src.Nombre))
              .ForMember(dest => dest.ProvinciaId, opts => opts.MapFrom(src => src.ProvinciaId));

        }
    }
}