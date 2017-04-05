using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MISAP.Entity;
using System.Data.Common;
using System.Data;
using System.Data.SqlClient;

namespace MISAP.Repository
{
    internal class GastoRepository
      : TesoreriaBaseRepository<GastoEntity>
    {
        public VSSQLFactory dbxSap;

        public GastoRepository()
        {
            dbxSap = new VSSQLFactory();
        }

        #region Gasto
        protected override void ConfigurarParametros(DbCommand comando, GastoEntity item)
        {
            comando.Parameters["@pdocEntry"].Value = item.docEntry;
            comando.Parameters["@ptipGasto"].Value = item.tipGasto;
            comando.Parameters["@pdesGasto"].Value = item.desGasto;
            comando.Parameters["@pcodProv"].Value = item.codProv;
            comando.Parameters["@pnomProv"].Value = item.nomProv;
            comando.Parameters["@ptipDocProv"].Value = item.tipDocProv;
            comando.Parameters["@pnroDocProv"].Value = item.nroDocProv;
            comando.Parameters["@ptipDoc"].Value = item.tipDoc;
            comando.Parameters["@pserDoc"].Value = item.serDoc;
            comando.Parameters["@pcorDoc"].Value = item.corDoc;
            comando.Parameters["@pmonGasto"].Value = item.monGasto;
            comando.Parameters["@pfecha"].Value = item.fecha;
            comando.Parameters["@pmoneda"].Value = item.moneda;
            comando.Parameters["@ptcespecial"].Value = item.tcespecial;
            comando.Parameters["@pmonImpGasto"].Value = item.monImpGasto;
            comando.Parameters["@pmonDocGasto"].Value = item.monDocGasto;
            comando.Parameters["@pnroRen"].Value = (item.Rendiciones != null) ? item.Rendiciones.nroRen : String.Empty;
            comando.Parameters["@pnroCC"].Value = (item.CajaChica != null) ? item.CajaChica.nroCC : String.Empty;
            comando.Parameters["@pcodImp"].Value = (item.Impuesto != null) ? item.Impuesto.codigo : String.Empty;
            comando.Parameters["@pnomImp"].Value = (item.Impuesto != null) ? item.Impuesto.nombre : String.Empty;
            comando.Parameters["@pcantImp"].Value = (item.Impuesto != null) ? item.Impuesto.cantidad : 0;

            comando.Parameters["@pnomComentario"].Value = item.nomComentario;
            comando.Parameters["@pcodCentroCosto1"].Value = item.codCentroCosto1;
            comando.Parameters["@pnomCentroCosto1"].Value = item.nomCentroCosto1;
            comando.Parameters["@pcodCentroCosto2"].Value = item.codCentroCosto2;
            comando.Parameters["@pnomCentroCosto2"].Value = item.nomCentroCosto2;
            comando.Parameters["@pcodCentroCosto3"].Value = item.codCentroCosto3;
            comando.Parameters["@pnomCentroCosto3"].Value = item.nomCentroCosto3;
            comando.Parameters["@pcodCentroCosto4"].Value = item.codCentroCosto4;
            comando.Parameters["@pnomCentroCosto4"].Value = item.nomCentroCosto4;
            comando.Parameters["@pcodCentroCosto5"].Value = item.codCentroCosto5;
            comando.Parameters["@pnomCentroCosto5"].Value = item.nomCentroCosto5;
            comando.Parameters["@pcodEmp"].Value = item.codEmp;
            comando.Parameters["@pnomEmp"].Value = item.nomEmp;
            comando.Parameters["@pnumPla"].Value = item.numPla;
            comando.Parameters["@pcodProy"].Value = item.codProy;
            comando.Parameters["@pnroOT"].Value = item.nroOT;
        }

        //internal override int Registrar(GastoEntity item, out int filasAfectadas)
        //{
        //    nombreParametroRetorno = "@pdocEntry";
        //    return base.Registrar(TablasEnum.GastoCabecera.GetDescription() + "_RegMod", item, out filasAfectadas);
        //}

        //internal override int Modificar(GastoEntity item, out int filasAfectadas)
        //{
        //    nombreParametroRetorno = "@pdocEntry";
        //    return base.Modificar(TablasEnum.GastoCabecera.GetDescription() + "_RegMod", item, out filasAfectadas);
        //}

        internal GastoEntity DetallePorRendicion(int docEntry)
        {
            return base.Detalle<GastoPopulate>("VS_OOGC_DetallePorRendicion", docEntry, "@pdocEntry");
        }

        internal GastoEntity DetallePorCajaChica(int docEntry)
        {
            return base.Detalle<GastoPopulate>("VS_OOGC_DetallePorCajaChica", docEntry, "@pdocEntry");
        }

        //// its - Joseph 
        internal GastoEntity CentroCostoPorCajaChica(string codProy)
        {
            return base.Detalle<GastoPopulate>("VS_OOGC_CentroCostoPorCajaChica", codProy, "@pcodProy");
        }

        internal GastoEntity CentroCostoPorRendicion(string codProy)
        {
            return base.Detalle<GastoPopulate>("VS_OOGC_CentroCostoPorRendicion", codProy, "@pcodProy");
        }

        // its - Joseph Fin
        internal List<GastoEntity> BuscarGastosPorRendicion(int docEntry)
        {
            dbxSap.Link();
            DataTable tipoDoc = new DataTable("tipoDoc");
            tipoDoc.Columns.Add("codigo", typeof(string));
            tipoDoc.Columns.Add("nombre", typeof(string));

            DataTable tipoGasto = new DataTable("tipoGasto");
            tipoGasto.Columns.Add("codigo", typeof(string));
            tipoGasto.Columns.Add("nombre", typeof(string));
            tipoGasto.Columns.Add("cuenta", typeof(string));
            tipoGasto.Columns.Add("cuentadestino", typeof(string));

            DataTable retProv = new DataTable("retProv");
            retProv.Columns.Add("codProv", typeof(string));
            retProv.Columns.Add("fecha", typeof(DateTime));
            retProv.Columns.Add("retencion", typeof(decimal));
            retProv.Columns.Add("retencionActual", typeof(decimal));
            retProv.Columns.Add("montoMinimo", typeof(decimal));

            List<object[]> info = dbxSap.GetBlock("15", new string[] { });
            foreach (var fila in info) { tipoDoc.Rows.Add(fila); }

            info = dbxSap.GetBlock("16", new string[] { });
            foreach (var fila in info) { tipoGasto.Rows.Add(fila); }

            info = dbxSap.GetBlock("13", new string[] { });
            foreach (var fila in info) { retProv.Rows.Add(fila); }

            dbxSap.Dispose();
            //return base.Buscar<GastoPopulate>(TablasEnum.GastoCabecera.GetDescription() + "_BuscarGastosPorRendicion", docEntry, "@pdocEntry");
            return base.Buscar<GastoPopulate>(
               "VS_OOGC_BuscarGastosPorRendicion",
               delegate(DbCommand comando)
               {
                   comando.Parameters["@pdocEntry"].Value = docEntry;

                   comando.Parameters["@docSAP"].Value = tipoDoc;
                   ((SqlCommand)comando).Parameters["@docSAP"].SqlDbType = SqlDbType.Structured;
                   ((SqlCommand)comando).Parameters["@docSAP"].TypeName = "dbo.tipoDocSAP";

                   comando.Parameters["@gastoSAP"].Value = tipoGasto;
                   ((SqlCommand)comando).Parameters["@gastoSAP"].SqlDbType = SqlDbType.Structured;
                   ((SqlCommand)comando).Parameters["@gastoSAP"].TypeName = "dbo.tipoGastoSAP";

                   comando.Parameters["@retpvSAP"].Value = retProv;
                   ((SqlCommand)comando).Parameters["@retpvSAP"].SqlDbType = SqlDbType.Structured;
                   ((SqlCommand)comando).Parameters["@retpvSAP"].TypeName = "dbo.retProvSAP";
               }
            );
        }

        internal List<GastoEntity> BuscarGastosPorCajaChica(int docEntry)
        {
            dbxSap.Link();
            DataTable tipoDoc = new DataTable("tipoDoc");
            tipoDoc.Columns.Add("codigo", typeof(string));
            tipoDoc.Columns.Add("nombre", typeof(string));

            DataTable tipoGasto = new DataTable("tipoGasto");
            tipoGasto.Columns.Add("codigo", typeof(string));
            tipoGasto.Columns.Add("nombre", typeof(string));
            tipoGasto.Columns.Add("cuenta", typeof(string));
            tipoGasto.Columns.Add("cuentadestino", typeof(string));

            DataTable retProv = new DataTable("retProv");
            retProv.Columns.Add("codProv", typeof(string));
            retProv.Columns.Add("fecha", typeof(DateTime));
            retProv.Columns.Add("retencion", typeof(decimal));
            retProv.Columns.Add("retencionActual", typeof(decimal));
            retProv.Columns.Add("montoMinimo", typeof(decimal));

            List<object[]> info = dbxSap.GetBlock("15", new string[] { });
            foreach (var fila in info) { tipoDoc.Rows.Add(fila); }

            info = dbxSap.GetBlock("16", new string[] { });
            foreach (var fila in info) { tipoGasto.Rows.Add(fila); }

            info = dbxSap.GetBlock("13", new string[] { });
            foreach (var fila in info) { retProv.Rows.Add(fila); }

            dbxSap.Dispose();
            //return base.Buscar<GastoPopulate>(
            //   TablasEnum.GastoCabecera.GetDescription() + "_BuscarGastosPorCajaChica",
            //   delegate(DbCommand comando)
            //   {
            //       comando.Parameters["@pdocEntry"].Value = docEntry;

            //       comando.Parameters["@docSAP"].Value = tipoDoc;
            //       ((SqlCommand)comando).Parameters["@docSAP"].SqlDbType = SqlDbType.Structured;
            //       ((SqlCommand)comando).Parameters["@docSAP"].TypeName = "dbo.tipoDocSAP";

            //       comando.Parameters["@gastoSAP"].Value = tipoGasto;
            //       ((SqlCommand)comando).Parameters["@gastoSAP"].SqlDbType = SqlDbType.Structured;
            //       ((SqlCommand)comando).Parameters["@gastoSAP"].TypeName = "dbo.tipoGastoSAP";

            //       comando.Parameters["@retpvSAP"].Value = retProv;
            //       ((SqlCommand)comando).Parameters["@retpvSAP"].SqlDbType = SqlDbType.Structured;
            //       ((SqlCommand)comando).Parameters["@retpvSAP"].TypeName = "dbo.retProvSAP";
            //   }
            //);
            return null;
        }

        //internal override int Eliminar(int docEntry, out int filasAfectadas)
        //{
        //    base.nombreParametroRetorno = "@pdocEntry";
        //    return base.Eliminar(TablasEnum.GastoCabecera.GetDescription() + "_Eliminar", docEntry, out filasAfectadas);
        //}

        internal int ActualizarFechaContabilizacionPorRendicion(int docEntry, GastoEntity item, out int filasAfectadas)
        {
            return base.Modificar("VS_OOGC_ActualizarFechaContabilizacionPorRendicion", delegate(DbCommand comando)
            {
                comando.Parameters["@pdocEntry"].Value = item.docEntry;
                comando.Parameters["@pdocEntryRE"].Value = docEntry;
                comando.Parameters["@pfechaContabilizacion"].Value = item.fechaContabilizacion;
            }, out filasAfectadas);
        }

        internal int ActualizarFechaContabilizacionPorCajaChica(int docEntry, GastoEntity item, out int filasAfectadas)
        {
            return base.Modificar("VS_OOGC_ActualizarFechaContabilizacionPorCajaChica", delegate(DbCommand comando)
            {
                comando.Parameters["@pdocEntry"].Value = item.docEntry;
                comando.Parameters["@pdocEntryCC"].Value = docEntry;
                comando.Parameters["@pfechaContabilizacion"].Value = item.fechaContabilizacion;
            }, out filasAfectadas);
        }
        #endregion

        #region Proveedor
        internal List<ProveedorEntity> BuscarProveedores(ProveedorEntity item)
        {
            dbxSap.Link();
            List<object[]> info = dbxSap.GetBlock("29", new string[] { 
            item.codigo, 
            item.nombre, 
            item.fila.ToString() 
         });
            dbxSap.Dispose();
            List<ProveedorEntity> ret = new List<ProveedorEntity>();
            foreach (object[] x in info)
            {
                ProveedorEntity m = new ProveedorEntity
                {
                    codigo = (string)x[0],
                    nombre = (string)x[1],
                    tipoDocumento = (string)x[2],
                    numeroDocumento = (string)x[3]
                };
                m.Impuesto = new ImpuestoEntity
                {
                    codigo = (string)x[4],
                    nombre = (string)x[5],
                    cantidad = Convert.ToDecimal(x[6])
                };

                if (m.tipoDocumento == "0")
                    m.nomTipoDocumento = "Otros Tipos de Documentos";
                else if (m.tipoDocumento == "1")
                    m.nomTipoDocumento = "Documento Nacional de Identidad";
                else if (m.tipoDocumento == "4")
                    m.nomTipoDocumento = "Carnet de Extranjeria";
                else if (m.tipoDocumento == "6")
                    m.nomTipoDocumento = "Registro Unico de Contribuyentes";
                else if (m.tipoDocumento == "7")
                    m.nomTipoDocumento = "Pasaporte";

                ret.Add(m);
            }

            return ret;
        }

        internal ProveedorEntity BuscarProveedor(string codigo)
        {
            dbxSap.Link();
            List<object[]> info = dbxSap.GetBlock("30", new string[] { 
            codigo 
         });
            dbxSap.Dispose();
            ProveedorEntity ret = new ProveedorEntity();
            if (info.Count == 1)
            {
                ret = new ProveedorEntity
                {
                    codigo = (string)info[0][0],
                    nombre = (string)info[0][1],
                    tipoDocumento = (string)info[0][2],
                    numeroDocumento = (string)info[0][3]
                };
                ret.Impuesto = new ImpuestoEntity
                {
                    codigo = (string)info[0][4],
                    nombre = (string)info[0][5],
                    cantidad = Convert.ToDecimal(info[0][6])
                };

                if (ret.tipoDocumento == "0")
                    ret.nomTipoDocumento = "Otros Tipos de Documentos";
                else if (ret.tipoDocumento == "1")
                    ret.nomTipoDocumento = "Documento Nacional de Identidad";
                else if (ret.tipoDocumento == "4")
                    ret.nomTipoDocumento = "Carnet de Extranjeria";
                else if (ret.tipoDocumento == "6")
                    ret.nomTipoDocumento = "Registro Unico de Contribuyentes";
                else if (ret.tipoDocumento == "7")
                    ret.nomTipoDocumento = "Pasaporte";
            }
            return ret;
        }

        internal List<ContabilizarEntity> VerificarProveedores(GastoEntity item)
        {
            dbxSap.Link();
            List<object[]> info = dbxSap.GetBlock("10", new string[] { });
            dbxSap.Dispose();
            DataTable provs = new DataTable();
            provs.Columns.Add("codigo", typeof(string));
            provs.Columns.Add("nombre", typeof(string));
            provs.Columns.Add("tipoDocumento", typeof(string));
            provs.Columns.Add("numeroDocumento", typeof(string));
            provs.Columns.Add("IMPcodigo", typeof(string));
            provs.Columns.Add("IMPnombre", typeof(string));
            provs.Columns.Add("IMPcantidad", typeof(decimal));

            foreach (var fila in info)
            {
                provs.Rows.Add(fila);
            }

            return base.Buscar<ContabilizarPopulate, ContabilizarEntity>(
               "VS_OOGC_VerificarProveedores",
               delegate(DbCommand comando)
               {
                   comando.Parameters["@sap"].Value = provs;
                   ((SqlCommand)comando).Parameters["@sap"].SqlDbType = SqlDbType.Structured;
                   ((SqlCommand)comando).Parameters["@sap"].TypeName = "dbo.provSAP";

                   comando.Parameters["@pnroRen"].Value = (item.Rendiciones != null) ?
                      item.Rendiciones.nroRen :
                      String.Empty;
                   comando.Parameters["@pnroCC"].Value = (item.CajaChica != null) ?
                      item.CajaChica.nroCC :
                      String.Empty;

                   if (item.Rendiciones != null)
                       comando.Parameters["@pcodProy"].Value = item.Rendiciones.Usuario.Proyecto.codProy;
                   if (item.CajaChica != null)
                       comando.Parameters["@pcodProy"].Value = item.CajaChica.Usuario.Proyecto.codProy;
               }
            );
        }
        #endregion

        internal List<CentroCostoEntity> BuscarCentroCostos(CentroCostoEntity item)
        {
            dbxSap.Link();
            List<object[]> info = dbxSap.GetBlock("49", new string[] { 
            String.IsNullOrEmpty(item.codigo) ? "" : item.codigo,
            String.IsNullOrEmpty(item.nombre) ? "" : item.nombre,
            item.nivel.ToString()
         });
            dbxSap.Dispose();
            List<CentroCostoEntity> ret = new List<CentroCostoEntity>();
            foreach (object[] x in info)
            {
                CentroCostoEntity m = new CentroCostoEntity
                {
                    codigo = (string)x[0],
                    nombre = (string)x[1],
                    nivel = Convert.ToInt32(x[2])
                };
                ret.Add(m);
            }

            return ret;
        }

        internal CentroCostoEntity BuscarCentroCosto(string codigo)
        {
            dbxSap.Link();
            List<object[]> info = dbxSap.GetBlock("49", new string[] { 
            codigo , 
            "",
            "0"
         });
            CentroCostoEntity ret = new CentroCostoEntity();
            if (info.Count > 0)
            {
                ret = new CentroCostoEntity
                {
                    codigo = (string)info[0][0],
                    nombre = (string)info[0][1],
                    nivel = Convert.ToInt32(info[0][2])
                };

                info = dbxSap.GetBlock("50", new string[] { codigo });
                StringBuilder sb = new StringBuilder();
                foreach (object[] a in info)
                {
                    sb.AppendFormat(" / {0}: {1}", (string)a[1], Convert.ToDecimal(a[2]));
                }
                if (sb.Length > 3)
                    sb.Remove(0, 3);

                ret.ccLinea = sb.ToString();
            }
            dbxSap.Dispose();
            return ret;
        }

        internal List<ImpuestoEntity> BuscarImpuestos(ImpuestoEntity item)
        {
            dbxSap.Link();
            List<object[]> info = dbxSap.GetBlock("31", new string[] { 
            item.codigo, 
            item.nombre
         });
            List<ImpuestoEntity> ret = new List<ImpuestoEntity>();
            foreach (object[] x in info)
            {
                ImpuestoEntity m = new ImpuestoEntity
                {
                    codigo = (string)x[0],
                    nombre = (string)x[1],
                    cantidad = Convert.ToDecimal(x[2])
                };
                ret.Add(m);
            }
            dbxSap.Dispose();

            return ret;
        }

        internal ImpuestoEntity BuscarImpuesto(string codigo)
        {
            dbxSap.Link();
            List<object[]> info = dbxSap.GetBlock("32", new string[] { 
            codigo 
         });
            ImpuestoEntity ret = new ImpuestoEntity();
            if (info.Count == 1)
            {
                ret = new ImpuestoEntity
                {
                    codigo = (string)info[0][0],
                    nombre = (string)info[0][1],
                    cantidad = Convert.ToDecimal(info[0][2])
                };
            }
            dbxSap.Dispose();
            return ret;
            //return base.Detalle<ImpuestoPopulate, ImpuestoEntity>(TablasEnum.Impuesto.GetDescription() + "_BuscarImpuesto", codigo, "@pcodigo");
        }

        internal List<TipoDocumentoEntity> ListarTipoDocumentoDocumento()
        {
            dbxSap.Link();
            List<object[]> info = dbxSap.GetBlock("33", new string[] { });
            List<TipoDocumentoEntity> ret = new List<TipoDocumentoEntity>();
            foreach (object[] x in info)
            {
                TipoDocumentoEntity m = new TipoDocumentoEntity
                {
                    codigo = (string)x[0],
                    nombre = (string)x[1]
                };
                ret.Add(m);
            }
            dbxSap.Dispose();

            return ret;
        }

        internal List<TipoDocumentoEntity> ListarTipoDocumentoGasto()
        {
            dbxSap.Link();
            List<object[]> info = dbxSap.GetBlock("33", new string[] { });
            List<TipoDocumentoEntity> ret = new List<TipoDocumentoEntity>();
            foreach (object[] x in info)
            {
                TipoDocumentoEntity m = new TipoDocumentoEntity
                {
                    codigo = (string)x[0],
                    nombre = (string)x[1]
                };
                ret.Add(m);
            }
            dbxSap.Dispose();

            return ret;
        }

        internal List<ContabilizarEntity> VerificarArticulos(GastoEntity item)
        {
            dbxSap.Link();
            List<object[]> info = dbxSap.GetBlock("6", new string[] { "" });
            DataTable arts = new DataTable();
            arts.Columns.Add("codigo", typeof(string));
            arts.Columns.Add("nombre", typeof(string));
            arts.Columns.Add("unidadmedida", typeof(string));
            arts.Columns.Add("ItmsGrpCod", typeof(int));
            arts.Columns.Add("GLMethod", typeof(string));

            foreach (var fila in info)
            {
                arts.Rows.Add(fila);
            }
            dbxSap.Dispose();

            return base.Buscar<ContabilizarPopulate, ContabilizarEntity>(
               "VS_OOGC_VerificarArticulos",
               delegate(DbCommand comando)
               {
                   comando.Parameters["@sap"].Value = arts;
                   ((SqlCommand)comando).Parameters["@sap"].SqlDbType = SqlDbType.Structured;
                   ((SqlCommand)comando).Parameters["@sap"].TypeName = "dbo.artSAP";

                   comando.Parameters["@pnroRen"].Value = (item.Rendiciones != null) ?
                      item.Rendiciones.nroRen :
                      String.Empty;
                   comando.Parameters["@pnroCC"].Value = (item.CajaChica != null) ?
                      item.CajaChica.nroCC :
                      String.Empty;

                   if (item.Rendiciones != null)
                       comando.Parameters["@pcodProy"].Value = item.Rendiciones.Usuario.Proyecto.codProy;
                   if (item.CajaChica != null)
                       comando.Parameters["@pcodProy"].Value = item.CajaChica.Usuario.Proyecto.codProy;
               }
            );
        }

        internal GastoEntity BuscarTipoCambio(String fecha, String moneda)
        {
            dbxSap.Link();
            List<object[]> info = dbxSap.GetBlock("33", new string[] { 
            fecha,
            moneda
         });
            GastoEntity ret = new GastoEntity();
            if (info.Count == 1)
            {
                ret = new GastoEntity
                {
                    valorTipoCambio = (string)info[0][0]
                };
            }
            dbxSap.Dispose();
            return ret;
        }
        // its -  Joseph 

        internal GastoEntity Dimension01()
        {


            dbxSap.Link();
            List<object[]> info = dbxSap.GetBlock("55", new string[] { 
         });
            GastoEntity ret = new GastoEntity();
            if (info.Count == 1)
            {
                ret = new GastoEntity
                {
                    Dimension1 = (string)info[0][0]
                };
            }
            dbxSap.Dispose();
            return ret;


        }

        internal GastoEntity Dimension02()
        {

            dbxSap.Link();
            List<object[]> info = dbxSap.GetBlock("56", new string[] { 
         });
            GastoEntity ret = new GastoEntity();
            if (info.Count == 1)
            {
                ret = new GastoEntity
                {
                    Dimension2 = (string)info[0][0]
                };
            }
            dbxSap.Dispose();
            return ret;


        }

        internal GastoEntity Dimension03()
        {

            dbxSap.Link();
            List<object[]> info = dbxSap.GetBlock("57", new string[] { 
         });
            GastoEntity ret = new GastoEntity();
            if (info.Count == 1)
            {
                ret = new GastoEntity
                {
                    Dimension3 = (string)info[0][0]
                };
            }
            dbxSap.Dispose();
            return ret;


        }

        internal GastoEntity Dimension04()
        {

            dbxSap.Link();
            List<object[]> info = dbxSap.GetBlock("58", new string[] { 
         });
            GastoEntity ret = new GastoEntity();
            if (info.Count == 1)
            {
                ret = new GastoEntity
                {
                    Dimension4 = (string)info[0][0]
                };
            }
            dbxSap.Dispose();
            return ret;


        }

        internal GastoEntity Dimension05()
        {

            dbxSap.Link();
            List<object[]> info = dbxSap.GetBlock("59", new string[] { 
         });
            GastoEntity ret = new GastoEntity();
            if (info.Count == 1)
            {
                ret = new GastoEntity
                {
                    Dimension5 = (string)info[0][0]
                };
            }
            dbxSap.Dispose();
            return ret;


        }
    }
}
