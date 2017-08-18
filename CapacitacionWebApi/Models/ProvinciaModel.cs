﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CapacitacionWebApi.Models
{
    public class ProvinciaModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public List<MunicipioModel> Municipios { get; set;}
    }
}