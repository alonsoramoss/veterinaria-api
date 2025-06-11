using Domain;
using Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServicioController : ControllerBase
    {
        private readonly IServicioService _servicioService;

        public ServicioController(IServicioService servicioService)
        {
            _servicioService = servicioService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _servicioService.ObtenerServiciosAsync());
        }

        [HttpPost]
        [Route("GuardarServicio")]
        public async Task<IActionResult> GuardarServicio([FromBody] Servicio servicio)
        {
            await _servicioService.guardarServicio(servicio);
            return CreatedAtAction(nameof(Get), new { id = servicio.Id }, servicio);
        }

        [HttpPut]
        [Route("UpdateServicio")]
        public async Task<IActionResult> UpdateServicio([FromBody] Servicio servicio)
        {
            await _servicioService.updateServicio(servicio);
            return Ok();
        }

        [HttpDelete]
        [Route("DeleteServicio")]
        public async Task<IActionResult> DeleteServicio(int id)
        {
            await _servicioService.deleteServicio(id);
            return NoContent();
        }
    }
}
