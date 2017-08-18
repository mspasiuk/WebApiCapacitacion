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
            this.CreateMap<Provincia, ProvinciaModel>();
            this.CreateMap<Municipio, ProvinciaModel>();
        }
    }
}