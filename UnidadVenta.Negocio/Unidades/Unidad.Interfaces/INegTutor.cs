using UnidadVentas.Modelos;

namespace UnidadVenta.Negocio.Unidades.Unidad.Interfaces
{
    public interface INegTutor 
    {
        public List<MTutor> Tutor();
        public bool Guardar(MTutor tutor);
        public bool Modificar(MTutor tutor);

        public bool Eliminar(MTutor tutor);
    }
}
