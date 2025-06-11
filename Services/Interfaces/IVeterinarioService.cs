using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IVeterinarioService
    {
        Task<IEnumerable<Veterinario>> ObtenerVeterinariosAsync();
        Task guardarVeterinario(Veterinario veterinario);
        Task updateVeterinario(Veterinario veterinario);
        Task deleteVeterinario(int id);
    }
}
