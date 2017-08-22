using CapacitacionWebApi.Data.Configuration;
using CapacitacionWebApi.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CapacitacionWebApi.Data
{
    public class Entities: DbContext
    {
        public Entities(): base("name=Entities") { }

        public DbSet<Municipio> Municipios { get; set; }
        public DbSet<Provincia> Provincias { get; set; }

        public virtual void Commit()
        {
            base.SaveChanges();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            var sqliteConnectionInitializer = new DataSeed(modelBuilder);
            Database.SetInitializer(sqliteConnectionInitializer);
            modelBuilder.Configurations.Add(new MunicipioConfiguration());
            modelBuilder.Configurations.Add(new ProvinciaConfiguration());
        }
    }
}
