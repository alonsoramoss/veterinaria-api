namespace WebAPI.DTOs
{
    public class CitaDto
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public int IdMascota { get; set; }
        public int IdVeterinario { get; set; }
        public int IdServicio { get; set; }
    }
}
