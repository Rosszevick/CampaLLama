using UnidadVentas.CapaDeDatos.Contexto;
using UnidadVentas.CapaDeDatos.Entidades;

namespace UnidadVentas.CapaDeDatos.Repositorio.Unidad.Interfaces
{
    public interface IRepoTransporte : IBaseRepositorio<DTOTransporte>
    {
        public List<DTOTransporte> ObtenerTransporte();
        public DTOTransporte AgregarTransporte(DTOTransporte transporte);
        public DTOTransporte ModificaTransporte(DTOTransporte transporte);
        public DTOTransporte BorrarTransporte(DTOTransporte transporte);

    }
}
