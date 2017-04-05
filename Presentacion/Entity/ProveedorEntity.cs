using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MISAP.Entity
{
    public class ProveedorEntity : TesoreriaBaseEntity
    {
        public String codigo { get; set; }
        public String nombre { get; set; }
        public String tipoDocumento { get; set; }
        public String numeroDocumento { get; set; }
        public ImpuestoEntity Impuesto { get; set; }

        #region Temporales
        public String nomTipoDocumento { get; set; }
        #endregion
    }
}
