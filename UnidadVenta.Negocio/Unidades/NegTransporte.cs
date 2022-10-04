using UnidadVenta.Negocio.Unidades.Unidad.Interfaces;
using UnidadVentas.CapaDeDatos.Contexto;
using UnidadVentas.CapaDeDatos.Repositorio;
using UnidadVentas.Modelos;

namespace UnidadVenta.Negocio.Unidades
{
    public class NegTransporte : INegTransporte
    {
        internal readonly IUnidadDeTrabajo unidad;

        public NegTransporte(IUnidadDeTrabajo unidad)
        {
            this.unidad = unidad;
        }

        public List<MTransporte> Transporte()
        {
            var list = unidad.RepoTransporte.ObtenerTransporte();
            return list.Select(x => new MTransporte
            {
                Id = x.Id,
                Id_campament = x.Id_campament,                 
                Id_typetransport = x.Id_typetransport,
                License = x.License,
            }).ToList();
        }
        public bool Guardar(MTransporte transporte)
        { // Copiar esto en los demas NEG
            try
            {
                var registro = unidad.RepoTransporte.AgregarTransporte(new
                    UnidadVentas.CapaDeDatos.Entidades.DTOTransporte
                {
                    Id_campament = transporte.Id_campament,
                    Id_typetransport = transporte.Id_typetransport,
                    License = transporte.License,
                });

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            return true;
        }

        public bool Modificar(MTransporte transporte)
        {
            try
            {
                var registro = unidad.RepoTransporte.ModificaTransporte(new
                    UnidadVentas.CapaDeDatos.Entidades.DTOTransporte
                {
                    Id = transporte.Id,
                    Id_campament = transporte.Id_campament,
                    Id_typetransport = transporte.Id_typetransport,
                    License = transporte.License,
                });

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            return true;
        }

        public bool Eliminar(MTransporte transporte)
        {
            try
            {
                var registro = unidad.RepoTransporte.BorrarTransporte(new
                    UnidadVentas.CapaDeDatos.Entidades.DTOTransporte
                {
                    Id = transporte.Id,
                    Id_campament = transporte.Id_campament,
                    Id_typetransport = transporte.Id_typetransport,
                    License = transporte.License,
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
