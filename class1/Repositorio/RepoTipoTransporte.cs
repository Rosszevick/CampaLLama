using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnidadVentas.CapaDeDatos.Contexto;
using UnidadVentas.CapaDeDatos.Entidades;
using UnidadVentas.CapaDeDatos.Repositorio.Unidad.Interfaces;

namespace UnidadVentas.CapaDeDatos.Repositorio
{
    public class RepoTipoTransporte : BaseRepositorio<DTOTipoTransporte>,IRepoTipoTransporte
    {
        

        public RepoTipoTransporte(BD_Contexto _contexto) : base(_contexto)
        {
        }

        public DTOTipoTransporte AgregarTipoTransporte(DTOTipoTransporte ttransporte)
        {
            return Crear(ttransporte);
        }

        public DTOTipoTransporte BorrarTipoTransporte(DTOTipoTransporte ttransporte)
        {
            return Eliminar(ttransporte);
        }

        public DTOTipoTransporte ModificaTipoTransporte(DTOTipoTransporte ttransporte)
        {
            return Modificar(ttransporte);
        }

        public List<DTOTipoTransporte> ObtenerTipoTransporte()
        {
            return ObtenerTodo().ToList();

        }
    }
}
