using CapacitacionWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapacitacionWebApi.Models
{
    public class Provincia : EntityBase
    {
        public string Nombre { get; set; }
        public virtual List<Municipio> Municipios { get; set; }
    }
}
