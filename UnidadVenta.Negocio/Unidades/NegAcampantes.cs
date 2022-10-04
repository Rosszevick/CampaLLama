using UnidadVenta.Negocio.Unidades.Unidad.Interfaces;
using UnidadVentas.CapaDeDatos.Contexto;
using UnidadVentas.Modelos;

namespace UnidadVenta.Negocio.Unidades
{
    /// <summary>
    /// P0002.5 Implementa lo que indica la interfaz y utiliza una variable de UnidadDeTrabajo para acceder a la capa de datos
    /// En esta clase se debe realizar convwerciones entre DTO y Modelo y viceversa
    /// </summary>
    public class NegAcampantes : INegAcampantes
    {
        internal readonly IUnidadDeTrabajo unidad;

        public NegAcampantes(IUnidadDeTrabajo unidad)
        {
            this.unidad = unidad;
        }
        // Negocio recibe DTO de la capa de datos y los transforma en modelos para enviar a la API.
        public List<MAcampantes> Acampantes()
        {
            var list = unidad.RepoAcampante.ObtenerAcampantes();
            return list.Select(x => new MAcampantes
            {
                Id = x.Id,
                FirstName = x.FirstName,
                LastName = x.LastName,
                Age = x.Age,
                Email = x.Email,
                Register = x.Register,
            }).ToList();
        }

        public bool Eliminar(MAcampantes acampante)
        {
            try
            {
                var registro = unidad.RepoAcampante.BorrarAcampantes(new
                    UnidadVentas.CapaDeDatos.Entidades.DTOAcampantes
                {
                    Id = acampante.Id,
                    FirstName = acampante.FirstName,
                    LastName = acampante.LastName,
                    Age = acampante.Age,
                    Email = acampante.Email,
                    Register = acampante.Register,
                });

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            return true;
        }

        public bool Guardar(MAcampantes acampante)
        { // Copiar esto en los demas NEG
            try
            {
                var registro = unidad.RepoAcampante.AgregarAcampantes(new
                    UnidadVentas.CapaDeDatos.Entidades.DTOAcampantes
                { 
                  FirstName = acampante.FirstName,
                  LastName = acampante.LastName,
                  Age = acampante.Age,
                  Email = acampante.Email,
                  Register = acampante.Register,  
                });

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            return true;
        }

        public bool Modificar(MAcampantes acampante)
        {
            try
            {
                var registro = unidad.RepoAcampante.ModificaAcampantes(new
                    UnidadVentas.CapaDeDatos.Entidades.DTOAcampantes
                {
                    Id = acampante.Id,
                    FirstName = acampante.FirstName,
                    LastName = acampante.LastName,
                    Age = acampante.Age,
                    Email = acampante.Email,
                    Register = acampante.Register,
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

