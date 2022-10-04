using Microsoft.EntityFrameworkCore;

namespace UnidadVentas.CapaDeDatos.Contexto
{
    /// <summary>
    /// P0001.2 clase que implementa las firmas generadas en la interfaz y utiliza el parametro de TEntidad para determinar la tabla a procesar
    /// </summary>
    /// <typeparam name="TEntidad"> Sirve para identificar el DTO con el que esta trabajando esto con el fin de poderlo reutilizar con todos los DTO </typeparam>
    public class BaseRepositorio<TEntidad> : IBaseRepositorio<TEntidad> where TEntidad : class
    {
        private DbSet<TEntidad> _dbSet;
        public DbSet<TEntidad> DbSetEntidad { 
            get {
                _dbSet ??= contexto.Set<TEntidad>();
                return _dbSet;
            }
        }
        protected readonly BD_Contexto contexto;
        public BaseRepositorio(BD_Contexto _contexto) 
        { 
            contexto = _contexto;
            _dbSet = _contexto.Set<TEntidad>();
        }
        public virtual IQueryable<TEntidad> ObtenerTodo()
        {
            return _dbSet.AsNoTracking(); //AsNoTracking() para no generar bloqueo que en SQL seria "with (nolock) 
        }                                 //para cuando la consulta es extensa o tardaria demasiado tiempo y se bloquee" 

        public TEntidad Crear(TEntidad entidad)
        {
            var _entidad = DbSetEntidad.Add(entidad);
            contexto.SaveChanges();
            return _entidad.Entity;
        }

        public TEntidad Modificar(TEntidad entidad)
        {
            var _entidad = contexto.Entry(entidad);
            // attach = sincronizacion con el existente
            DbSetEntidad.Attach(entidad);
            _entidad.State =  EntityState.Modified;
            contexto.SaveChanges();
            return _entidad.Entity;
        }

        public TEntidad Eliminar(TEntidad entidad)
        {
            var _entidad = contexto.Entry(entidad);
            // attach = sincronizacion con el existente
            DbSetEntidad.Remove(entidad);
            _entidad.State = EntityState.Deleted;
            contexto.SaveChanges();
            return _entidad.Entity;
        }
    }
}
 