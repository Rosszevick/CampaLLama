using UnidadVentas.CapaDeDatos.Repositorio;
using UnidadVentas.CapaDeDatos.Repositorio.Repo.Interfaces;
using UnidadVentas.CapaDeDatos.Repositorio.Unidad.Interfaces;

namespace UnidadVentas.CapaDeDatos.Contexto
{
    /// <summary>
    /// P0002.3 clase que implementa lo que indica la interfaz e inicializa las propiedades que se pueden utilizar fuera del proyecto
    /// </summary>
    public class UnidadDeTrabajo :IUnidadDeTrabajo 
    {
        protected readonly BD_Contexto contexto;

        public UnidadDeTrabajo(BD_Contexto _contexto) 
        {
            contexto = _contexto;
        }      
        IRepoAcampantes IUnidadDeTrabajo.RepoAcampante => new RepoAcampantes(contexto);
        IRepoCampamento IUnidadDeTrabajo.RepoCampamento => new RepoCampamento(contexto);
        IRepoCiudad IUnidadDeTrabajo.RepoCiudad => new RepoCiudad(contexto);
        IRepoEvento IUnidadDeTrabajo.RepoEvento => new RepoEvento(contexto);
        IRepoHistorial IUnidadDeTrabajo.RepoHistorial => new RepoHistorial(contexto);
        IRepoOrganizador IUnidadDeTrabajo.RepoOrganizador => new RepoOrganizador(contexto);
        IRepoTipoTransporte IUnidadDeTrabajo.RepoTipoTransporte => new RepoTipoTransporte(contexto);
        IRepoTransporte IUnidadDeTrabajo.RepoTransporte => new RepoTransporte(contexto);
        IRepoTutor IUnidadDeTrabajo.RepoTutor => new RepoTutor(contexto);

     
    }
}
