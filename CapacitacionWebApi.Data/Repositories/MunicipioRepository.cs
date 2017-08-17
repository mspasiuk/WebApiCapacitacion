using CapacitacionWebApi.Data.Infrastructure;
using CapacitacionWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapacitacionWebApi.Data.Repositories
{
    public class MunicipioRepository : RepositoryBase<Municipio>, IMunicipioRepository
    {
        public MunicipioRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }

    public interface IMunicipioRepository : IRepository<Municipio>
    {

    }
}
