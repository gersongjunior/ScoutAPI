using ScoutApi.Models;
using Microsoft.AspNetCore.Mvc;



namespace ScoutApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EquipeController : ControllerBase
    {
        private static List<Equipe> equipes = new List<Equipe>();
        private static int id = 1;

        [HttpPost]
        public IActionResult AdicionaEquipe([FromBody] Equipe equipe)
        {
            equipe.Id = id++;
            equipes.Add(equipe);
            return CreatedAtAction(nameof(RecuperaEquipesPorId), new { Id = equipe.Id }, equipe);
            
        }

        [HttpGet]
        public IActionResult RecuperaEquipes()
        {
            return Ok(equipes);
        }

        [HttpGet("{id}")]
        public IActionResult RecuperaEquipesPorId(int id)
        {
            Equipe equipe = equipes.FirstOrDefault(equipe => equipe.Id == id);
            if(equipe != null)
            {
                return Ok(equipe);
            }
            return NotFound();
        }
    }
}
