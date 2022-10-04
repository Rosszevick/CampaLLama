using Microsoft.EntityFrameworkCore;

namespace UnidadVentas.CapaDeDatos.Contexto
{
    /// <summary>
    /// P0001.1 La interfaz debe garantizar lo que debe hacer la clase que herede de EL. Y  solo genera las firmas de los metodos
    /// o propiedades 
    /// </summary>
    /// <typeparam name="TEntidad"> Es un parametro que indica que podemos recibir una clase para diferenciar que DTO se esta implementando </typeparam>
    public interface IBaseRepositorio<TEntidad>  where TEntidad : class
    {
        DbSet<TEntidad> DbSetEntidad { get; }
        IQueryable<TEntidad>ObtenerTodo();

        TEntidad Crear(TEntidad entidad);
        TEntidad Modificar(TEntidad entidad);
        TEntidad Eliminar(TEntidad entidad);
    }
}
