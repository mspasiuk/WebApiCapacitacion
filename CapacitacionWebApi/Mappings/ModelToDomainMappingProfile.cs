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
            this.CreateMap<ProvinciaModel, Provincia>();
            this.CreateMap<MunicipioModel, Provincia>();
        }
    }
}