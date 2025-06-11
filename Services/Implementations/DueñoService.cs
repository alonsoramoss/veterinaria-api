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
    public class DueñoService : IDueñoService
    {
        private readonly GenericRepository<Dueño> _dueñoRepo;

        public DueñoService(GenericRepository<Dueño> dueñoRepo)
        {
            _dueñoRepo = dueñoRepo;
        }

        public async Task<IEnumerable<Dueño>> ObtenerDueñosAsync()
        {
            var dueños = await _dueñoRepo.GetAllAsync();
            return dueños;
        }

        public async Task guardarDueño(Dueño dueño)
        {
            await _dueñoRepo.AddAsync(dueño);
        }

        public async Task updateDueño(Dueño dueño)
        {
            await _dueñoRepo.UpdateAsync(dueño);
        }

        public async Task deleteDueño(int id)
        {
            await _dueñoRepo.DeleteAsync(id);
        }
    }
}