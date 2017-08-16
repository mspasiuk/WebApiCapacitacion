using CapacitacionWebApi.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapacitacionWebApi.Data
{
    public class DataSeed : DropCreateDatabaseIfModelChanges<Entities>
    {
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
                    Nombre="Buenos Aires"
                },
                new Provincia
                {
                    Nombre= "Cordoba"
                }
            };
        }

        private static List<Municipio> GetMunicipios()
        {
            return new List<Municipio>
            {
                new Municipio
                {
                    Nombre= "La Plata",
                    ProvinciaId=1
                },
                new Municipio
                {
                    Nombre= "Carlos Paz",
                    ProvinciaId=2
                }
            };
        }
    }
}
