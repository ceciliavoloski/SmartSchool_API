using Microsoft.AspNetCore.Mvc;

namespace SmartSchool.WebAPI.Controllers
{
    [ApiController] // Evita fazer vlidações em cada action da controller
    [Route("api/[controller]")] // O nome da URL
    public class ProfessorController : ControllerBase
    {
        public ProfessorController() {
            
        }
        [HttpGet] // Indica que o método abaixo é get
        public IActionResult Get()
        {
            return Ok("Professores: Lucio, Luisa, Maria, Roger");
        }
    }
}