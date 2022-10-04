using UnidadVentas.CapaDeDatos.Contexto;
using UnidadVentas.CapaDeDatos.Entidades;

namespace UnidadVentas.CapaDeDatos.Repositorio.Unidad.Interfaces
{
    public interface IRepoTipoTransporte : IBaseRepositorio<DTOTipoTransporte> 
    {
        public List<DTOTipoTransporte> ObtenerTipoTransporte();

        public DTOTipoTransporte AgregarTipoTransporte(DTOTipoTransporte tipotransporte);
        public DTOTipoTransporte ModificaTipoTransporte(DTOTipoTransporte tipotransporte);
        public DTOTipoTransporte BorrarTipoTransporte(DTOTipoTransporte tipotransporte);

    }
}
