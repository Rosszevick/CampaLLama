using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UnidadVenta.Negocio.Unidades;
using UnidadVenta.Negocio.Unidades.Unidad.Interfaces;
using UnidadVentas.Modelos;

namespace UnidadVentas.CiudadAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CiudadController : ControllerBase
    {
        private readonly INegCiudad negCiudad;

        /// <summary>
        /// Se usa el constructor para consumir la inyeccion de dependencia y se recibe como parametro
        /// la interfaz de lo que se necesta implementar, para asignarlo a una variable privada a la que podamos utilizar
        /// </summary>
        /// <param name="ciudad"></param>

        public CiudadController(INegCiudad ciudad)
        {

            this.negCiudad = ciudad;
        }

        /// <summary>
        /// Metodo para obtener estado de ciudad
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("Obtener")]
        public IActionResult Obtener()
        {

            return Ok(negCiudad.Ciudad());
        }
        /// <summary>
        /// Metodo para obtener estado de ciudad
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route("Guardar")]
        public IActionResult Guardar([FromBody] MCiudad ciudad)
        {

            //clonarlo y cambiar los datos

            return Ok(negCiudad.Guardar(ciudad));
        }
        /// <summary>
        /// Metodo para guardar acampantes
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route("Eliminar")]
        public IActionResult Eliminar([FromBody] MCiudad ciudad)
        {

            //clonarlo y cambiar los datos

            return Ok(negCiudad.Eliminar(ciudad));
        }
        /// <summary>
        /// Metodo para guardar acampantes
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route("Modificar")]
        public IActionResult Modificar([FromBody] MCiudad ciudad)
        {

            //clonarlo y cambiar los datos

            return Ok(negCiudad.Modificar(ciudad));
        }


    }
}
