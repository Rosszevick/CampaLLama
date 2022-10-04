using UnidadVenta.Negocio.Unidades.Unidad.Interfaces;
using UnidadVentas.CapaDeDatos.Contexto;
using UnidadVentas.Modelos;

namespace UnidadVenta.Negocio.Unidades
{
    public class NegCampamento : INegCampamento
    {
        internal readonly IUnidadDeTrabajo unidad;

        public NegCampamento(IUnidadDeTrabajo unidad)
        {
            this.unidad = unidad;
        }

        public List<MCampamento> Campamento()
        {
            var list = unidad.RepoCampamento.ObtenerCampamento();
            return list.Select(x => new MCampamento
            {
                Id = x.Id,
                Id_city = x.Id_city,
                CampName = x.CampName,
                Address = x.Address,
                Rate = x.Rate,

            }).ToList();
        }

        public bool Guardar(MCampamento campamento)
        {
            try
            {
                var registro = unidad.RepoCampamento.AgregarCampamento(new
                    UnidadVentas.CapaDeDatos.Entidades.DTOCampamento
                {
                    Id_city = campamento.Id_city,
                    CampName = campamento.CampName,
                    Address = campamento.Address,
                    Rate = campamento.Rate,
                });

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            return true;
        }

        public bool Modificar(MCampamento campamento)
        {
            try
            {
                var registro = unidad.RepoCampamento.ModificaCampamento(new
                    UnidadVentas.CapaDeDatos.Entidades.DTOCampamento
                {
                    Id = campamento.Id,
                    Id_city = campamento.Id_city,
                    CampName = campamento.CampName,
                    Address = campamento.Address,
                    Rate = campamento.Rate,
                });

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            return true;
        }

        public bool Eliminar(MCampamento campamento)
        {
            try
            {
                var registro = unidad.RepoCampamento.BorrarCampamento(new
                    UnidadVentas.CapaDeDatos.Entidades.DTOCampamento
                {
                    Id = campamento.Id,
                    Id_city = campamento.Id_city,
                    CampName = campamento.CampName,
                    Address = campamento.Address,
                    Rate = campamento.Rate,
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
