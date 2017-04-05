using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MISAP.Entity
{
    internal class GastoPopulate
      : BasePopulate
    {
        protected static new GastoPopulate _instance = null;

        internal static new GastoPopulate Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (padlock)
                    {
                        if (_instance == null)
                            _instance = new GastoPopulate();
                    }
                }
                return _instance;
            }
        }

        public GastoEntity GetItem(System.Data.IDataRecord dr)
        {
            GastoEntity item = new GastoEntity()
            {
                nroOT = dr["nroOT"].ToString(),
                codProy = dr["codProy"].ToString(),
                docEntry = (int)dr["docEntry"],
                tipGasto = dr["tipGasto"].ToString(),
                desGasto = dr["desGasto"].ToString(),
                codProv = dr["codProv"].ToString(),
                nomProv = dr["nomProv"].ToString(),
                tipDocProv = dr["tipDocProv"].ToString(),
                nroDocProv = dr["nroDocProv"].ToString(),
                tipDoc = dr["tipDoc"].ToString(),
                serDoc = dr["serDoc"].ToString(),
                corDoc = dr["corDoc"].ToString(),
                monGasto = (decimal)dr["monGasto"],
                fecha = (DateTime)dr["fecha"],
                fechaContabilizacion = (DateTime)dr["fechaContabilizacion"],
                moneda = dr["moneda"].ToString(),
                tcespecial = (decimal)dr["tcespecial"],
                monImpGasto = (decimal)dr["monImpGasto"],
                monDocGasto = (decimal)dr["monDocGasto"],
                codCuenta = dr["codCuenta"].ToString(),
                nomCuenta = dr["nomCuenta"].ToString(),
                codCuentaRendicion = dr["codCuentaRendicion"].ToString(),
                nomCuentaRendicion = dr["nomCuentaRendicion"].ToString(),
                idUbicacion = (int)dr["idUbicacion"],
                valorTipoCambio = dr["valorTipoCambio"].ToString(),
                fechaRetencion = (DateTime)dr["fechaRetencion"],
                retencion = (decimal)dr["retencion"],
                montoMinimo = (decimal)dr["montoMinimo"],
                codCentroCosto1 = dr["codCentroCosto1"].ToString(),
                nomCentroCosto1 = dr["nomCentroCosto1"].ToString(),
                codCentroCosto2 = dr["codCentroCosto2"].ToString(),
                nomCentroCosto2 = dr["nomCentroCosto2"].ToString(),
                codCentroCosto3 = dr["codCentroCosto3"].ToString(),
                nomCentroCosto3 = dr["nomCentroCosto3"].ToString(),
                codCentroCosto4 = dr["codCentroCosto4"].ToString(),
                nomCentroCosto4 = dr["nomCentroCosto4"].ToString(),
                codCentroCosto5 = dr["codCentroCosto5"].ToString(),
                nomCentroCosto5 = dr["nomCentroCosto5"].ToString(),
                nomComentario = dr["nomComentario"].ToString(),
                codEmp = dr["codEmp"].ToString(),
                nomEmp = dr["nomEmp"].ToString(),
                numPla = dr["numPlan"].ToString(),
                Dimension1 = dr["Dimension1"].ToString(),
                Dimension2 = dr["Dimension2"].ToString(),
                Dimension3 = dr["Dimension3"].ToString(),
                Dimension4 = dr["Dimension4"].ToString(),
            };

            item.Impuesto = new ImpuestoEntity()
            {
                codigo = dr["IMPcodigo"].ToString(),
                nombre = dr["IMPnombre"].ToString(),
                cantidad = (decimal)dr["IMPcantidad"]
            };

            item.Rendiciones = new RendicionesEntity()
            {
                docEntry = (int)dr["docEntryRE"]
            };

            item.CajaChica = new CajaChicaEntity()
            {
                docEntry = (int)dr["docEntryCC"]
            };

            // TipGasto
            if (item.tipGasto == "D")
                item.nomTipGasto = "Documento";
            else if (item.tipGasto == "G")
                item.nomTipGasto = "No Sustentado";

            // TipoDocumento
            if (item.tipGasto == "D")
                item.nomTipDoc = dr["nomTipDocTDD"].ToString();
            else if (item.tipGasto == "G")
                item.nomTipDoc = dr["nomTipDocTDG"].ToString();

            // Moneda
            if (item.moneda == "SOL")
                item.nomMoneda = "Nuevos Soles";
            else if (item.moneda == "USD")
                item.nomMoneda = "Dólares Americanos";

            // TipoDocumentProveedor
            if (item.tipDocProv == "6")
                item.nomTipDocProv = "Registro Unico de Contribuyentes";
            else if (item.tipDocProv == "1")
                item.nomTipDocProv = "Documento Nacional de Identidad";

            // TipDocCuenta
            if (item.tipGasto == "G")
            {
                item.tipDocCuenta = dr["tipDocCuentaTDG"].ToString();
                item.tipDocCuentaDestino = dr["tipDocCuentaDestinoTDG"].ToString();
            }

            return item;
        }
    }
}
