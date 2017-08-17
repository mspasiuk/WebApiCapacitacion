using CapacitacionWebApi.Data.Infrastructure;
using CapacitacionWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapacitacionWebApi.Data.Repositories
{
    public class ProvinciaRepository : RepositoryBase<Provincia>, IProvinciaRepository
    {
        public ProvinciaRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }

    public interface IProvinciaRepository: IRepository<Provincia>
    {

    }
}
