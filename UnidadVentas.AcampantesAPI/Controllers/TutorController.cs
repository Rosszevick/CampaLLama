using Microsoft.AspNetCore.Mvc;
using UnidadVenta.Negocio.Unidades.Unidad.Interfaces;
using UnidadVentas.Modelos;

namespace UnidadVentas.TutorAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TutorController : ControllerBase
    {

        private readonly INegTutor negTutor;

        /// <summary>
        /// Se usa el constructor para consumir la inyeccion de dependencia y se recibe como parametro
        /// la interfaz de lo que se necesta implementar, para asignarlo a una variable privada a la que podamos utilizar
        /// </summary>
        /// <param name="tutor"></param>

        public TutorController(INegTutor tutor)
        {

            this.negTutor = tutor;
        }

        /// <summary>
        /// Metodo para obtener estado de tutor
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("Obtener")]
        public IActionResult Obtener()
        {
            return Ok(negTutor.Tutor());
        }
        /// <summary>
        /// Metodo para obtener estado de tutor
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route("Guardar")]
        public IActionResult Guardar([FromBody] MTutor tutor)
        {

            //clonarlo y cambiar los datos

            return Ok(negTutor.Guardar(tutor));
        }
        /// <summary>
        /// Metodo para guardar acampantes
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route("Eliminar")]
        public IActionResult Eliminar([FromBody] MTutor tutor)
        {

            //clonarlo y cambiar los datos

            return Ok(negTutor.Eliminar(tutor));
        }
        /// <summary>
        /// Metodo para guardar acampantes
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route("Modificar")]
        public IActionResult Modificar([FromBody] MTutor tutor)
        {

            //clonarlo y cambiar los datos

            return Ok(negTutor.Modificar(tutor));
        }
    }
}
