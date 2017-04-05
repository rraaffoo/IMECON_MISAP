using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MISAP.Entity;
using System.Data.Common;

namespace MISAP.Repository
{
    internal class ProyectoRepository
      : BaseRepository<ProyectoEntity>
    {
        public VSSQLFactory dbxSap;

        public ProyectoRepository()
        {
            dbxSap = new VSSQLFactory();
        }

        protected override void ConfigurarParametros(DbCommand comando, ProyectoEntity item)
        {
            comando.Parameters["@pcodProy"].Value = item.codProy;
            comando.Parameters["@pnomProy"].Value = item.nomProy;
            comando.Parameters["@pnroOT"].Value = item.nroOT;
            comando.Parameters["@pestado"].Value = item.estado;
            comando.Parameters["@pcodAlm"].Value = item.codAlm;
            comando.Parameters["@pnomAlm"].Value = item.nomAlm;
            comando.Parameters["@pidUbicacion"].Value = item.idUbicacion;
            comando.Parameters["@pnomUbicacion"].Value = item.nomUbicacion;
            comando.Parameters["@pcodCuenta"].Value = item.Cuenta.codigo;
            comando.Parameters["@pnomCuenta"].Value = item.Cuenta.nombre;
            comando.Parameters["@pcodCuentaRendicion"].Value = item.CuentaRendicion.codigo;
            comando.Parameters["@pnomCuentaRendicion"].Value = item.CuentaRendicion.nombre;
            comando.Parameters["@ptotalCaja"].Value = item.totalCaja;
            comando.Parameters["@pmoneda"].Value = item.moneda;
            comando.Parameters["@pcodUsu"].Value = item.Usuario.codUsu;

            comando.Parameters["@pidCC"].Value = item.pidCC;
            comando.Parameters["@pcorrelativoCC"].Value = item.pcorrelativoCC;

            comando.Parameters["@pcomentarios"].Value = item.comentarios;
            //its - Joseph
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

            // its - Joseph Fin
        }

        internal override int Modificar(ProyectoEntity item, out int filasAfectadas)
        {
            // traer los datos de caja
            dbxSap.Link();
            List<object[]> info = dbxSap.GetBlock("41", new string[] { 
            item.Cuenta.codigo
         });
            dbxSap.Dispose();
            item.pidCC = (string)info[0][0];
            item.pcorrelativoCC = (string)info[0][1];

            return base.Modificar("VS_OOPR_RegMod", item, out filasAfectadas);
        }

        //internal override ProyectoEntity Detalle(string codProy)
        //{
        //    return base.Detalle<ProyectoPopulate>("VS_OOPR_Detalle", codProy, "@pcodProy");
        //}

        protected override void ConfigurarParametrosBuscar(DbCommand comando, ProyectoEntity item)
        {
            comando.Parameters["@pcodProy"].Value = item.codProy;
            comando.Parameters["@pnomProy"].Value = item.nomProy;
        }

        internal override List<ProyectoEntity> Buscar(ProyectoEntity item, PaginadorEntity paginador)
        {
            return base.Buscar<ProyectoPopulate>("VS_OOPR_Buscar", item, paginador);
        }

        internal List<ProyectoEntity> BuscarProyectosSAP(ProyectoEntity item)
        {
            List<ProyectoEntity> exi = base.Buscar<ProyectoPopulate, ProyectoEntity>("VS_OOPR_LeerCodigos");
            string[] codigos = exi.Select(x => x.codProy).ToArray();
            StringBuilder sb = new StringBuilder();
            //if (Dev.I.Code.Options.EnhancedLogic)
            //{
            //    sb.Append(";");
            //    foreach (string cp in codigos)
            //        sb.AppendFormat("{0};", cp);
            //}

            dbxSap.Link();
            List<object[]> info = dbxSap.GetBlock("17", new string[] { 
            item.codProy, 
            item.nomProy, 
            item.fila.ToString(),
            sb.ToString()
         });
            dbxSap.Dispose();
            List<ProyectoEntity> ret = new List<ProyectoEntity>();
            foreach (object[] x in info)
            {
                ProyectoEntity m = new ProyectoEntity
                {
                    codProy = (string)x[0],
                    nomProy = (string)x[1],
                    nroOT = (string)x[2]
                };
                //m.nroOT = "OT-" + m.codProy;
                ret.Add(m);
            }

            //if (!Dev.I.Code.Options.EnhancedLogic)
            //{
            //    ret.RemoveAll(x => codigos.Contains(x.codProy));
            //}

            return ret;
        }

        internal ProyectoEntity BuscarProyectoSAP(string codigo)
        {
            dbxSap.Link();
            List<object[]> info = dbxSap.GetBlock("18", new string[] { 
            codigo 
         });
            dbxSap.Dispose();
            ProyectoEntity ret = new ProyectoEntity();
            if (info.Count == 1)
            {
                ret = new ProyectoEntity
                {
                    codProy = (string)info[0][0],
                    nomProy = (string)info[0][1],
                    nroOT = (string)info[0][2]
                };
            }
            return ret;
        }

        internal List<AlmacenEntity> BuscarAlmacenes(AlmacenEntity item)
        {
            dbxSap.Link();
            List<object[]> info = dbxSap.GetBlock("19", new string[] { 
            item.codAlm, 
            item.nomAlm, 
            item.fila.ToString() 
         });
            dbxSap.Dispose();
            List<AlmacenEntity> ret = new List<AlmacenEntity>();
            foreach (object[] x in info)
            {
                AlmacenEntity m = new AlmacenEntity
                {
                    codAlm = (string)x[0],
                    nomAlm = (string)x[1],
                    TieneUbi = (string)x[2],
                    fila = (int)x[3]
                };
                ret.Add(m);
            }

            return ret;
        }

        internal AlmacenEntity BuscarAlmacen(string codigo)
        {
            dbxSap.Link();
            List<object[]> info = dbxSap.GetBlock("20", new string[] { 
            codigo 
         });
            dbxSap.Dispose();
            AlmacenEntity ret = new AlmacenEntity();
            if (info.Count == 1)
            {
                ret = new AlmacenEntity
                {
                    codAlm = (string)info[0][0],
                    nomAlm = (string)info[0][1],
                    TieneUbi = (string)info[0][2]
                };
            }
            return ret;
        }

        internal List<UbicacionEntity> BuscarUbicaciones(UbicacionEntity item)
        {
            var exi = base.Buscar<UbicacionPopulate, UbicacionEntity>("VS_OOPR_LeerUbicaciones");
            int[] codigos = exi.Select(x => x.idUbicacion).ToArray();
            StringBuilder sb = new StringBuilder();
            //if (Dev.I.Code.Options.EnhancedLogic)
            //{
            //    sb.Append(";");
            //    foreach (int cp in codigos)
            //        sb.AppendFormat("{0};", cp);
            //}

            dbxSap.Link();
            List<object[]> info = dbxSap.GetBlock("21", new string[] { 
            item.idUbicacion.ToString(), 
            item.nomUbicacion ?? "", 
            item.codAlm ?? "",
            item.fila.ToString(),
            sb.ToString()
         });
            dbxSap.Dispose();
            List<UbicacionEntity> ret = new List<UbicacionEntity>();
            foreach (object[] x in info)
            {
                UbicacionEntity m = new UbicacionEntity
                {
                    idUbicacion = (int)x[0],
                    nomUbicacion = (string)x[1],
                    fila = (int)x[2]
                };
                ret.Add(m);
            }

            //if (!Dev.I.Code.Options.EnhancedLogic)
            //{
            //    ret.RemoveAll(x => codigos.Contains(x.idUbicacion));
            //}

            return ret;
        }

        internal UbicacionEntity BuscarUbicacion(int idUbicacion)
        {
            dbxSap.Link();
            List<object[]> info = dbxSap.GetBlock("22", new string[] { 
            idUbicacion.ToString() 
         });
            dbxSap.Dispose();
            UbicacionEntity ret = new UbicacionEntity();
            if (info.Count == 1)
            {
                ret = new UbicacionEntity
                {
                    idUbicacion = (int)info[0][0],
                    nomUbicacion = (string)info[0][1]
                };
            }
            return ret;
        }

        internal List<CuentaEntity> BuscarCuentas(CuentaEntity item)
        {
            dbxSap.Link();
            List<object[]> info = dbxSap.GetBlock("23", new string[] { 
            item.codigo, 
            item.nombre,
            item.fila.ToString() 
         });
            dbxSap.Dispose();
            List<CuentaEntity> ret = new List<CuentaEntity>();
            foreach (object[] x in info)
            {
                CuentaEntity m = new CuentaEntity
                {
                    codigo = (string)x[0],
                    nombre = (string)x[1],
                    moneda = (string)x[2],
                    fila = (int)x[3]
                };

                if (m.moneda == "SOL")
                    m.nomMoneda = "Nuevos Soles";
                else if (m.moneda == "USD")
                    m.nomMoneda = "Dólares Americanos";
                ret.Add(m);
            }

            return ret;
        }

        internal CuentaEntity BuscarCuenta(string codigo)
        {
            dbxSap.Link();
            List<object[]> info = dbxSap.GetBlock("24", new string[] { 
            codigo 
         });
            dbxSap.Dispose();
            CuentaEntity ret = new CuentaEntity();
            if (info.Count == 1)
            {
                ret = new CuentaEntity
                {
                    codigo = (string)info[0][0],
                    nombre = (string)info[0][1],
                    moneda = (string)info[0][2]
                };
                if (ret.moneda == "SOL")
                    ret.nomMoneda = "Nuevos Soles";
                else if (ret.moneda == "USD")
                    ret.nomMoneda = "Dólares Americanos";
            }
            return ret;
        }

        internal List<CuentaEntity> BuscarCuentasRendicion(CuentaEntity item)
        {
            dbxSap.Link();
            List<object[]> info = dbxSap.GetBlock("25", new string[] { 
            item.codigo, 
            item.nombre,
            item.fila.ToString() 
         });
            dbxSap.Dispose();
            List<CuentaEntity> ret = new List<CuentaEntity>();
            foreach (object[] x in info)
            {
                CuentaEntity m = new CuentaEntity
                {
                    codigo = (string)x[0],
                    nombre = (string)x[1],
                    fila = (int)x[2]
                };

                if (m.moneda == "SOL")
                    m.nomMoneda = "Nuevos Soles";
                else if (m.moneda == "USD")
                    m.nomMoneda = "Dólares Americanos";

                ret.Add(m);
            }

            return ret;
        }

        internal CuentaEntity BuscarCuentaRendicion(string codigo)
        {
            dbxSap.Link();
            List<object[]> info = dbxSap.GetBlock("26", new string[] { 
            codigo 
         });
            dbxSap.Dispose();
            CuentaEntity ret = new CuentaEntity();
            if (info.Count == 1)
            {
                ret = new CuentaEntity
                {
                    codigo = (string)info[0][0],
                    nombre = (string)info[0][1],
                    moneda = (string)info[0][2]
                };

                if (ret.moneda == "SOL")
                    ret.nomMoneda = "Nuevos Soles";
                else if (ret.moneda == "USD")
                    ret.nomMoneda = "Dólares Americanos";
            }
            return ret;
        }
        //its - Joseph  
        //internal List<CentroCostoConfiguracionEntity> BuscarCentroCostos(CentroCostoConfiguracionEntity item)
        //{
        //    dbxSap.Link();
        //    List<object[]> info = dbxSap.GetBlock(Consulta.NormaReparto_Buscar, new string[] { 
        //    String.IsNullOrWhiteSpace(item.codigo) ? "" : item.codigo,
        //    String.IsNullOrWhiteSpace(item.nombre) ? "" : item.nombre,
        //    item.nivel.ToString()
        // });
        //    dbxSap.Dispose();
        //    List<CentroCostoConfiguracionEntity> ret = new List<CentroCostoConfiguracionEntity>();
        //    foreach (object[] x in info)
        //    {
        //        CentroCostoConfiguracionEntity m = new CentroCostoConfiguracionEntity
        //        {
        //            codigo = (string)x[0],
        //            nombre = (string)x[1],
        //            nivel = Convert.ToInt32(x[2])
        //        };
        //        ret.Add(m);
        //    }

        //    return ret;
        //}

        //internal CentroCostoConfiguracionEntity BuscarCentroCosto(string codigo)
        //{
        //    dbxSap.Link();
        //    List<object[]> info = dbxSap.GetBlock(Consulta.NormaReparto_Buscar, new string[] { 
        //    codigo , 
        //    "",
        //    "0"
        // });
        //    CentroCostoConfiguracionEntity ret = new CentroCostoConfiguracionEntity();
        //    if (info.Count > 0)
        //    {
        //        ret = new CentroCostoConfiguracionEntity
        //        {
        //            codigo = (string)info[0][0],
        //            nombre = (string)info[0][1],
        //            nivel = Convert.ToInt32(info[0][2])
        //        };

        //        info = dbxSap.GetBlock(Consulta.NRCC_Buscar, new string[] { codigo });
        //        StringBuilder sb = new StringBuilder();
        //        foreach (object[] a in info)
        //        {
        //            sb.AppendFormat(" / {0}: {1}", (string)a[1], Convert.ToDecimal(a[2]));
        //        }
        //        if (sb.Length > 3)
        //            sb.Remove(0, 3);

        //        ret.ccLinea = sb.ToString();
        //    }
        //    dbxSap.Dispose();
        //    return ret;
        //}

        // its -  Joseph 



        internal CuentaEntity Dimension01_P()
        {


            dbxSap.Link();
            List<object[]> info = dbxSap.GetBlock("60", new string[] { 
         });
            CuentaEntity ret = new CuentaEntity();
            if (info.Count == 1)
            {
                ret = new CuentaEntity
                {
                    Dimension1 = (string)info[0][0]
                };
            }
            dbxSap.Dispose();
            return ret;


        }

        internal CuentaEntity Dimension02_P()
        {

            dbxSap.Link();
            List<object[]> info = dbxSap.GetBlock("61", new string[] { 
         });
            CuentaEntity ret = new CuentaEntity();
            if (info.Count == 1)
            {
                ret = new CuentaEntity
                {
                    Dimension2 = (string)info[0][0]
                };
            }
            dbxSap.Dispose();
            return ret;


        }

        internal CuentaEntity Dimension03_P()
        {

            dbxSap.Link();
            List<object[]> info = dbxSap.GetBlock("62", new string[] { 
         });
            CuentaEntity ret = new CuentaEntity();
            if (info.Count == 1)
            {
                ret = new CuentaEntity
                {
                    Dimension3 = (string)info[0][0]
                };
            }
            dbxSap.Dispose();
            return ret;


        }

        internal CuentaEntity Dimension04_P()
        {

            dbxSap.Link();
            List<object[]> info = dbxSap.GetBlock("63", new string[] { 
         });
            CuentaEntity ret = new CuentaEntity();
            if (info.Count == 1)
            {
                ret = new CuentaEntity
                {
                    Dimension4 = (string)info[0][0]
                };
            }
            dbxSap.Dispose();
            return ret;


        }

        internal CuentaEntity Dimension05_P()
        {

            dbxSap.Link();
            List<object[]> info = dbxSap.GetBlock("64", new string[] { 
         });
            CuentaEntity ret = new CuentaEntity();
            if (info.Count == 1)
            {
                ret = new CuentaEntity
                {
                    Dimension5 = (string)info[0][0]
                };
            }
            dbxSap.Dispose();
            return ret;


        }
    }
}
