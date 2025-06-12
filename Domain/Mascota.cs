using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Domain
{
    public class Mascota
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Especie { get; set; }
        public string? Raza { get; set; }
        public int Edad { get; set; }
        public double Peso { get; set; }
        public string? Sexo { get; set; }
        public int DueñoId { get; set; }

        [JsonIgnore]
        public ICollection<Cita> Citas { get; set; } = new List<Cita>();
    }
}
