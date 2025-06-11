using Domain;
using WebAPI.DTOs;
using Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CitaController : ControllerBase
    {
        private readonly ICitaService _citaService;

        public CitaController(ICitaService citaService)
        {
            _citaService = citaService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var citas = await _citaService.ObtenerCitasAsync();

            var result = citas.Select(c => new CitaDto
            {
                Id = c.Id,
                Fecha = c.Fecha,
                IdMascota = c.IdMascota,
                IdVeterinario = c.IdVeterinario,
                IdServicio = c.IdServicio
            });

            return Ok(result);
        }

        [HttpPost("GuardarCita")]
        public async Task<IActionResult> GuardarCita([FromBody] CitaDto dto)
        {
            var cita = new Cita
            {
                Fecha = dto.Fecha,
                IdMascota = dto.IdMascota,
                IdVeterinario = dto.IdVeterinario,
                IdServicio = dto.IdServicio
            };

            await _citaService.guardarCita(cita);
            return CreatedAtAction(nameof(Get), new { id = cita.Id }, dto);
        }

        [HttpPut("UpdateCita")]
        public async Task<IActionResult> UpdateCita([FromBody] CitaDto dto)
        {
            var cita = new Cita
            {
                Id = dto.Id,
                Fecha = dto.Fecha,
                IdMascota = dto.IdMascota,
                IdVeterinario = dto.IdVeterinario,
                IdServicio = dto.IdServicio
            };

            await _citaService.updateCita(cita);
            return Ok();
        }

        [HttpDelete("DeleteCita")]
        public async Task<IActionResult> DeleteCita(int id)
        {
            await _citaService.deleteCita(id);
            return NoContent();
        }
    }
}
