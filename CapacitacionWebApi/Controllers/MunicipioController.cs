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
    public class MunicipioController : ApiController
    {
        private readonly IMunicipioService municipioService;


        public MunicipioController(IMunicipioService service)
        {
            this.municipioService = service;
        }

        // GET: api/Municipio
        public IHttpActionResult Get()
        {
            IEnumerable<MunicipioModel> municipiosModel;
            IEnumerable<Municipio> municipios;
            municipios = municipioService.GetMunicipios().ToList();

            municipiosModel = Mapper.Map<IEnumerable<Municipio>, IEnumerable<MunicipioModel>>(municipios);
            return Ok(municipiosModel);
        }

        // GET: api/Municipio/5
        public IHttpActionResult Get(int id)
        {
            MunicipioModel municipio;
            var muni = municipioService.GetMunicipio(id);
            if (muni == null)
                return NotFound();

            municipio = Mapper.Map<Municipio, MunicipioModel>(muni);

            return Ok(municipio);

        }

        // POST: api/Municipio
        public IHttpActionResult Post(MunicipioModel municipio)
        {
            Municipio municipioDomain;
            municipioDomain = Mapper.Map<MunicipioModel, Municipio>(municipio);
            municipioService.CreateMunicipio(municipioDomain);
            municipioService.Save();
            return Created(string.Format("/api/municipio/{0}", municipio.Id), municipio);
        }

        // PUT: api/Municipio/5
        public IHttpActionResult Put(int id, MunicipioModel municipio)
        {
            Municipio municipioDomain;
            municipioDomain = Mapper.Map<MunicipioModel, Municipio>(municipio);
         

            if (municipioService.GetMunicipio(id) == null)
            {
                return NotFound();
            }
            municipioService.UpdateMunicipio(municipioDomain);
            municipioService.Save();
            return Ok();
        }

        // DELETE: api/Municipio/5
        public void Delete(int id)
        {
            municipioService.DeleteMunicipio(id);
            municipioService.Save();

        }
    }
}
