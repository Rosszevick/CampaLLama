using Microsoft.Extensions.DependencyInjection;
using UnidadVenta.Negocio.Unidades;
using UnidadVenta.Negocio.Unidades.Unidad.Interfaces;
using UnidadVentas.CapaDeDatos.Contexto;

namespace UnidadVenta.servicio
{
    /// <summary>
    /// P0003 Aqui se inyectan las interfaces y sus respectivas clases que se pueden inicializar en todas las soluciones
    /// </summary>
    public class Puerta
    {
        protected readonly IServiceCollection IService;

        public Puerta(IServiceCollection _iService)
        {   //Aqui es la inyeccion de dependencia, se implementa en el program de la API.
            IService = _iService;
        }
        public void Ejecutar()
        //Todo lo que se quiera agregar a la inyeccion de dependencia.
        {
            IService.AddScoped<BD_Contexto>();
            IService.AddScoped<IUnidadDeTrabajo, UnidadDeTrabajo>();
            IService.AddScoped<INegAcampantes, NegAcampantes>();
            IService.AddScoped<INegCampamento, NegCampamento>();
            IService.AddScoped<INegCiudad, NegCiudad>();
            IService.AddScoped<INegEvento, NegEvento>();
            IService.AddScoped<INegHistorial, NegHistorial>();
            IService.AddScoped<INegTipoTransporte, NegTipoTransporte>();
            IService.AddScoped<INegTransporte, NegTransporte>();
            IService.AddScoped<INegTutor, NegTutor>();
            IService.AddScoped<INegOrganizador, NegOrganizador>();
        }
    }
}
