using AutoMapper;
using CapacitacionWebApi.Models;

namespace CapacitacionWebApi.Mappings
{
    public class ModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ModelToDomainMappings"; }
        }

        public ModelToDomainMappingProfile()
        {
            this.CreateMap<ProvinciaModel, Provincia>()
            .ForMember(dest => dest.Id, opts => opts.MapFrom(src => src.Id))
            .ForMember(dest => dest.Nombre, opts => opts.MapFrom(src => src.Nombre));


            this.CreateMap<MunicipioModel, Municipio>()
              .ForMember(dest => dest.Id, opts => opts.MapFrom(src => src.Id))
              .ForMember(dest => dest.Nombre, opts => opts.MapFrom(src => src.Nombre))
              .ForMember(dest => dest.ProvinciaId, opts => opts.MapFrom(src => src.ProvinciaId));


        }
    }
}