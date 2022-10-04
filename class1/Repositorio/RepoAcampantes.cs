
using UnidadVentas.CapaDeDatos.Entidades;
using UnidadVentas.CapaDeDatos.Contexto;
using UnidadVentas.CapaDeDatos.Repositorio.Unidad.Interfaces;

namespace UnidadVentas.CapaDeDatos.Repositorio
{
    /// <summary>
    /// P0002.1 Esta clase debe heredar de BaseRepositorio y debe enviar como parametro el DTO que la representa
    /// Tambien debe heredar de la interfaz que lo representa e implementar los metodos que indico la interfaz.
    /// </summary>
    public class RepoAcampantes : BaseRepositorio<DTOAcampantes>, IRepoAcampantes
    {
        // class hereda de base y su interfaz.
        public RepoAcampantes(BD_Contexto _contexto) : base(_contexto)
        {
        }

        public DTOAcampantes AgregarAcampantes(DTOAcampantes acampante)
        {
            return Crear(acampante);
        }

        public DTOAcampantes BorrarAcampantes(DTOAcampantes acampante)
        {
            return Eliminar( acampante);
        }

        public DTOAcampantes ModificaAcampantes(DTOAcampantes acampante)
        {
            return Modificar(acampante);
        }

        public List<DTOAcampantes> ObtenerAcampantes()
        {
            return ObtenerTodo().ToList();

        }
    }
}
 