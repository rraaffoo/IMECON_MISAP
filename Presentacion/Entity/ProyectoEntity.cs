using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MISAP.Entity
{
    public class ProyectoEntity : ConfiguracionBaseEntity
    {
        public String codProy { get; set; }
        public String nomProy { get; set; }
        public String nroOT { get; set; }
        public String estado { get; set; }
        public String codAlm { get; set; }
        public String nomAlm { get; set; }
        public int? idUbicacion { get; set; }
        public String nomUbicacion { get; set; }
        public Decimal totalCaja { get; set; }
        public String moneda { get; set; }
        public CuentaEntity Cuenta { get; set; }
        public CuentaEntity CuentaRendicion { get; set; }
        public RolEntity Rol { get; set; }

        #region Temporales
        public String nomMoneda { get; set; }
        public String nomEstado { get; set; }

        public string pidCC { get; set; }
        public string pcorrelativoCC { get; set; }
        #endregion

        // its - Joseph 
        public String codCentroCosto1 { get; set; }
        public String nomCentroCosto1 { get; set; }
        public String codCentroCosto2 { get; set; }
        public String nomCentroCosto2 { get; set; }
        public String codCentroCosto3 { get; set; }
        public String nomCentroCosto3 { get; set; }
        public String codCentroCosto4 { get; set; }
        public String nomCentroCosto4 { get; set; }
        public String codCentroCosto5 { get; set; }
        public String nomCentroCosto5 { get; set; }
        //its - Joseph Fin
    }
}
