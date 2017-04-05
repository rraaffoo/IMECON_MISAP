using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MISAP.Entity
{
    public class AlmacenEntity
      : LogisticaBaseEntity
    {
        public String codAlm { get; set; }
        public String nomAlm { get; set; }
        public string TieneUbi { get; set; }
    }
}
