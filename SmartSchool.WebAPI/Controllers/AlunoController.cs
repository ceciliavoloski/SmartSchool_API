using Microsoft.AspNetCore.Mvc;

namespace SmartSchool.WebAPI.Controllers
{
    [ApiController] // Evita fazer vlidações em cada action da controller
    [Route("api/[controller]")] // O nome da URL
    public class AlunoController : ControllerBase
    {
        public AlunoController() {
            
        }
        [HttpGet] // Indica que o método abaixo é get
        public IActionResult Get()
        {
            return Ok("Alunos: Marca, Fabio, Carlos, Ana");
        }
    }
}