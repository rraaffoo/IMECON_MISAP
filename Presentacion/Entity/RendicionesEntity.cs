using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MISAP.Entity
{
    public class RendicionesEntity
       : TesoreriaBaseEntity
    {
        public String nroRen { get; set; }
        public int docEntry { get; set; }
        public String codEmp { get; set; }
        public String nomEmp { get; set; }
        public String nroOT { get; set; }
        public DateTime? fecha { get; set; }
        public String aprob { get; set; }
        public String estado { get; set; }
        public String moneda { get; set; }
        public Decimal monto { get; set; }
        public SolicitudDineroEntity SolicitudDinero { get; set; }

        #region Temporales
        public DateTime? fechaDesde { get; set; }
        public DateTime? fechaHasta { get; set; }
        public String nomEstado { get; set; }
        public String nomContabilizado { get; set; }
        public Boolean isCodUsuSD { get; set; }
        public String nomMoneda { get; set; }
        public Decimal importeTotal { get; set; }
        public Decimal saldo { get; set; }
        #endregion

    }
}
