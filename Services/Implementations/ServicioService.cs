using Domain;
using Infrastructure.Repositories;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Implementations
{
    public class ServicioService : IServicioService
    {
        private readonly GenericRepository<Servicio> _servicioRepo;

        public ServicioService(GenericRepository<Servicio> servicioRepo)
        {
            _servicioRepo = servicioRepo;
        }

        public async Task<IEnumerable<Servicio>> ObtenerServiciosAsync()
        {
            var servicios = await _servicioRepo.GetAllAsync();
            return servicios;
        }

        public async Task guardarServicio(Servicio servicio)
        {
            await _servicioRepo.AddAsync(servicio);
        }

        public async Task updateServicio(Servicio servicio)
        {
            await _servicioRepo.UpdateAsync(servicio);
        }

        public async Task deleteServicio(int id)
        {
            await _servicioRepo.DeleteAsync(id);
        }
    }
}