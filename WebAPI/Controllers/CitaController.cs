using Domain;
using Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
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
            return Ok(await _citaService.ObtenerCitasAsync());
        }

        [HttpPost]
        [Route("GuardarCita")]
        public async Task<IActionResult> GuardarCita([FromBody] Cita cita)
        {
            await _citaService.guardarCita(cita);
            return CreatedAtAction(nameof(Get), new { id = cita.Id }, cita);
        }

        [HttpPut]
        [Route("UpdateCita")]
        public async Task<IActionResult> UpdateCita([FromBody] Cita cita)
        {
            await _citaService.updateCita(cita);
            return Ok();
        }

        [HttpDelete]
        [Route("DeleteCita")]
        public async Task<IActionResult> DeleteCita(int id)
        {
            await _citaService.deleteCita(id);
            return NoContent();
        }
    }
}
