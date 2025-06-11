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
    public class MascotaService : IMascotaService
    {
        private readonly GenericRepository<Mascota> _mascotaRepo;

        public MascotaService(GenericRepository<Mascota> mascotaRepo)
        {
            _mascotaRepo = mascotaRepo;
        }

        public async Task<IEnumerable<Mascota>> ObtenerMascotasAsync()
        {
            var mascotas = await _mascotaRepo.GetAllAsync();
            return mascotas;
        }

        public async Task guardarMascota(Mascota mascota)
        {
            await _mascotaRepo.AddAsync(mascota);
        }

        public async Task updateMascota(Mascota mascota)
        {
            await _mascotaRepo.UpdateAsync(mascota);
        }

        public async Task deleteMascota(int id)
        {
            await _mascotaRepo.DeleteAsync(id);
        }
    }
}
