using UnidadVentas.CapaDeDatos.Contexto;
using UnidadVentas.CapaDeDatos.Entidades;
using UnidadVentas.CapaDeDatos.Repositorio.Unidad.Interfaces;

namespace UnidadVentas.CapaDeDatos.Repositorio
{
    public class RepoTransporte : BaseRepositorio<DTOTransporte>, IRepoTransporte
    {
        public RepoTransporte(BD_Contexto _contexto) : base(_contexto)
        {
        }

        public DTOTransporte AgregarTransporte(DTOTransporte transporte)
        {
            return Crear(transporte);
        }

        public DTOTransporte BorrarTransporte(DTOTransporte transporte)
        {
            return Eliminar(transporte);
        }

        public DTOTransporte ModificaTransporte(DTOTransporte transporte)
        {
            return Modificar(transporte);
        }

        public List<DTOTransporte> ObtenerTransporte()
        {
            return ObtenerTodo().ToList();
        }
    }
}
