using Microsoft.AspNetCore.Mvc;
using UnidadVentas.Negocio.Unidades;

namespace UnidadVentas.CeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AcampantesController : ControllerBase
    {
        private readonly INegAcampante acampante;
        public AcampantesController(INegAcampantes _acampantes)
        {
            this.acampantes = _acampantes;
        }

        [HttpGet]
        [Route("ObtenerAcampantes")]
        public IActionResult ObtenerAcampantes()
        {
            return Ok(acampante.Acampantes());
        }
    }
}
 