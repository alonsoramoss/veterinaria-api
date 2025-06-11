using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Domain
{
    public class Dueño
    {
        public int Id { get; set; }
        public required string Nombre { get; set; }
        public required string Telefono { get; set; }
        public string? Direccion { get; set; }
        public string? Email { get; set; }

        [JsonIgnore]
        public ICollection<Mascota> Mascotas { get; set; } = new List<Mascota>();
    }
}
