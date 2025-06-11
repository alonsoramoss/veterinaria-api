using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IServicioService
    {
        Task<IEnumerable<Servicio>> ObtenerServiciosAsync();
        Task guardarServicio(Servicio servicio);
        Task updateServicio(Servicio servicio);
        Task deleteServicio(int id);
    }
}
