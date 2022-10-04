using UnidadVenta.Negocio.Unidades.Unidad.Interfaces;
using UnidadVentas.CapaDeDatos.Contexto;
using UnidadVentas.Modelos;

namespace UnidadVenta.Negocio.Unidades
{
    public class NegTutor: INegTutor
    {
        internal readonly IUnidadDeTrabajo unidad;

        public NegTutor(IUnidadDeTrabajo unidad)
        {
            this.unidad = unidad;
        }

        public List<MTutor> Tutor()
        {
            var list = unidad.RepoTutor.ObtenerTutor();
            return list.Select(x => new MTutor
            {
                Id = x.Id,
                FirstName = x.FirstName,
                LastName = x.LastName,
                Age = x.Age,
                Relationship = x.Relationship,
            }).ToList();
        }
        public bool Guardar(MTutor tutor)
        { // Copiar esto en los demas NEG
            try
            {
                var registro = unidad.RepoTutor.AgregarTutor(new
                    UnidadVentas.CapaDeDatos.Entidades.DTOTutor
                {
                    FirstName = tutor.FirstName,
                    LastName = tutor.LastName,
                    Age = tutor.Age,
                    Relationship = tutor.Relationship,
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            return true;
        }
        public bool Modificar(MTutor tutor)
        {
            try
            {
                var registro = unidad.RepoTutor.ModificaTutor(new
                    UnidadVentas.CapaDeDatos.Entidades.DTOTutor
                {
                    Id = tutor.Id,
                    FirstName = tutor.FirstName,
                    LastName = tutor.LastName,
                    Age = tutor.Age,
                    Relationship = tutor.Relationship,
                });

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            return true;
        }

        public bool Eliminar(MTutor tutor)
        {
            try
            {
                var registro = unidad.RepoTutor.BorrarTutor(new
                    UnidadVentas.CapaDeDatos.Entidades.DTOTutor
                {
                    Id = tutor.Id,
                    FirstName = tutor.FirstName,
                    LastName = tutor.LastName,
                    Age = tutor.Age,
                    Relationship = tutor.Relationship,
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
