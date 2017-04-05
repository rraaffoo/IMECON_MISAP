using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MISAP.Entity
{
    public class ArticuloEntity
      : LogisticaBaseEntity
    {
        public string codigo { get; set; }
        public string nombre { get; set; }
        public string unidadmedida { get; set; }

        public int ItmsGrpCod { get; set; }
        public string GLMethod { get; set; }

        public string detind { get; set; }
        public string detcod { get; set; }
        public decimal detpor { get; set; }
    }
}
