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
    public class RepoTutor : BaseRepositorio<DTOTutor>, IRepoTutor
        
    {
        public RepoTutor(BD_Contexto _contexto) : base(_contexto)
        {
        }

        public DTOTutor AgregarTutor(DTOTutor tutor)
        {
            return Crear(tutor);
        }

        public DTOTutor BorrarTutor(DTOTutor tutor)
        {
            return Eliminar(tutor);
        }

        public DTOTutor ModificaTutor(DTOTutor tutor)
        {
            return Modificar(tutor);
        }

        public List<DTOTutor> ObtenerTutor()
        {
            return ObtenerTodo().ToList();

        }
    }
}
        /**/