using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapacitacionWebApi.Models
{
    public class Municipio : EntityBase
    {
        public string Nombre { get; set; }
        public int ProvinciaId { get; set; }
        public virtual Provincia Provincia { get; set; }
    }
}
