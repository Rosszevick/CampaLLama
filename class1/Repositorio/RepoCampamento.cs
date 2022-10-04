
using UnidadVentas.CapaDeDatos.Contexto;
using UnidadVentas.CapaDeDatos.Entidades;
using UnidadVentas.CapaDeDatos.Repositorio.Unidad.Interfaces;

namespace UnidadVentas.CapaDeDatos.Repositorio
{
    public class RepoCampamento : BaseRepositorio<DTOCampamento>, IRepoCampamento
    {
        public RepoCampamento(BD_Contexto _contexto) : base(_contexto)
        {
        }

        public DTOCampamento AgregarCampamento(DTOCampamento campamento)
        {
            return Crear(campamento);
        }

        public DTOCampamento BorrarCampamento(DTOCampamento campamento)
        {
            return Crear(campamento);
        }

        public DTOCampamento ModificaCampamento(DTOCampamento campamento)
        {
            return Eliminar(campamento);
        }

        public List<DTOCampamento> ObtenerCampamento()
        {

            return ObtenerTodo().ToList();
        }
        

   
    }
}
