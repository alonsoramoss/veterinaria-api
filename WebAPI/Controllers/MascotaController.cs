using Domain;
using Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
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
            return Ok(await _mascotaService.ObtenerMascotasAsync());
        }

        [HttpPost]
        [Route("GuardarMascota")]
        public async Task<IActionResult> GuardarMascota([FromBody] Mascota mascota)
        {
            await _mascotaService.guardarMascota(mascota);
            return CreatedAtAction(nameof(Get), new { id = mascota.Id }, mascota);
        }

        [HttpPut]
        [Route("UpdateMascota")]
        public async Task<IActionResult> UpdateMascota([FromBody] Mascota mascota)
        {
            await _mascotaService.updateMascota(mascota);
            return Ok();
        }

        [HttpDelete]
        [Route("DeleteMascota")]
        public async Task<IActionResult> DeleteMascota(int id)
        {
            await _mascotaService.deleteMascota(id);
            return NoContent();
        }
    }
}
