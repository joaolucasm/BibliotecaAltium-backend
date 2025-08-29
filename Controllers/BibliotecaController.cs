using BibliotecaAltium_backend.Classes.Components;
using BibliotecaAltium_backend.Classes.ParentClasses;
using BibliotecaAltium_backend.Classes.RealClasses;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

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

            ComponenteBase? componente = tipo switch
            {
                "Bateria" => JsonSerializer.Deserialize<BateriasComponentes>(componenteJson),
                "Capacitor" => JsonSerializer.Deserialize<CapacitoresComponentes>(componenteJson),
                "Circuito Integrado" => JsonSerializer.Deserialize<CircuitosIntegradosComponentes>(componenteJson),
                "Conectores" => JsonSerializer.Deserialize<ConectoresComponentes>(componenteJson),
                "Cristal Oscilador" => JsonSerializer.Deserialize<CristaisOsciladoresComponentes>(componenteJson),
                "Diodo Retificador" => JsonSerializer.Deserialize<DiodosRetificadoresComponentes>(componenteJson),
                "Diodos Schottky" => JsonSerializer.Deserialize<DiodosSchottkyComponentes>(componenteJson),
                "Diodos TVS" => JsonSerializer.Deserialize<DiodosTVSComponentes>(componenteJson),
                "Diodos Zener" => JsonSerializer.Deserialize<DiodosZenerComponentes>(componenteJson),
                "Ferrite Bead" => JsonSerializer.Deserialize<FerriteBeadComponentes>(componenteJson),
                "Furos" => JsonSerializer.Deserialize<FurosComponentes>(componenteJson),
                "Fusivel" => JsonSerializer.Deserialize<FusiveisComponentes>(componenteJson),
                "Indutor" => JsonSerializer.Deserialize<IndutoresComponentes>(componenteJson),
                "LED" => JsonSerializer.Deserialize<LEDComponentes>(componenteJson),
                "Mecanico" => JsonSerializer.Deserialize<MecanicosComponentes>(componenteJson),
                "MOSFET" => JsonSerializer.Deserialize<MOSFETsComponentes>(componenteJson),
                "Placa" => JsonSerializer.Deserialize<PlacasComponentes>(componenteJson),
                "Rele" => JsonSerializer.Deserialize<ReleComponentes>(componenteJson),
                "Resistor" => JsonSerializer.Deserialize<ResistoresComponentes>(componenteJson),
                "Soquete" => JsonSerializer.Deserialize<SoquetesComponentes>(componenteJson),
                "Switch" => JsonSerializer.Deserialize<SwitchesComponentes>(componenteJson),
                "Test Point" => JsonSerializer.Deserialize<TestPointComponentes>(componenteJson),
                "Transformador" => JsonSerializer.Deserialize<TransformadorComponentes>(componenteJson),
                "Transistor" => JsonSerializer.Deserialize<TransistoresComponentes>(componenteJson),
                "Varistores" => JsonSerializer.Deserialize<VaristoresComponentes>(componenteJson),
                _ => null
            };


            return Ok(componente);
        }
    }
}
