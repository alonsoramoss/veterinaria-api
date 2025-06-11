using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface ICitaService
    {
        Task<IEnumerable<Cita>> ObtenerCitasAsync();
        Task guardarCita(Cita cita);
        Task updateCita(Cita cita);
        Task deleteCita(int id);
    }
}
