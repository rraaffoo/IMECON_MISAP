using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MISAP.Entity
{
    public class CentroCostoEntity
      : TesoreriaBaseEntity
    {
        public String codigo { get; set; }
        public String nombre { get; set; }
        public int nivel { get; set; }

        public string ccLinea { get; set; }
    }

    public class ProrrateoEntity
    {
        public string codigo { get; set; }
        public string nombre { get; set; }
        public int nivel { get; set; }
        public decimal valor { get; set; }
    }
}
