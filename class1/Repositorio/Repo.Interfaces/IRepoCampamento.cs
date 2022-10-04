using UnidadVentas.CapaDeDatos.Contexto;
using UnidadVentas.CapaDeDatos.Entidades;

namespace UnidadVentas.CapaDeDatos.Repositorio.Unidad.Interfaces;

    public interface IRepoCampamento : IBaseRepositorio<DTOCampamento>
    {
        public List<DTOCampamento> ObtenerCampamento();

        public DTOCampamento AgregarCampamento(DTOCampamento campamento);
        public DTOCampamento ModificaCampamento(DTOCampamento campamento);
        public DTOCampamento BorrarCampamento(DTOCampamento campamento);


}


