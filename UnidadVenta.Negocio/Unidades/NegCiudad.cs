using UnidadVenta.Negocio.Unidades.Unidad.Interfaces;
using UnidadVentas.CapaDeDatos.Contexto;
using UnidadVentas.Modelos;

namespace UnidadVenta.Negocio.Unidades
{
    public class NegCiudad : INegCiudad
    {
        internal readonly IUnidadDeTrabajo unidad;

        public NegCiudad(IUnidadDeTrabajo unidad)
        {
            this.unidad = unidad;
        }

        public List<MCiudad> Ciudad()
        {
            var list = unidad.RepoCiudad.ObtenerCiudad();
            return list.Select(x => new MCiudad
            {
                Id = x.Id,
                CityName = x.CityName,
            }).ToList();
        }
        public bool Guardar(MCiudad ciudad)
        { // Copiar esto en los demas NEG
            try
            {
                var registro = unidad.RepoCiudad.AgregarCiudad(new
                    UnidadVentas.CapaDeDatos.Entidades.DTOCiudad
                {
                    CityName = ciudad.CityName,

                });

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            return true;
        }

        public bool Modificar(MCiudad ciudad)
        {
            try
            {
                var registro = unidad.RepoCiudad.ModificaCiudad(new
                    UnidadVentas.CapaDeDatos.Entidades.DTOCiudad
                {
                    Id = ciudad.Id,
                    CityName = ciudad.CityName,

                });

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            return true;
        }

        public bool Eliminar(MCiudad ciudad)
        {
            try
            {
                var registro = unidad.RepoCiudad.BorrarCiudad(new
                    UnidadVentas.CapaDeDatos.Entidades.DTOCiudad
                {
                    Id = ciudad.Id,
                    CityName = ciudad.CityName,

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
