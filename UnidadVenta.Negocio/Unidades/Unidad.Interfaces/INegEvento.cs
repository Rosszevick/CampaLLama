using UnidadVentas.Modelos;

namespace UnidadVenta.Negocio.Unidades.Unidad.Interfaces
{
    public interface INegEvento
    {
        List<MEvento> Evento();
        public bool Guardar(MEvento evento);
        public bool Modificar(MEvento evento);

        public bool Eliminar(MEvento evento);
    }
}
