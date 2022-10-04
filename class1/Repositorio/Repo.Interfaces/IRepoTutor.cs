
using UnidadVentas.CapaDeDatos.Contexto;
using UnidadVentas.CapaDeDatos.Entidades;

namespace UnidadVentas.CapaDeDatos.Repositorio.Unidad.Interfaces
{
    public interface IRepoTutor : IBaseRepositorio<DTOTutor>
    {
        public List<DTOTutor> ObtenerTutor();
        public DTOTutor AgregarTutor(DTOTutor tutor);
        public DTOTutor ModificaTutor(DTOTutor tutor);
        public DTOTutor BorrarTutor(DTOTutor tutor);

    }
}
