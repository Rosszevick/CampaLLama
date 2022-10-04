using UnidadVentas.Modelos;

namespace UnidadVenta.Negocio.Unidades.Unidad.Interfaces
{
    public interface INegCiudad
    {
        List<MCiudad> Ciudad();

        public bool Guardar(MCiudad ciudad);
        public bool Modificar(MCiudad ciudad);

        public bool Eliminar(MCiudad ciudad);
    }
}
