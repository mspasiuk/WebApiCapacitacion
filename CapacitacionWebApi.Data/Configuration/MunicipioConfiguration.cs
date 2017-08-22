using CapacitacionWebApi.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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
            ToTable("Municipios").HasKey(pk => pk.Id);
            Property(m => m.Id).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(m => m.Nombre).IsRequired().HasMaxLength(80);
            Property(m => m.ProvinciaId);
        }
    }
}
