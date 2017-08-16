using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapacitacionWebApi.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        Entities Init();
    }
}
