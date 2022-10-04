
using UnidadVentas.CapaDeDatos.Contexto;
using UnidadVentas.CapaDeDatos.Entidades;
using UnidadVentas.CapaDeDatos.Repositorio.Unidad.Interfaces;

namespace UnidadVentas.CapaDeDatos.Repositorio
{
    public class RepoCiudad : BaseRepositorio<DTOCiudad>, IRepoCiudad
    {
        public RepoCiudad(BD_Contexto _contexto) : base(_contexto)
        {
        }

        public DTOCiudad AgregarCiudad(DTOCiudad ciudad)
        {
            return Crear(ciudad);
        }

        public DTOCiudad BorrarCiudad(DTOCiudad ciudad)
        {
            return Eliminar(ciudad);
        }

        public DTOCiudad ModificaCiudad(DTOCiudad ciudad)
        {
            return Modificar(ciudad);
        }

        public List<DTOCiudad> ObtenerCiudad()
        {
            return ObtenerTodo().ToList();
        }

     
        
    }
}
