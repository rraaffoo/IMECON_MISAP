using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MISAP.Entity
{
    public class CuentaEntity : ConfiguracionBaseEntity
    {
        public String codigo { get; set; }
        public String nombre { get; set; }
        public String moneda { get; set; }

        //its - Joseph 


        public String Dimension1 { get; set; }
        public String Dimension2 { get; set; }

        public String Dimension3 { get; set; }

        public String Dimension4 { get; set; }

        public String Dimension5 { get; set; }

        #region Temporales
        public String nomMoneda { get; set; }
        #endregion
    }
}
