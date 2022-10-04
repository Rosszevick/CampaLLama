using UnidadVentas.Modelos;

namespace UnidadVenta.Negocio.Unidades.Unidad.Interfaces
{
    public interface INegHistorial 
    {
        List<MHistorial> Historial();
        public bool Guardar(MHistorial historial);

        public bool Modificar(MHistorial historial);

        public bool Eliminar(MHistorial historial);
    }
}

