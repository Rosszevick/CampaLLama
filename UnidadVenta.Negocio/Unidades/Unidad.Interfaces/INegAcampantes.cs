
using UnidadVentas.Modelos;

namespace UnidadVenta.Negocio.Unidades.Unidad.Interfaces
{
    /// <summary>
    /// P0002.4 Define los metodos de la clase que lo implemente y asegura la no implementacion de DTO
    /// En esta capa se debe utilizaar Modelos
    /// </summary>
    public interface INegAcampantes
    {

        List<MAcampantes> Acampantes();

        public bool Guardar(MAcampantes acampante);

        public bool Modificar(MAcampantes acampante);

        public bool Eliminar(MAcampantes acampante);
    }
}
