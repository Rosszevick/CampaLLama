using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnidadVentas.CapaDeDatos.Contexto;
using UnidadVentas.CapaDeDatos.Entidades;

namespace UnidadVentas.CapaDeDatos.Repositorio.Unidad.Interfaces
{
    public interface IRepoEvento: IBaseRepositorio<DTOEvento>
    {
        public List<DTOEvento> ObtenerEvento();

        public DTOEvento AgregarEvento(DTOEvento evento);
        public DTOEvento ModificaEvento(DTOEvento evento);
        public DTOEvento BorrarEvento(DTOEvento evento);

    }
}
