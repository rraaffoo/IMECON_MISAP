using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MISAP.Entity
{
    public class ContabilizarEntity
      : TesoreriaBaseEntity
    {
        public GastoDetalleEntity GastoDetalle { get; set; }
        public ArticuloEntity ArticuloSAP { get; set; }
        public ProveedorEntity ProveedorSAP { get; set; }

        #region Temporales
        public Boolean codigoC { get; set; }
        public Boolean nombreC { get; set; }
        public Boolean unidadmedidaC { get; set; }

        public Boolean tipodocumentoC { get; set; }
        public Boolean numerodocumentoC { get; set; }
        #endregion
    }
}
