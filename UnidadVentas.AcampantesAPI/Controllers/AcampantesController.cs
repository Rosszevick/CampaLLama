using Microsoft.AspNetCore.Mvc;
using UnidadVenta.Negocio.Unidades.Unidad.Interfaces;
using UnidadVentas.Modelos;

namespace UnidadVentas.AcampantesAPI.Controllers
{
    /// <summary>
    ///P0002.6 Permite la creacion de acciones para la escucha y estas deben especificar si son GET o POST 
    ///Deben llevar una anotacion Route que indique el nombre para identificar la accion 
    ///Se debe crear una variable de el negocio que representa para poder acceder a los metodos
    /// </summary>
    [Route("API/[controller]")]
    [ApiController]
    public class AcampantesController : ControllerBase
    {
        private readonly INegAcampantes negAcampantes;     
        /// <summary>
        /// P0003.1 Se usa el constructor para consumir la inyeccion de dependencia y se recibe como parametro
        /// la interfaz de lo que se necesta implementar, para asignarlo a una variable privada a la que podamos utilizar
        /// </summary>
        /// <param name="acampantes"></param>
        public AcampantesController(INegAcampantes acampantes)
        {        
            this.negAcampantes = acampantes;
        }
        /// <summary>
        /// Metodo para obtener estado de acampantes
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("Obtener")]
        public IActionResult Obtener()
        {
            return Ok(negAcampantes.Acampantes());
        }
        /// <summary>
        /// Metodo para guardar acampantes
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route("Guardar")]
        public IActionResult Guardar( [FromBody] MAcampantes acampantes)
        {
            //clonarlo y cambiar los datos
            return Ok(negAcampantes.Guardar(acampantes));
        }
        /// <summary>
        /// Metodo para guardar acampantes
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route("Eliminar")]
        public IActionResult Eliminar([FromBody] MAcampantes acampantes)
        {

            //clonarlo y cambiar los datos

            return Ok(negAcampantes.Eliminar(acampantes));
        }
        /// <summary>
        /// Metodo para guardar acampantes
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route("Modificar")]
        public IActionResult Modificar([FromBody] MAcampantes acampantes)
        {

            //clonarlo y cambiar los datos

            return Ok(negAcampantes.Modificar(acampantes));
        }
    }
}
 