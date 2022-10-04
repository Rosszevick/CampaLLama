using Microsoft.AspNetCore.Mvc;
using UnidadVenta.Negocio.Unidades;
using UnidadVenta.Negocio.Unidades.Unidad.Interfaces;
using UnidadVentas.Modelos;

namespace UnidadVentas.AcampantesAPI.Controllers
{
    /// <summary>
    /// Controlador de campamento
    /// </summary>
    
    
    [Route("api/[controller]")]
    [ApiController]
    public class CampamentoController : ControllerBase
    {
        private readonly INegCampamento negCampamento;
        /// <summary>
        /// Se usa el constructor para consumir la inyeccion de dependencia y se recibe como parametro
        /// la interfaz de lo que se necesta implementar, para asignarlo a una variable privada a la que podamos utilizar
        /// </summary>
        /// <param name="campamento"></param>
        public CampamentoController(INegCampamento campamento)
        {
            this.negCampamento = campamento;
        }
        /// <summary>
        /// Metodo para obtener estado de campamento
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("Obtener")]
        public IActionResult Obtener()
        {
            return Ok(negCampamento.Campamento());
        }
        /// <summary>
        /// Metodo para obtener estado de acampantes
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route("Guardar")]
        public IActionResult Guardar([FromBody] MCampamento campamento)
        {
            //clonarlo y cambiar los datos
            return Ok(negCampamento.Guardar(campamento));
        }
        /// <summary>
        /// Metodo para guardar acampantes
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route("Eliminar")]
        public IActionResult Eliminar([FromBody] MCampamento campamento)
        {

            //clonarlo y cambiar los datos

            return Ok(negCampamento.Eliminar(campamento));
        }
        /// <summary>
        /// Metodo para guardar acampantes
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route("Modificar")]
        public IActionResult Modificar([FromBody] MCampamento campamento)
        {

            //clonarlo y cambiar los datos

            return Ok(negCampamento.Modificar(campamento));
        }
    }
}
