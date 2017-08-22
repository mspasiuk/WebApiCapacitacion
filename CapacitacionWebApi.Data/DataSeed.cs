using CapacitacionWebApi.Models;
using SQLite.CodeFirst;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapacitacionWebApi.Data
{
    public class DataSeed : SqliteDropCreateDatabaseAlways<Entities>
    {
        public DataSeed (DbModelBuilder modelBuilder) : base(modelBuilder)
        {

        }

        protected override void Seed(Entities context)
        {
            GetProvincias().ForEach(p => context.Provincias.Add(p));
            GetMunicipios().ForEach(m => context.Municipios.Add(m));

            context.Commit();
        }

        private static List<Provincia> GetProvincias()
        {
            return new List<Provincia>
            {
                new Provincia
                {
                    Id=1,
                    Nombre="Buenos Aires"
                },
                new Provincia
                {
                    Id=2,
                    Nombre = "Cordoba"
                }
            };
        }

        private static List<Municipio> GetMunicipios()
        {
            return new List<Municipio>
            {
                new Municipio
                {
                    Id=1,
                    Nombre = "La Plata",
                    ProvinciaId=1
                },
                new Municipio
                {
                    Id=2,
                    Nombre = "Carlos Paz",
                    ProvinciaId=2
                }
            };
        }
    }
}
