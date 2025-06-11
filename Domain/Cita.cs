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

        public int IdMascota { get; set; }
        public Mascota Mascota { get; set; } = null!;

        public int IdVeterinario { get; set; }
        public Veterinario Veterinario { get; set; } = null!;

        public int IdServicio { get; set; }
        public virtual Servicio Servicio { get; set; } = null!;
    }
}
