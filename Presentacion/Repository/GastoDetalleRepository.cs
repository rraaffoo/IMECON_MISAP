using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MISAP.Entity;
using System.Data.Common;

namespace MISAP.Repository
{
    internal class GastoDetalleRepository
      : TesoreriaBaseRepository<GastoDetalleEntity>
    {
        public VSSQLFactory dbxSap;

        public GastoDetalleRepository()
        {
            dbxSap = new VSSQLFactory();
        }

        #region GastoDetalle
        protected override void ConfigurarParametros(DbCommand comando, GastoDetalleEntity item)
        {
            comando.Parameters["@pdocEntry"].Value = item.docEntry;
            comando.Parameters["@plineId"].Value = item.lineId;
            comando.Parameters["@pcodArt"].Value = item.codArt;
            comando.Parameters["@pdesArt"].Value = item.desArt;
            comando.Parameters["@pundMed"].Value = item.undMed;
            comando.Parameters["@pcant"].Value = item.cant;
            comando.Parameters["@pprecio"].Value = item.precio;
            comando.Parameters["@pdocEntryGC"].Value = item.Gasto.docEntry;
            comando.Parameters["@pcodProy"].Value = item.codProy;
            comando.Parameters["@pnroOT"].Value = item.nroOT;

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
        }

        internal override int Registrar(GastoDetalleEntity item, out int filasAfectadas)
        {
            nombreParametroRetorno = "@pdocEntry";
            return base.Registrar("VS_OOGD_RegMod", item, out filasAfectadas);
        }

        internal override int Modificar(GastoDetalleEntity item, out int filasAfectadas)
        {
            nombreParametroRetorno = "@pdocEntry";
            return base.Modificar("VS_OOGD_RegMod", item, out filasAfectadas);
        }

        //internal override GastoDetalleEntity Detalle(int docEntry)
        //{
        //    return base.Detalle<GastoDetallePopulate>("VS_OOGD_Detalle", docEntry, "@pdocEntry");
        //}

        internal List<GastoDetalleEntity> BuscarGastosDetallePorGasto(int docEntry, String codAlm = "")
        {
            List<GastoDetalleEntity> ret = base.Buscar<GastoDetallePopulate>(
               "VS_OOGD_BuscarGastosDetallePorGasto",
               delegate(DbCommand comando)
               {
                   comando.Parameters["@pdocEntry"].Value = docEntry;
               }
            );

            dbxSap.Link();
            foreach (var y in ret)
            {
                if (!String.IsNullOrEmpty(codAlm))
                {
                    y.cuentadestino = dbxSap.GetValue<string>(
                       "47",
                       new string[] { 
                     y.codArt, 
                     codAlm 
                  }
                    ) ?? "";
                }
            }
            dbxSap.Dispose();

            return ret;
        }

        internal override int Eliminar(int docEntry, out int filasAfectadas)
        {
            base.nombreParametroRetorno = "@pdocEntry";
            return base.Eliminar("VS_OOGD_Eliminar", docEntry, out filasAfectadas);
        }
        #endregion

        #region Articulo
        internal List<ArticuloEntity> BuscarArticulos(ArticuloEntity item)
        {
            dbxSap.Link();
            List<object[]> info = dbxSap.GetBlock("36", new string[] { 
            item.codigo, 
            item.nombre, 
            item.fila.ToString() 
         });
            dbxSap.Dispose();
            List<ArticuloEntity> ret = new List<ArticuloEntity>();
            foreach (object[] x in info)
            {
                ArticuloEntity m = new ArticuloEntity
                {
                    codigo = (string)x[0],
                    nombre = (string)x[1],
                    unidadmedida = (string)x[2],
                    ItmsGrpCod = (int)x[3],
                    GLMethod = (string)x[4],
                    detind = (string)x[5],
                    detcod = (string)x[6],
                    detpor = Convert.ToDecimal(x[7])
                };
                ret.Add(m);
            }

            return ret;
            //return base.Buscar<ArticuloPopulate, ArticuloEntity>(TablasEnum.Articulo.GetDescription() + "_BuscarArticulos", delegate(DbCommand comando)
            //{
            //   comando.Parameters["@pcodigo"].Value = item.codigo;
            //   comando.Parameters["@pnombre"].Value = item.nombre;
            //   comando.Parameters["@pfila"].Value = item.fila;
            //});
        }

        internal ArticuloEntity BuscarArticulo(string codigo)
        {
            dbxSap.Link();
            List<object[]> info = dbxSap.GetBlock("37", new string[] { 
            codigo 
         });
            dbxSap.Dispose();
            ArticuloEntity ret = new ArticuloEntity();
            if (info.Count == 1)
            {
                ret = new ArticuloEntity
                {
                    codigo = (string)info[0][0],
                    nombre = (string)info[0][1],
                    unidadmedida = (string)info[0][2],
                    ItmsGrpCod = (int)info[0][3],
                    GLMethod = (string)info[0][4],
                    detind = (string)info[0][5],
                    detcod = (string)info[0][6],
                    detpor = Convert.ToDecimal(info[0][7])
                };
            }
            return ret;
            //return base.Detalle<ArticuloPopulate, ArticuloEntity>(TablasEnum.Articulo.GetDescription() + "_BuscarArticulo", codigo, "@pcodigo");
        }
        #endregion
    }
}
