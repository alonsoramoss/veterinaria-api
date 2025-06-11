namespace WebAPI.DTOs
{
    public class MascotaDto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Especie { get; set; }
        public string? Raza { get; set; }
        public int Edad { get; set; }
        public double Peso { get; set; }
        public string Sexo { get; set; }
        public int IdDueño { get; set; }
    }
}
