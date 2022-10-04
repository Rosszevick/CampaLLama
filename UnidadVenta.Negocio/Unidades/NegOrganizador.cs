using UnidadVenta.Negocio.Unidades.Unidad.Interfaces;
using UnidadVentas.CapaDeDatos.Contexto;
using UnidadVentas.Modelos;

namespace UnidadVenta.Negocio.Unidades
{
    public class NegOrganizador : INegOrganizador
    {
        internal readonly IUnidadDeTrabajo unidad;

        public NegOrganizador(IUnidadDeTrabajo unidad)
        {
            this.unidad = unidad;
        }

        public List<MOrganizador> Organizador()
        {
            var list = unidad.RepoOrganizador.ObtenerOrganizador();
            return list.Select(x => new MOrganizador
            {
                Id = x.Id,
                FirstName = x.FirstName,
                LastName = x.LastName,
                Age = x.Age,
            }).ToList();
        }

        public bool Guardar(MOrganizador organizador)
        { // Copiar esto en los demas NEG
            try
            {
                var registro = unidad.RepoOrganizador.AgregarOrganizador(new
                    UnidadVentas.CapaDeDatos.Entidades.DTOOrganizador
                {
                    FirstName = organizador.FirstName,
                    LastName = organizador.LastName,
                    Age = organizador.Age,
                });

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            return true;
        }

        public bool Modificar(MOrganizador organizador)
        {
            try
            {
                var registro = unidad.RepoOrganizador.ModificaOrganizador(new
                    UnidadVentas.CapaDeDatos.Entidades.DTOOrganizador
                {
                    Id = organizador.Id,
                    FirstName = organizador.FirstName,
                    LastName = organizador.LastName,
                    Age = organizador.Age,
                });

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            return true;
        }

        public bool Eliminar(MOrganizador organizador)
        {
            try
            {
                var registro = unidad.RepoOrganizador.BorrarOrganizador(new
                    UnidadVentas.CapaDeDatos.Entidades.DTOOrganizador
                {
                    Id = organizador.Id,
                    FirstName = organizador.FirstName,
                    LastName = organizador.LastName,
                    Age = organizador.Age,
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
