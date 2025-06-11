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
    public class VeterinarioService : IVeterinarioService
    {
        private readonly GenericRepository<Veterinario> _veterinarioRepo;

        public VeterinarioService(GenericRepository<Veterinario> veterinarioRepo)
        {
            _veterinarioRepo = veterinarioRepo;
        }

        public async Task<IEnumerable<Veterinario>> ObtenerVeterinariosAsync()
        {
            var veterinarios = await _veterinarioRepo.GetAllAsync();
            return veterinarios;
        }

        public async Task guardarVeterinario(Veterinario veterinario)
        {
            await _veterinarioRepo.AddAsync(veterinario);
        }

        public async Task updateVeterinario(Veterinario veterinario)
        {
            await _veterinarioRepo.UpdateAsync(veterinario);
        }

        public async Task deleteVeterinario(int id)
        {
            await _veterinarioRepo.DeleteAsync(id);
        }
    }
}