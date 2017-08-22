using AutoMapper;
using CapacitacionWebApi.Models;
using CapacitacionWebApi.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CapacitacionWebApi.Controllers
{
    public class ProvinciaController : ApiController
    {
        private readonly IProvinciaService provinciaService;


        public ProvinciaController( IProvinciaService service)
        {
            this.provinciaService = service;
        }
        
        // GET: api/Provincias
        [Route("api/provincias")]
        public IHttpActionResult Get()
        {
            IEnumerable<ProvinciaModel> provinciasModel;
            IEnumerable<Provincia> provincias;
            provincias = provinciaService.GetProvincias().ToList();
           
            provinciasModel = Mapper.Map<IEnumerable<Provincia>, IEnumerable<ProvinciaModel>>(provincias); 
            return Ok(provinciasModel);
        }

        // GET: api/Provincia/5
        public IHttpActionResult Get(int id)
        {
            ProvinciaModel provincia;
            var prov = provinciaService.GetProvincia(id);
            if (prov == null)
                return NotFound();

            provincia = Mapper.Map<Provincia, ProvinciaModel>(prov);

            return Ok(provincia);
            
        }

        // POST: api/Provincia
        public IHttpActionResult Post(ProvinciaModel provincia)
        {
            Provincia provinciaDomain;
            provinciaDomain = Mapper.Map<ProvinciaModel, Provincia>(provincia);
            provinciaService.CreateProvincia(provinciaDomain);
            provinciaService.Save();
            return Created(string.Format("/api/Provincia/{0}", provincia.Id),provincia);
        }

        // PUT: api/Provincia/5
        public IHttpActionResult Put(int id, ProvinciaModel provincia)
        {
            Provincia provinciaDomain;
            provinciaDomain = Mapper.Map<ProvinciaModel, Provincia>(provincia);
            if (provinciaService.GetProvincia(id)==null)
            {
                return NotFound();
            }
            provinciaService.UpdateProvincia(provinciaDomain);
            provinciaService.Save();
            return Ok();
        }

        // DELETE: api/Provincia/5
        public void Delete(int id)
        {
            provinciaService.DeleteProvincia(id);
            provinciaService.Save();

        }
    }
}
