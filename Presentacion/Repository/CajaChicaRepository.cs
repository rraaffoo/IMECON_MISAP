using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MISAP.Entity;
using System.Data.Common;

namespace MISAP.Repository
{
    internal class CajaChicaRepository
      : TesoreriaBaseRepository<CajaChicaEntity>
    {
        #region CajaChica
        protected override void ConfigurarParametros(DbCommand comando, CajaChicaEntity item)
        {
            comando.Parameters["@pdocEntry"].Value = item.docEntry;
            comando.Parameters["@pnroCC"].Value = item.nroCC;
            comando.Parameters["@pnroOT"].Value = item.nroOT;
            comando.Parameters["@ptotalCaja"].Value = item.totalCaja;
            comando.Parameters["@pmoneda"].Value = item.moneda;
            comando.Parameters["@pfechaCierre"].Value = item.fechaCierre;
            comando.Parameters["@pestado"].Value = item.estado;
            comando.Parameters["@pcodUsu"].Value = item.Usuario.codUsu;
            comando.Parameters["@pcodProy"].Value = item.Usuario.Proyecto.codProy;
            comando.Parameters["@pcomentarios"].Value = item.comentarios;
        }

        //internal override int Registrar(CajaChicaEntity item, out int filasAfectadas)
        //{
        //    nombreParametroRetorno = "@pdocEntry";
        //    return base.Registrar(TablasEnum.CajaChica.GetDescription() + "_RegMod", item, out filasAfectadas);
        //}

        //internal override int Modificar(CajaChicaEntity item, out int filasAfectadas)
        //{
        //    nombreParametroRetorno = "@pdocEntry";
        //    return base.Modificar(TablasEnum.CajaChica.GetDescription() + "_RegMod", item, out filasAfectadas);
        //}

        protected override void ConfigurarParametrosBuscar(DbCommand comando, CajaChicaEntity item)
        {
            comando.Parameters["@pnroCC"].Value = item.nroCC;
            comando.Parameters["@pmoneda"].Value = item.moneda;
            comando.Parameters["@pestado"].Value = item.estado;
            comando.Parameters["@pcodProy"].Value = item.Usuario.Proyecto.codProy;
        }

        //internal override List<CajaChicaEntity> Buscar(CajaChicaEntity item, PaginadorEntity paginador)
        //{
        //    return base.Buscar<CajaChicaPopulate>(TablasEnum.CajaChica.GetDescription() + "_Buscar", item, paginador);
        //}

        //internal override CajaChicaEntity Detalle(int docEntry)
        //{
        //    return base.Detalle<CajaChicaPopulate>("VS_OOCC_Detalle", docEntry, "@pdocEntry");
        //}

        //internal List<CajaChicaEntity> BuscarCajasChicasVecinas(String codProy, int docEntry)
        //{
        //    return base.Buscar<CajaChicaPopulate>(TablasEnum.CajaChica.GetDescription() + "_BuscarCajasChicasVecinas", delegate(DbCommand comando)
        //    {
        //        comando.Parameters["@pcodProy"].Value = codProy;
        //        comando.Parameters["@pdocEntry"].Value = docEntry;
        //    });
        //}

        internal int Contabilizar(int docEntry, out int filasAfectadas)
        {
            return base.RegMod("VS_OOCC_Contabilizar", delegate(DbCommand comando)
            {
                comando.Parameters["@pdocEntry"].Value = docEntry;
            }, out filasAfectadas);
        }
        #endregion
    }
}
