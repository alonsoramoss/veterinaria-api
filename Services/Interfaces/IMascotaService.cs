using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IMascotaService
    {
        Task<IEnumerable<Mascota>> ObtenerMascotasAsync();
        Task guardarMascota(Mascota mascota);
        Task updateMascota(Mascota mascota);
        Task deleteMascota(int id);
    }
}
