using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UnidadVenta.Negocio.Unidades;
using UnidadVenta.Negocio.Unidades.Unidad.Interfaces;
using UnidadVentas.Modelos;

namespace UnidadVentas.TipoTransporteAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoTransporteController : ControllerBase
    {

        private readonly INegTipoTransporte negTipoTransporte;

        /// <summary>
        /// Se usa el constructor para consumir la inyeccion de dependencia y se recibe como parametro
        /// la interfaz de lo que se necesta implementar, para asignarlo a una variable privada a la que podamos utilizar
        /// </summary>
        /// <param name="tipotransporte"></param>

        public TipoTransporteController(INegTipoTransporte tipotransporte)
        {

            this.negTipoTransporte = tipotransporte;
        }

        /// <summary>
        /// Metodo para obtener estado de tipotransporte
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("Obtener")]
        public IActionResult Obtener()
        {

            return Ok(negTipoTransporte.TipoTransporte());
        }
        /// <summary>
        /// Metodo para obtener estado de tipotransporte
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route("Guardar")]
        public IActionResult Guardar([FromBody] MTipoTransporte tipotransporte)
        {

            //clonarlo y cambiar los datos

            return Ok(negTipoTransporte.Guardar(tipotransporte));
        }
        /// <summary>
        /// Metodo para guardar acampantes
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route("Eliminar")]
        public IActionResult Eliminar([FromBody] MTipoTransporte tipotransporte)
        {

            //clonarlo y cambiar los datos

            return Ok(negTipoTransporte.Eliminar(tipotransporte));
        }
        /// <summary>
        /// Metodo para guardar acampantes
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route("Modificar")]
        public IActionResult Modificar([FromBody] MTipoTransporte tipotransporte)
        {

            //clonarlo y cambiar los datos

            return Ok(negTipoTransporte.Modificar(tipotransporte));
        }

    }
}
