
using UnidadVentas.CapaDeDatos.Repositorio.Repo.Interfaces;
using UnidadVentas.CapaDeDatos.Repositorio.Unidad.Interfaces;

namespace UnidadVentas.CapaDeDatos.Contexto
{
    /// <summary>
    /// P0002.2 La interfaz que determina las propiedades que se pueden consumir por el proyecto
    /// </summary>
    public interface IUnidadDeTrabajo
    {
        IRepoAcampantes RepoAcampante { get; }
        IRepoCampamento RepoCampamento { get; }
        IRepoCiudad RepoCiudad { get; }
        IRepoEvento RepoEvento { get; }
        IRepoHistorial RepoHistorial { get; }
        IRepoOrganizador RepoOrganizador { get; }   
        IRepoTransporte RepoTransporte { get; }
        IRepoTipoTransporte RepoTipoTransporte { get; }
        IRepoTutor RepoTutor { get; }
    }
}
