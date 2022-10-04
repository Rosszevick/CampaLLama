using Microsoft.Extensions.Logging;
using UnidadVenta.Negocio.Unidades.Unidad.Interfaces;
using UnidadVentas.CapaDeDatos.Contexto;
using UnidadVentas.Modelos;

namespace UnidadVenta.Negocio.Unidades
{
    public class NegEvento : INegEvento
    {
        internal readonly IUnidadDeTrabajo unidad;

        public NegEvento(IUnidadDeTrabajo unidad)
        {
            this.unidad = unidad;
        }

        public List<MEvento> Evento()
        { 
            var list = unidad.RepoEvento.ObtenerEvento();
            return list.Select(x => new MEvento
            {
                Id = x.Id,
                Id_campament = x.Id_campament,
                Id_organizer = x.Id_organizer,
                EventName = x.EventName,
                EventDate = x.EventDate,
                DurationDays = x.DurationDays,
            }).ToList();
        }
        public bool Eliminar(MEvento evento)
        {
            try
            {
                var registro = unidad.RepoEvento.BorrarEvento(new
                    UnidadVentas.CapaDeDatos.Entidades.DTOEvento
                {
                    Id = evento.Id,
                    Id_campament = evento.Id_campament,
                    Id_organizer = evento.Id_organizer,
                    EventName = evento.EventName,
                    EventDate = evento.EventDate,
                    DurationDays = evento.DurationDays,
                });

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            return true;
        }

        public bool Guardar(MEvento evento)
        { // Copiar esto en los demas NEG
            try
            {
                var registro = unidad.RepoEvento.AgregarEvento(new
                    UnidadVentas.CapaDeDatos.Entidades.DTOEvento
                {
                    Id_campament = evento.Id_campament,
                    Id_organizer = evento.Id_organizer,
                    EventName = evento.EventName,
                    EventDate = evento.EventDate,
                    DurationDays = evento.DurationDays,
                });

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            return true;
        }

        public bool Modificar(MEvento evento)
        {
            try
            {
                var registro = unidad.RepoEvento.ModificaEvento(new
                    UnidadVentas.CapaDeDatos.Entidades.DTOEvento
                {
                    Id = evento.Id,
                    Id_campament = evento.Id_campament,
                    Id_organizer = evento.Id_organizer,
                    EventName = evento.EventName,
                    EventDate = evento.EventDate,
                    DurationDays = evento.DurationDays,
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
