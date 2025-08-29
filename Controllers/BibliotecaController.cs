using Microsoft.AspNetCore.Mvc;
using BibliotecaAltium_backend.Classes.Components;
using System.Text.Json;
using BibliotecaAltium_backend.Classes.ParentClasses;

namespace BibliotecaAltium_backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BibliotecaController : ControllerBase
    {
        [HttpPost("post")]
        public IActionResult Create([FromBody] JsonElement componenteJson)
        {
            string? tipo = componenteJson.GetProperty("tipo").GetString();
            if (string.IsNullOrEmpty(tipo))
                return BadRequest("Campo 'tipo' é obrigatório.");

            switch (tipo)
            {
                case "Bateria":
                    BateriasComponentes bateria = JsonSerializer.Deserialize<BateriasComponentes>(componenteJson);
                    break;
                case "Capacitor":
                    CapacitoresComponentes capacitor = JsonSerializer.Deserialize<CapacitoresComponentes>(componenteJson);
                    break;
                default:
                    return BadRequest("Tipo de componente invalido.");
            }

            return Ok(componenteJson);
        }
    }
}
