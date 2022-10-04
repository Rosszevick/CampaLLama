using Microsoft.AspNetCore.Mvc;
using UnidadVenta.Negocio.Unidades.Unidad.Interfaces;
using UnidadVentas.Modelos;

namespace UnidadVentas.OrganizadorAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrganizadorController : ControllerBase
    {

        private readonly INegOrganizador negOrganizador;

        /// <summary>
        /// Se usa el constructor para consumir la inyeccion de dependencia y se recibe como parametro
        /// la interfaz de lo que se necesta implementar, para asignarlo a una variable privada a la que podamos utilizar
        /// </summary>
        /// <param name="organizador"></param>

        public OrganizadorController(INegOrganizador organizador)
        {

            this.negOrganizador = organizador;
        }

        /// <summary>
        /// Metodo para obtener estado de organizador
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("Obtener")]
        public IActionResult Obtener()
        {
            return Ok(negOrganizador.Organizador());
        }
        /// <summary>
        /// Metodo para obtener estado de organizador
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route("Guardar")]
        public IActionResult Guardar([FromBody] MOrganizador organizador)
        {

            //clonarlo y cambiar los datos

            return Ok(negOrganizador.Guardar(organizador));
        }
        /// <summary>
        /// Metodo para guardar acampantes
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route("Eliminar")]
        public IActionResult Eliminar([FromBody] MOrganizador organizador)
        {

            //clonarlo y cambiar los datos

            return Ok(negOrganizador.Eliminar(organizador));
        }
        /// <summary>
        /// Metodo para guardar acampantes
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route("Modificar")]
        public IActionResult Modificar([FromBody] MOrganizador organizador)
        {

            //clonarlo y cambiar los datos

            return Ok(negOrganizador.Modificar(organizador));
        }

    }
}
