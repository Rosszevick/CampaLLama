using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UnidadVenta.Negocio.Unidades;
using UnidadVenta.Negocio.Unidades.Unidad.Interfaces;
using UnidadVentas.Modelos;

namespace UnidadVentas.HistorialAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HistorialController : ControllerBase
    {

        private readonly INegHistorial negHistorial;

        /// <summary>
        /// Se usa el constructor para consumir la inyeccion de dependencia y se recibe como parametro
        /// la interfaz de lo que se necesta implementar, para asignarlo a una variable privada a la que podamos utilizar
        /// </summary>
        /// <param name="historial"></param>

        public HistorialController(INegHistorial historial)
        {

            this.negHistorial = historial;
        }

        /// <summary>
        /// Metodo para obtener estado de historial
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("Obtener")]
        public IActionResult Obtener()
        {

            return Ok(negHistorial.Historial());
        }
        /// <summary>
        /// Metodo para obtener estado de historial
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route("Guardar")]
        public IActionResult Guardar([FromBody] MHistorial historial)
        {

            //clonarlo y cambiar los datos

            return Ok(negHistorial.Guardar(historial));
        }
        /// <summary>
        /// Metodo para guardar acampantes
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route("Eliminar")]
        public IActionResult Eliminar([FromBody] MHistorial historial)
        {

            //clonarlo y cambiar los datos

            return Ok(negHistorial.Eliminar(historial));
        }
        /// <summary>
        /// Metodo para guardar acampantes
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route("Modificar")]
        public IActionResult Modificar([FromBody] MHistorial historial)
        {

            //clonarlo y cambiar los datos

            return Ok(negHistorial.Modificar(historial));
        }
    }
}
