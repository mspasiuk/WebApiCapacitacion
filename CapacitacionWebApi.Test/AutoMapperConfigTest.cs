using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CapacitacionWebApi.Mappings;
using AutoMapper;

namespace CapacitacionWebApi.Test
{
    [TestClass]
    public class AutoMapperConfigTest
    {
        

        [TestMethod]
        public void TestDomaintoModelMappings()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.AddProfile<DomainToModelMappingProfile>();
            });
            Mapper.AssertConfigurationIsValid();
        }
        [TestMethod]
        public void TestModeltoDomainMappings()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.AddProfile<ModelToDomainMappingProfile>();
            });
            Mapper.AssertConfigurationIsValid();
        }
    }
}
