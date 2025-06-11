using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Domain
{
    public class Veterinario
    {
        public int Id { get; set; }
        public required string Nombre { get; set; }
        public string? Especialidad { get; set; }
        public required string NumeroLicencia { get; set; }
        public string? Telefono { get; set; }

        [JsonIgnore]
        public ICollection<Cita> Citas { get; set; } = new List<Cita>();
    }
}
