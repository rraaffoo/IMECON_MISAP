using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MISAP.Entity
{
    public class PaginadorEntity
    {
        public int RegistroInicio { get; set; }

        public int RegistroPagina { get; set; }

        public int PaginaActual { get; set; }

        public string ColumnaOrdenada { get; set; }

        public string TipoOrden { get; set; }

        public int TotalPagina { get; set; }

        public int TotalRegistro { get; set; }
    }
}
