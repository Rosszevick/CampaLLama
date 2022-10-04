using UnidadVentas.CapaDeDatos.Contexto;
using UnidadVentas.CapaDeDatos.Entidades;

namespace UnidadVentas.CapaDeDatos.Repositorio.Unidad.Interfaces
{
    /// <summary>
    /// P0002 Se debe crear la interfaz y definirlos los metodos de la clase que los representa
    /// Debe heredar de IBaseRepositorio y debe enviar como parametro el DTO que le corresponda
    /// </summary>
    public interface IRepoAcampantes : IBaseRepositorio<DTOAcampantes>
    {
        // Entre interfaces se heredan ellas mismas
        public List<DTOAcampantes> ObtenerAcampantes();

        public DTOAcampantes AgregarAcampantes(DTOAcampantes acampante);
        public DTOAcampantes ModificaAcampantes(DTOAcampantes acampante);
        public DTOAcampantes BorrarAcampantes(DTOAcampantes acampante);
        
    }
}
