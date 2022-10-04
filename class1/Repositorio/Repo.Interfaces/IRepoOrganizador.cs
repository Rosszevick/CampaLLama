using UnidadVentas.CapaDeDatos.Contexto;
using UnidadVentas.CapaDeDatos.Entidades;

namespace UnidadVentas.CapaDeDatos.Repositorio.Repo.Interfaces
{
    public interface IRepoOrganizador : IBaseRepositorio<DTOOrganizador>
    {
        public List<DTOOrganizador> ObtenerOrganizador();

        public DTOOrganizador AgregarOrganizador(DTOOrganizador organizador);
        public DTOOrganizador ModificaOrganizador(DTOOrganizador organizador);
        public DTOOrganizador BorrarOrganizador(DTOOrganizador organizador);
    }

}
