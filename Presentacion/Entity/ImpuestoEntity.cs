using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MISAP.Entity
{
    public class ImpuestoEntity : TesoreriaBaseEntity
    {
        /// <summary>
        /// Obtiene o establece el código del impuesto.
        /// </summary>
        public String codigo { get; set; }
        /// <summary>
        /// Obtiene o establece el nombre del impuesto.
        /// </summary>
        public String nombre { get; set; }
        /// <summary>
        /// Obtiene o establece el importe del impuesto.
        /// </summary>
        public Decimal cantidad { get; set; }
    }
}
