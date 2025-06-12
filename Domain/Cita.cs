using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Domain
{
    public class Cita
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public int MascotaId { get; set; }
        public int VeterinarioId { get; set; }
        public int ServicioId { get; set; }
    }
}
