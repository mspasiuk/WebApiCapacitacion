using CapacitacionWebApi.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapacitacionWebApi.Data.Configuration
{
    public class MunicipioConfiguration : EntityTypeConfiguration<Municipio>
    {
        public MunicipioConfiguration()
        {
            ToTable("Municipios");
            Property(m => m.Id).IsRequired();
            Property(m => m.Nombre).IsRequired().HasMaxLength(80);
            Property(m => m.ProvinciaId).IsRequired();
        }
    }
}
