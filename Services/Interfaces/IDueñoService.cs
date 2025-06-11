using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IDueñoService
    {
        Task<IEnumerable<Dueño>> ObtenerDueñosAsync();
        Task guardarDueño(Dueño dueño);
        Task updateDueño(Dueño dueño);
        Task deleteDueño(int id);
    }
}
