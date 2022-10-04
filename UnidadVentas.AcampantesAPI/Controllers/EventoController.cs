using Microsoft.AspNetCore.Mvc;
using UnidadVenta.Negocio.Unidades;
using UnidadVenta.Negocio.Unidades.Unidad.Interfaces;
using UnidadVentas.Modelos;

namespace UnidadVentas.EventoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventoController : ControllerBase
    {

        private readonly INegEvento negEvento;

        /// <summary>
        /// Se usa el constructor para consumir la inyeccion de dependencia y se recibe como parametro
        /// la interfaz de lo que se necesta implementar, para asignarlo a una variable privada a la que podamos utilizar
        /// </summary>
        /// <param name="evento"></param>

        public EventoController(INegEvento evento)
        {

            this.negEvento = evento;
        }

        /// <summary>
        /// Metodo para obtener estado de acampantes
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("Obtener")]
        public IActionResult Obtener()
        {

            return Ok(negEvento.Evento());
        }
        /// <summary>
        /// Metodo para obtener estado de acampantes
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route("Guardar")]
        public IActionResult Guardar([FromBody] MEvento evento)
        {

            //clonarlo y cambiar los datos

            return Ok(negEvento.Guardar(evento));
        }
        /// <summary>
        /// Metodo para guardar acampantes
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route("Eliminar")]
        public IActionResult Eliminar([FromBody] MEvento evento)
        {

            //clonarlo y cambiar los datos

            return Ok(negEvento.Eliminar(evento));
        }
        /// <summary>
        /// Metodo para guardar acampantes
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route("Modificar")]
        public IActionResult Modificar([FromBody] MEvento evento)
        {

            //clonarlo y cambiar los datos

            return Ok(negEvento.Modificar(evento));
        }
    }
}
