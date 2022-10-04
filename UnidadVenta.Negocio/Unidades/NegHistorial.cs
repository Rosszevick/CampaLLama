using UnidadVenta.Negocio.Unidades.Unidad.Interfaces;
using UnidadVentas.CapaDeDatos.Contexto;
using UnidadVentas.Modelos;

namespace UnidadVenta.Negocio.Unidades
{
    public class NegHistorial : INegHistorial
    {
        internal readonly IUnidadDeTrabajo unidad;

        public NegHistorial(IUnidadDeTrabajo unidad)
        {
            this.unidad = unidad;
        }

        public List<MHistorial> Historial()
        {
            var list = unidad.RepoHistorial.ObtenerHistorial();
            return list.Select(x => new MHistorial
            {
                Id = x.Id,
                Id_event = x.Id_event,
                Id_organizer = x.Id_organizer,
                Id_tutor = x.Id_tutor,
                Id_campers = x.Id_campers,
            }).ToList();
        }

        public bool Guardar(MHistorial historial)
        { // Copiar esto en los demas NEG
            try
            {
                var registro = unidad.RepoHistorial.AgregarHistorial(new
                    UnidadVentas.CapaDeDatos.Entidades.DTOHistorial
                {
                    Id_event = historial.Id_event,
                    Id_organizer = historial.Id_organizer,
                    Id_tutor = historial.Id_tutor,
                    Id_campers = historial.Id_campers,
                });

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            return true;
        }

        public bool Modificar(MHistorial historial)
        {
            try
            {
                var registro = unidad.RepoHistorial.ModificaHistorial(new
                    UnidadVentas.CapaDeDatos.Entidades.DTOHistorial
                {
                    Id = historial.Id,
                    Id_event = historial.Id_event,
                    Id_organizer = historial.Id_organizer,
                    Id_tutor = historial.Id_tutor,
                    Id_campers = historial.Id_campers,
                });

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            return true;
        }

        public bool Eliminar(MHistorial historial)
        {
            try
            {
                var registro = unidad.RepoHistorial.BorrarHistorial(new
                    UnidadVentas.CapaDeDatos.Entidades.DTOHistorial
                {
                    Id = historial.Id,
                    Id_event = historial.Id_event,
                    Id_organizer = historial.Id_organizer,
                    Id_tutor = historial.Id_tutor,
                    Id_campers = historial.Id_campers,
                });

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            return true;
        }


    }
}
