using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MISAP.Entity
{
    public class TipoDocumentoEntity
      : TesoreriaBaseEntity
    {
        public String codigo { get; set; }
        public String nombre { get; set; }
    }
}
