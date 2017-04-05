using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MISAP.Entity
{
    public class CajaChicaEntity : TesoreriaBaseEntity
    {
        public String nroCC { get; set; }
        public int docEntry { get; set; }
        public String nroOT { get; set; }
        public String codProy { get; set; }
        public Decimal totalCaja { get; set; }
        public String moneda { get; set; }
        public DateTime? fechaCierre { get; set; }
        public String aprob { get; set; }
        public String estado { get; set; }
        private String _idCC { get; set; }
        private String _correlativoCC { get; set; }
        public String idCC() { return _idCC; }
        public String correlativoCC() { return _correlativoCC; }
        public void setidCC(String value) { _idCC = value; }
        public void setcorrelativoCC(String value) { _correlativoCC = value; }

        #region Temporales
        public String nomMoneda { get; set; }
        public String nomEstado { get; set; }
        public String nomContabilizado { get; set; }
        public String nomCuenta { get; set; }
        public Decimal monto { get; set; }
        public Decimal importeTotal { get; set; }
        public Decimal saldo { get; set; }
        /// <summary>
        /// <list type="list">
        /// <item>true:Despues De,</item>
        /// <item>false: Antes De.</item>
        /// </list>
        /// </summary>
        private Boolean _tiempoFecha { get; set; }
        public Boolean tiempoFecha() { return _tiempoFecha; }
        public void setTiempoFecha(Boolean value) { _tiempoFecha = value; }
        #endregion
    }
}
