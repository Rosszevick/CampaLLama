
using UnidadVentas.CapaDeDatos.Contexto;
using UnidadVentas.CapaDeDatos.Entidades;

namespace UnidadVentas.CapaDeDatos.Repositorio.Unidad.Interfaces
{
    public interface IRepoCiudad : IBaseRepositorio<DTOCiudad>
    {
        public List<DTOCiudad> ObtenerCiudad();
        public DTOCiudad AgregarCiudad(DTOCiudad ciudad);
        public DTOCiudad ModificaCiudad(DTOCiudad ciudad);
        public DTOCiudad BorrarCiudad(DTOCiudad ciudad);
    }
}
