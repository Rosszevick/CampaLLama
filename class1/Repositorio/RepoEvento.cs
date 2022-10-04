
using UnidadVentas.CapaDeDatos.Contexto;
using UnidadVentas.CapaDeDatos.Entidades;
using UnidadVentas.CapaDeDatos.Repositorio.Unidad.Interfaces;

namespace UnidadVentas.CapaDeDatos.Repositorio
{
    public class RepoEvento : BaseRepositorio<DTOEvento>, IRepoEvento
    {
        public RepoEvento(BD_Contexto _contexto) : base(_contexto)
        {
        }

        public DTOEvento AgregarEvento(DTOEvento evento)
        {
            return Crear(evento);
        }

        public DTOEvento BorrarEvento(DTOEvento evento)
        {
            return Eliminar(evento);
        }

        public DTOEvento ModificaEvento(DTOEvento evento)
        {
            return Modificar(evento);
        }

        public List<DTOEvento> ObtenerEvento()
        {
            return ObtenerTodo().ToList();
        }
    }
}
