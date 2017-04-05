using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MISAP.Entity
{
    public class CCostoEntity
    {
        public string codigo { get; set; }
        public string nombre { get; set; }
        public int dimensionId { get; set; }

        public override string ToString()
        {
            return String.Format("{0}, {1}", codigo, nombre);
        }
    }
}
