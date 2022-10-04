using UnidadVentas.CapaDeDatos.Contexto;
using UnidadVentas.CapaDeDatos.Entidades;

namespace UnidadVentas.CapaDeDatos.Repositorio.Unidad.Interfaces
{
    public interface IRepoHistorial : IBaseRepositorio<DTOHistorial>
    {
        public List<DTOHistorial> ObtenerHistorial();

        public DTOHistorial AgregarHistorial(DTOHistorial historial);
        public DTOHistorial ModificaHistorial(DTOHistorial historial);
        public DTOHistorial BorrarHistorial(DTOHistorial historial);

    }
}
