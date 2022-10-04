
using UnidadVentas.Modelos;

namespace UnidadVenta.Negocio.Unidades.Unidad.Interfaces
{
    public interface INegTransporte 
    {
        List<MTransporte> Transporte();
        public bool Guardar(MTransporte transporte);
        public bool Modificar(MTransporte transporte);

        public bool Eliminar(MTransporte transporte);
    }
}
