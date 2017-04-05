using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MISAP.Entity
{
    public class SolicitudDineroEntity
      : TesoreriaBaseEntity
    {
        public int docEntry { get; set; }
        public string codigo { get; set; }
        public DateTime? fecha { get; set; }
        public decimal monto { get; set; }
        public string moneda { get; set; }
        public string motivo { get; set; }
        public string motAdicional { get; set; }
        public DateTime fecharegistro { get; set; }
        public string estado { get; set; }
        public RendicionesEntity Rendicion { get; set; }
        public string codEmp { get; set; }
        public string nomEmp { get; set; }

        #region Temporales
        public String nomEstado { get; set; }
        public String nomMoneda { get; set; }
        #endregion

        public override string ToString()
        {
            return String.Format("{0}, {2} {1:#,0.00}, {3}", codigo, monto, moneda, estado);
        }
    }
}
