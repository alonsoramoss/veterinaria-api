using Domain;
using Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VeterinarioController : ControllerBase
    {
        private readonly IVeterinarioService _veterinarioService;

        public VeterinarioController(IVeterinarioService veterinarioService)
        {
            _veterinarioService = veterinarioService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _veterinarioService.ObtenerVeterinariosAsync());
        }

        [HttpPost]
        [Route("GuardarVeterinario")]
        public async Task<IActionResult> GuardarVeterinario([FromBody] Veterinario veterinario)
        {
            await _veterinarioService.guardarVeterinario(veterinario);
            return CreatedAtAction(nameof(Get), new { id = veterinario.Id }, veterinario);
        }

        [HttpPut]
        [Route("UpdateVeterinario")]
        public async Task<IActionResult> UpdateVeterinario([FromBody] Veterinario veterinario)
        {
            await _veterinarioService.updateVeterinario(veterinario);
            return Ok();
        }

        [HttpDelete]
        [Route("DeleteVeterinario")]
        public async Task<IActionResult> DeleteVeterinario(int id)
        {
            await _veterinarioService.deleteVeterinario(id);
            return NoContent();
        }
    }
}
