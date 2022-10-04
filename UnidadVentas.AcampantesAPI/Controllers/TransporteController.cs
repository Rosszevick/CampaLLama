using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UnidadVenta.Negocio.Unidades;
using UnidadVenta.Negocio.Unidades.Unidad.Interfaces;
using UnidadVentas.Modelos;

namespace UnidadVentas.TransporteAPI.Controllers
{
    /// <summary>
    ///P0002.6 Permite la creacion de acciones para la escucha y estas deben especificar si son GET o POST 
    ///Deben llevar una anotacion Route que indique el nombre para identificar la accion 
    ///Se debe crear una variable de el negocio que representa para poder acceder a los metodos
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class TransporteController : ControllerBase
    {

        private readonly INegTransporte negTransporte;

        /// <summary>
        /// Se usa el constructor para consumir la inyeccion de dependencia y se recibe como parametro
        /// la interfaz de lo que se necesta implementar, para asignarlo a una variable privada a la que podamos utilizar
        /// </summary>
        /// <param name="transporte"></param>

        public TransporteController(INegTransporte transporte)
        {

            this.negTransporte = transporte;
        }

        /// <summary>
        /// Metodo para obtener estado de transporte
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("Obtener")]
        public IActionResult Obtener()
        {

            return Ok(negTransporte.Transporte());
        }
        /// <summary>
        /// Metodo para obtener estado de transporte
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route("Guardar")]
        public IActionResult Guardar([FromBody] MTransporte transporte)
        {

            //clonarlo y cambiar los datos

            return Ok(negTransporte.Guardar(transporte));
        }
        /// <summary>
        /// Metodo para guardar acampantes
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route("Eliminar")]
        public IActionResult Eliminar([FromBody] MTransporte transporte)
        {

            //clonarlo y cambiar los datos

            return Ok(negTransporte.Eliminar(transporte));
        }
        /// <summary>
        /// Metodo para guardar acampantes
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route("Modificar")]
        public IActionResult Modificar([FromBody] MTransporte transporte)
        {

            //clonarlo y cambiar los datos

            return Ok(negTransporte.Modificar(transporte));
        }
    }
}
