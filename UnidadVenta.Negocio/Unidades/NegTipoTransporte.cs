using UnidadVenta.Negocio.Unidades.Unidad.Interfaces;
using UnidadVentas.CapaDeDatos.Contexto;
using UnidadVentas.Modelos;

namespace UnidadVenta.Negocio.Unidades
{
    public class NegTipoTransporte : INegTipoTransporte
    {
        internal readonly IUnidadDeTrabajo unidad;

        public NegTipoTransporte(IUnidadDeTrabajo unidad)
        {
            this.unidad = unidad;
        }

        public List<MTipoTransporte> TipoTransporte()
        {
            var list = unidad.RepoTipoTransporte.ObtenerTipoTransporte();
            return list.Select(x => new MTipoTransporte
            {
                Id = x.Id,
                Ttype = x.Ttype,

            }).ToList();
        }
        public bool Guardar(MTipoTransporte tipotransporte)
        { // Copiar esto en los demas NEG
            try
            {
                var registro = unidad.RepoTipoTransporte.AgregarTipoTransporte(new
                    UnidadVentas.CapaDeDatos.Entidades.DTOTipoTransporte
                {
                    Ttype = tipotransporte.Ttype,
                });

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            return true;
        }

        public bool Modificar(MTipoTransporte tipotransporte)
        {
            try
            {
                var registro = unidad.RepoTipoTransporte.ModificaTipoTransporte(new
                    UnidadVentas.CapaDeDatos.Entidades.DTOTipoTransporte
                {
                    Id = tipotransporte.Id,
                    Ttype = tipotransporte.Ttype,
                });

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            return true;
        }

        public bool Eliminar(MTipoTransporte tipotransporte)
        {
            try
            {
                var registro = unidad.RepoTipoTransporte.BorrarTipoTransporte(new
                    UnidadVentas.CapaDeDatos.Entidades.DTOTipoTransporte
                {
                    Id = tipotransporte.Id,
                    Ttype = tipotransporte.Ttype,
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