using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using UnidadVentas.CapaDeDatos.Contexto;
using UnidadVentas.CapaDeDatos.Entidades;
using UnidadVentas.Modelos;

namespace UnidadVenta.Negocio.Unidades.Unidad.Interfaces
{
    public interface INegTipoTransporte 
    {
        List<MTipoTransporte> TipoTransporte();

        public bool Guardar(MTipoTransporte tipotransporte);
        public bool Modificar(MTipoTransporte tipotransporte);

        public bool Eliminar(MTipoTransporte tipotransporte);
    }
}
