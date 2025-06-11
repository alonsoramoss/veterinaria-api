using Domain;
using Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DueñoController : ControllerBase
    {
        private readonly IDueñoService _dueñoService;

        public DueñoController(IDueñoService dueñoService)
        {
            _dueñoService = dueñoService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _dueñoService.ObtenerDueñosAsync());
        }

        [HttpPost]
        [Route("GuardarDueño")]
        public async Task<IActionResult> GuardarDueño([FromBody] Dueño dueño)
        {
            await _dueñoService.guardarDueño(dueño);
            return CreatedAtAction(nameof(Get), new { id = dueño.Id }, dueño);
        }

        [HttpPut]
        [Route("UpdateDueño")]
        public async Task<IActionResult> UpdateDueño([FromBody] Dueño dueño)
        {
            await _dueñoService.updateDueño(dueño);
            return Ok();
        }

        [HttpDelete]
        [Route("DeleteDueño")]
        public async Task<IActionResult> DeleteDueño(int id)
        {
            await _dueñoService.deleteDueño(id);
            return NoContent();
        }
    }
}
