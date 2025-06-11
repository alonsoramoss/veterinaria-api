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
    public class CitaService : ICitaService
    {
        private readonly GenericRepository<Cita> _citaRepo;

        public CitaService(GenericRepository<Cita> citaRepo)
        {
            _citaRepo = citaRepo;
        }

        public async Task<IEnumerable<Cita>> ObtenerCitasAsync()
        {
            var citas = await _citaRepo.GetAllAsync();
            return citas;
        }

        public async Task guardarCita(Cita cita)
        {
            await _citaRepo.AddAsync(cita);
        }

        public async Task updateCita(Cita cita)
        {
            await _citaRepo.UpdateAsync(cita);
        }

        public async Task deleteCita(int id)
        {
            await _citaRepo.DeleteAsync(id);
        }
    }
}
