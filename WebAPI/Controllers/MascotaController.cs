using Domain;
using WebAPI.DTOs;
using Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MascotaController : ControllerBase
    {
        private readonly IMascotaService _mascotaService;

        public MascotaController(IMascotaService mascotaService)
        {
            _mascotaService = mascotaService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var mascotas = await _mascotaService.ObtenerMascotasAsync();

            var result = mascotas.Select(m => new MascotaDto
            {
                Id = m.Id,
                Nombre = m.Nombre,
                Especie = m.Especie,
                Raza = m.Raza,
                Edad = m.Edad,
                Peso = m.Peso,
                Sexo = m.Sexo,
                IdDueño = m.IdDueño
            });

            return Ok(result);
        }

        [HttpPost("GuardarMascota")]
        public async Task<IActionResult> GuardarMascota([FromBody] MascotaDto dto)
        {
            var mascota = new Mascota
            {
                Nombre = dto.Nombre,
                Especie = dto.Especie,
                Raza = dto.Raza,
                Edad = dto.Edad,
                Peso = dto.Peso,
                Sexo = dto.Sexo,
                IdDueño = dto.IdDueño
            };

            await _mascotaService.guardarMascota(mascota);
            return CreatedAtAction(nameof(Get), new { id = mascota.Id }, dto);
        }

        [HttpPut("UpdateMascota")]
        public async Task<IActionResult> UpdateMascota([FromBody] MascotaDto dto)
        {
            var mascota = new Mascota
            {
                Id = dto.Id,
                Nombre = dto.Nombre,
                Especie = dto.Especie,
                Raza = dto.Raza,
                Edad = dto.Edad,
                Peso = dto.Peso,
                Sexo = dto.Sexo,
                IdDueño = dto.IdDueño
            };

            await _mascotaService.updateMascota(mascota);
            return Ok();
        }

        [HttpDelete("DeleteMascota")]
        public async Task<IActionResult> DeleteMascota(int id)
        {
            await _mascotaService.deleteMascota(id);
            return NoContent();
        }
    }
}
