using UnidadVentas.CapaDeDatos.Contexto;
using UnidadVentas.CapaDeDatos.Entidades;
using UnidadVentas.CapaDeDatos.Repositorio.Unidad.Interfaces;

namespace UnidadVentas.CapaDeDatos.Repositorio
{
    public class RepoHistorial : BaseRepositorio<DTOHistorial>, IRepoHistorial
    {
        public RepoHistorial(BD_Contexto _contexto) : base(_contexto)
        {
        }

        public DTOHistorial AgregarHistorial(DTOHistorial historial)
        {
            return Crear(historial);
        }

        public DTOHistorial BorrarHistorial(DTOHistorial historial)
        {
            return Eliminar(historial);
        }

        public DTOHistorial ModificaHistorial(DTOHistorial historial)
        {
            return Modificar(historial);
        }

        public List<DTOHistorial> ObtenerHistorial()
        {
            return ObtenerTodo().ToList();

        }

        
    }
}
