using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MISAP.Entity;
using System.Data.Common;

namespace MISAP.Repository
{
    internal class RendicionesRepository
      : TesoreriaBaseRepository<RendicionesEntity>
    {
        public VSSQLFactory dbxSap;

        public RendicionesRepository()
        {
            dbxSap = new VSSQLFactory();
        }

        #region Rendiciones
        protected override void ConfigurarParametros(DbCommand comando, RendicionesEntity item)
        {
            comando.Parameters["@pdocEntry"].Value = item.docEntry;
            comando.Parameters["@pnroRen"].Value = item.nroRen;
            comando.Parameters["@pcodEmp"].Value = item.codEmp;
            comando.Parameters["@pnomEmp"].Value = item.nomEmp;
            comando.Parameters["@pnroOT"].Value = item.nroOT;
            comando.Parameters["@pfecha"].Value = (item.fecha == null || item.fecha == DateTime.MinValue) ? DateTime.Now : item.fecha;
            comando.Parameters["@pestado"].Value = item.estado;
            comando.Parameters["@pmonto"].Value = item.monto;
            comando.Parameters["@pmoneda"].Value = item.moneda;
            comando.Parameters["@pdocEntrySD"].Value = item.SolicitudDinero.docEntry;
            comando.Parameters["@pcodUsu"].Value = item.Usuario.codUsu;
            comando.Parameters["@pcodProy"].Value = item.Usuario.Proyecto.codProy;
            comando.Parameters["@pcomentarios"].Value = item.comentarios;
        }

        internal override int Registrar(RendicionesEntity item, out int filasAfectadas)
        {
            nombreParametroRetorno = "@pdocEntry";
            return base.Registrar("VS_OORE_RegMod", item, out filasAfectadas);
        }

        internal override int Modificar(RendicionesEntity item, out int filasAfectadas)
        {
            nombreParametroRetorno = "@pdocEntry";
            return base.Modificar("VS_OORE_RegMod", item, out filasAfectadas);
        }

        //internal override RendicionesEntity Detalle(int docEntry)
        //{
        //    return base.Detalle<RendicionesPopulate>("VS_OORE_Detalle", docEntry, "@pdocEntry");
        //}

        protected override void ConfigurarParametrosBuscar(DbCommand comando, RendicionesEntity item)
        {
            comando.Parameters["@pnroRen"].Value = item.nroRen;
            comando.Parameters["@pfechaDesde"].Value = item.fechaDesde;
            comando.Parameters["@pfechaHasta"].Value = item.fechaHasta;
            comando.Parameters["@pestado"].Value = item.estado;
            comando.Parameters["@pcodProy"].Value = item.Usuario.Proyecto.codProy;
        }

        internal override List<RendicionesEntity> Buscar(RendicionesEntity item, PaginadorEntity paginador)
        {
            return base.Buscar<RendicionesPopulate>("VS_OORE_Buscar", item, paginador);
        }

        internal int Contabilizar(int docEntry, out int filasAfectadas)
        {
            return base.RegMod("VS_OORE_Contabilizar",
               delegate(DbCommand comando)
               {
                   comando.Parameters["@pdocEntry"].Value = docEntry;
               },
               out filasAfectadas);
        }

        #region SAP
        internal List<RendicionesEntity> BuscarRendicionesSAP(RendicionesEntity item)
        {
            dbxSap.Link();
            List<object[]> info = dbxSap.GetBlock("25", new string[] { 
            item.nroRen, 
            (item.fecha.HasValue ? item.fecha.Value.ToString("yyyyMMdd") : ""),
            item.Usuario.Proyecto.codProy,
            item.fila.ToString() 
         });
            dbxSap.Dispose();
            List<RendicionesEntity> ret = new List<RendicionesEntity>();
            foreach (object[] x in info)
            {
                RendicionesEntity m = new RendicionesEntity
                {
                    docEntry = (int)x[0],
                    nroRen = (string)x[1],
                    monto = Convert.ToDecimal(x[2]),
                    moneda = (string)x[3],
                    codEmp = (string)x[4],
                    nomEmp = (string)x[5],
                    //ti = (int)x[6],
                    //cod = (int)x[7],
                    fecha = (DateTime?)x[8],
                    fila = (int)x[9]
                };
                if (m.estado == "P")
                    m.nomEstado = "Pendiente";
                else if (m.estado == "C")
                    m.nomEstado = "Cerrado";
                else if (m.estado == "N")
                    m.nomEstado = "Anulado";

                if (m.moneda == "SOL")
                    m.nomMoneda = "Nuevos Soles";
                else if (m.moneda == "USD")
                    m.nomMoneda = "Dólares Americanos";
                ret.Add(m);
            }
            var exi = Buscar<RendicionesPopulate>("VS_OORE_LeerNroRen");
            string[] codigos = exi.Select(x => x.nroRen).ToArray();

            ret.RemoveAll(x => codigos.Contains(x.nroRen));

            return ret;
            //return Buscar<RendicionesPopulate>(TablasEnum.RendicionesSAP.GetDescription() + "_BuscarRendiciones", delegate(DbCommand comando)
            //{
            //   comando.Parameters["@pnroRen"].Value = item.nroRen;
            //   comando.Parameters["@pfecha"].Value = (item.fecha == null || item.fecha == DateTime.MinValue) ? null : item.fecha;
            //   comando.Parameters["@pcodProy"].Value = item.Usuario.Proyecto.codProy;
            //   comando.Parameters["@pfila"].Value = item.fila;
            //});
        }

        internal RendicionesEntity BuscarRendicionSAP(String nroRen)
        {
            dbxSap.Link();
            List<object[]> info = dbxSap.GetBlock("26", new string[] { 
            nroRen 
         });
            dbxSap.Dispose();
            RendicionesEntity ret = new RendicionesEntity();
            if (info.Count == 1)
            {
                ret = new RendicionesEntity
                {
                    docEntry = (int)info[0][0],
                    nroRen = (string)info[0][1],
                    monto = Convert.ToDecimal(info[0][2]),
                    moneda = (string)info[0][3],
                    codEmp = (string)info[0][4],
                    nomEmp = (string)info[0][5],
                    //ti = (string)info[0][6],
                    //codProy = (string)info[0][7],
                    fecha = (DateTime?)info[0][8]
                };

                if (ret.estado == "P")
                    ret.nomEstado = "Pendiente";
                else if (ret.estado == "C")
                    ret.nomEstado = "Cerrado";
                else if (ret.estado == "N")
                    ret.nomEstado = "Anulado";

                if (ret.moneda == "SOL")
                    ret.nomMoneda = "Nuevos Soles";
                else if (ret.moneda == "USD")
                    ret.nomMoneda = "Dólares Americanos";

                string codProy = (string)info[0][7];
                //ProyectoRepository tmpProj = new ProyectoRepository();
                //var pj = tmpProj.Detalle(codProy);
                ret.nroOT = codProy; //pj.nroOT;
            }

            return ret;
            //return Detalle<RendicionesPopulate, RendicionesEntity>(TablasEnum.RendicionesSAP.GetDescription() + "_BuscarRendicion", nroRen, "@pnroRen");
        }
        #endregion
        #endregion

        #region SolicitudDinero
        #region SAP
        internal List<SolicitudDineroEntity> BuscarSolicitudesDinero(string codigo, DateTime? fecha, String codProy)
        {
            return Buscar<SolicitudDineroPopulate, SolicitudDineroEntity>("VS_OORE_BuscarSolicitudesDinero", delegate(DbCommand comando)
            {
                comando.Parameters["@pcodigo"].Value = codigo;
                comando.Parameters["@pfecha"].Value = fecha;
                comando.Parameters["@pestado"].Value = "A";
                comando.Parameters["@pcodProy"].Value = codProy;
            });
        }

        internal SolicitudDineroEntity BuscarSolicitudDinero(int docEntry)
        {
            return Detalle<SolicitudDineroPopulate, SolicitudDineroEntity>("VS_OORE_BuscarSolicitudDinero", docEntry, "@pdocEntry");
        }
        #endregion
        #endregion
    }
}
