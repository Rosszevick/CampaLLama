using UnidadVentas.CapaDeDatos.Contexto;
using UnidadVentas.CapaDeDatos.Entidades;
using UnidadVentas.CapaDeDatos.Repositorio.Repo.Interfaces;

namespace UnidadVentas.CapaDeDatos.Repositorio
{
    public class RepoOrganizador : BaseRepositorio<DTOOrganizador>, IRepoOrganizador
    {
        public RepoOrganizador(BD_Contexto _contexto) : base(_contexto)
        {
        }

        public DTOOrganizador AgregarOrganizador(DTOOrganizador organizador)
        {
            return Crear(organizador);
        }

        public DTOOrganizador BorrarOrganizador(DTOOrganizador organizador)
        {
            return Eliminar(organizador);
        }
        
        public DTOOrganizador ModificaOrganizador(DTOOrganizador organizador)
        {
            return Modificar(organizador);
        }

        public List<DTOOrganizador> ObtenerOrganizador()
        {
            return ObtenerTodo().ToList();
        }
    }

}
