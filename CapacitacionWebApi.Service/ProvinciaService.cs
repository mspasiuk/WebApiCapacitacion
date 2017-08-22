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

    public interface IProvinciaService
    {
        IEnumerable<Provincia> GetProvincias();
        Provincia GetProvincia(int id);
        void CreateProvincia(Provincia provincia);
        void UpdateProvincia(Provincia provincia);
        void DeleteProvincia(int id);
        void Save();
    }

    public class ProvinciaService : IProvinciaService
    {
        private readonly IProvinciaRepository provinciaRepository;
        private readonly IUnitOfWork unitOfWork;

        public ProvinciaService(IProvinciaRepository provinciaRepository, IUnitOfWork unitOfWork)
        {
            this.provinciaRepository = provinciaRepository;
            this.unitOfWork = unitOfWork;
        }

        public void CreateProvincia(Provincia provincia)
        {
            provinciaRepository.Add(provincia);
        }

        public Provincia GetProvincia(int id)
        {
            var provincia = provinciaRepository.GetById(id);
            return provincia;
        }

        public IEnumerable<Provincia> GetProvincias()
        {
            var provincias = provinciaRepository.GetAll();
            return provincias;
        }

        public void UpdateProvincia(Provincia provincia)
        {

            provinciaRepository.Update(provincia);
        }

        public void DeleteProvincia (int id)
        {
            var provincia = provinciaRepository.GetById(id);
            provinciaRepository.Delete(provincia);
        }
        public void Save()
        {
            unitOfWork.Commit();
        }
    }
}
