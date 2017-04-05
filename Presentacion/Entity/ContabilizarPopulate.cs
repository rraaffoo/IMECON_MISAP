using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace MISAP.Entity
{
    internal class ContabilizarPopulate
      : BasePopulate
    {
        protected static new ContabilizarPopulate _instance = null;

        internal static new ContabilizarPopulate Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (padlock)
                    {
                        if (_instance == null)
                            _instance = new ContabilizarPopulate();
                    }
                }
                return _instance;
            }
        }

        public ContabilizarEntity GetItem(IDataRecord dr)
        {
            ContabilizarEntity item = new ContabilizarEntity()
            {
                codigoC = (Boolean)dr["codigoC"],
                nombreC = (Boolean)dr["nombreC"],
                unidadmedidaC = (Boolean)dr["unidadmedidaC"],
                tipodocumentoC = (Boolean)dr["tipodocumentoC"],
                numerodocumentoC = (Boolean)dr["numerodocumentoC"]
            };

            // GastoDetalle
            item.GastoDetalle = new GastoDetalleEntity()
            {
                codArt = dr["codArt"].ToString(),
                desArt = dr["desArt"].ToString(),
                undMed = dr["undMed"].ToString()
            };

            // Gasto
            item.GastoDetalle.Gasto = new GastoEntity()
            {
                tipGasto = dr["tipGasto"].ToString(),
                desGasto = dr["desGasto"].ToString(),
                codProv = dr["codProv"].ToString(),
                nomProv = dr["nomProv"].ToString(),
                tipDocProv = dr["tipDocProv"].ToString(),
                nroDocProv = dr["nroDocProv"].ToString(),
                tipDoc = dr["tipDoc"].ToString(),
                serDoc = dr["serDoc"].ToString(),
                corDoc = dr["corDoc"].ToString()
            };

            // TipGasto
            if (item.GastoDetalle.Gasto.tipGasto == "D") item.GastoDetalle.Gasto.nomTipGasto = "D";
            else if (item.GastoDetalle.Gasto.tipGasto == "G") item.GastoDetalle.Gasto.nomTipGasto = "G";

            // TipoDocumento
            if (item.GastoDetalle.Gasto.tipGasto == "D") item.GastoDetalle.Gasto.nomTipDoc = dr["nomTipDocTDD"].ToString();
            else if (item.GastoDetalle.Gasto.tipGasto == "G") item.GastoDetalle.Gasto.nomTipDoc = dr["nomTipDocTDG"].ToString();

            // TipoDocumentProveedor
            if (item.GastoDetalle.Gasto.tipDocProv == "6") item.GastoDetalle.Gasto.nomTipDocProv = "6";
            else if (item.GastoDetalle.Gasto.tipDocProv == "1") item.GastoDetalle.Gasto.nomTipDocProv = "1";

            // ArticuloSAP
            item.ArticuloSAP = new ArticuloEntity()
            {
                codigo = dr["codigoAR"].ToString(),
                nombre = dr["nombreAR"].ToString(),
                unidadmedida = dr["unidadmedidaAR"].ToString()
            };

            // ProveedorSAP
            item.ProveedorSAP = new ProveedorEntity()
            {
                codigo = dr["codigoPV"].ToString(),
                nombre = dr["nombrePV"].ToString(),
                tipoDocumento = dr["tipoDocumentoPV"].ToString(),
                numeroDocumento = dr["numeroDocumentoPV"].ToString(),
            };

            // TipoDocumento
            if (item.ProveedorSAP.tipoDocumento == "0")
                item.ProveedorSAP.nomTipoDocumento = "Otros Tipos de Documentos";
            else if (item.ProveedorSAP.tipoDocumento == "1")
                item.ProveedorSAP.nomTipoDocumento = "Documento Nacional de Identidad";
            else if (item.ProveedorSAP.tipoDocumento == "4")
                item.ProveedorSAP.nomTipoDocumento = "Carnet de Extranjeria";
            else if (item.ProveedorSAP.tipoDocumento == "6")
                item.ProveedorSAP.nomTipoDocumento = "Registro Unico de Contribuyentes";
            else if (item.ProveedorSAP.tipoDocumento == "7")
                item.ProveedorSAP.nomTipoDocumento = "Pasaporte";

            return item;
        }
    }
}
