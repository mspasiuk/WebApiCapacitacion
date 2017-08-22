using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapacitacionWebApi.Data;
using CapacitacionWebApi.Models;
using CapacitacionWebApi.Data.Infrastructure;
using CapacitacionWebApi.Data.Repositories;

namespace CapacitacionWebApi.Service
{

    public interface IMunicipioService
    {
        IEnumerable<Municipio> GetMunicipios();
        Municipio GetMunicipio(int id);
        void CreateMunicipio(Municipio municipio);
        void UpdateMunicipio(Municipio municipio);
        void DeleteMunicipio(int id);
        void Save();
    }

    public class MunicipioService : IMunicipioService
    {
        private readonly IMunicipioRepository municipioRepository;
        private readonly IUnitOfWork unitOfWork;

        public MunicipioService(IMunicipioRepository municipioRepository, IUnitOfWork unitOfWork)
        {
            this.municipioRepository = municipioRepository;
            this.unitOfWork = unitOfWork;
        }

        public void CreateMunicipio(Municipio municipio)
        {
            municipioRepository.Add(municipio);
        }

        public Municipio GetMunicipio(int id)
        {
            var municipio = municipioRepository.GetById(id);
            return municipio;
        }

        public IEnumerable<Municipio> GetMunicipios()
        {
            var municipios = municipioRepository.GetAll();
            return municipios;
        }

        public void UpdateMunicipio(Municipio municipio)
        {
            municipioRepository.Update(municipio);
        }

        public void DeleteMunicipio(int id)
        {
            var municipio = municipioRepository.GetById(id);
            municipioRepository.Delete(municipio);
        }
        public void Save()
        {
            unitOfWork.Commit();
        }
    }
}
