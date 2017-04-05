using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MISAP.Entity
{
    public class GastoEntity
      : TesoreriaBaseEntity
    {
        public int docEntry { get; set; }
        public String tipGasto { get; set; }
        public String desGasto { get; set; }
        public String codProv { get; set; }

        public String nomProv { get; set; }
        public String tipDocProv { get; set; }
        public String nroDocProv { get; set; }
        public String tipDoc { get; set; }
        public String serDoc { get; set; }
        public String corDoc { get; set; }
        public Decimal monGasto { get; set; }
        public DateTime fecha { get; set; }
        public String moneda { get; set; }
        public Decimal? tcespecial { get; set; }
        public DateTime? fechaContabilizacion { get; set; }
        public Decimal monImpGasto { get; set; }
        public Decimal monDocGasto { get; set; }
        public String codEmp { get; set; }
        public String nomEmp { get; set; }
        public String numPla { get; set; }
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
        public String nomComentario { get; set; }

        public ImpuestoEntity Impuesto { get; set; }
        public RendicionesEntity Rendiciones { get; set; }
        public CajaChicaEntity CajaChica { get; set; }

        // its - Joseph 
        public String Dimension1 { get; set; }
        public String Dimension2 { get; set; }
        public String Dimension3 { get; set; }
        public String Dimension4 { get; set; }
        public String Dimension5 { get; set; }
        public string codProy { get; set; }
        // its - Joseph Fin
        public String nroOT { get; set; }

        #region Temporales
        public String nomTipGasto { get; set; }
        public String nomTipDoc { get; set; }
        public String nomMoneda { get; set; }
        public String nomTipDocProv { get; set; }
        public String tipDocCuenta { get; set; }
        public String tipDocCuentaDestino { get; set; }
        public String codCuenta { get; set; }
        public String nomCuenta { get; set; }
        public String codCuentaRendicion { get; set; }
        public String nomCuentaRendicion { get; set; }
        public int idUbicacion { get; set; }
        public String valorTipoCambio { get; set; }
        public Nullable<DateTime> fechaRetencion { get; set; }
        public Decimal? retencion { get; set; }
        public Decimal? montoMinimo { get; set; }



        public List<GastoDetalleEntity> GastosDetalle { get; set; }
        public List<GastoEntity> Gastos { get; set; }
        #endregion
    }
}
