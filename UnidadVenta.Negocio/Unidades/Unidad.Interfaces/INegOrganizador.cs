using UnidadVentas.Modelos;

namespace UnidadVenta.Negocio.Unidades.Unidad.Interfaces
{
    public interface INegOrganizador 
    {
        List<MOrganizador> Organizador();
        public bool Guardar(MOrganizador organizador);
        public bool Modificar(MOrganizador organizador);
        public bool Eliminar(MOrganizador organizador);
    }
}
