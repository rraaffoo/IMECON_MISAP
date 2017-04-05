using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MISAP.Entity
{
    public class UbicacionEntity
      : ConfiguracionBaseEntity
    {
        public int idUbicacion { get; set; }
        public String nomUbicacion { get; set; }

        #region Temporales
        public String codAlm { get; set; }
        #endregion
    }
}
