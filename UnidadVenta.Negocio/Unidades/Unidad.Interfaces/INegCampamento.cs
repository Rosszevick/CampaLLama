using UnidadVentas.Modelos;

namespace UnidadVenta.Negocio.Unidades.Unidad.Interfaces
{
    // UnidadVenta.Negocio.Unidades.Unidad.Interfaces.
    //Modelo y DTO.
    public interface INegCampamento
   {
        List<MCampamento> Campamento();
        public bool Guardar(MCampamento campamento);
        public bool Modificar(MCampamento campamento);
        public bool Eliminar(MCampamento campamento);
    }
}
