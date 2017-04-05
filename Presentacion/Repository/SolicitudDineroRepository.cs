using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MISAP.Entity;
using System.Data.Common;

namespace MISAP.Repository
{
    internal class SolicitudDineroRepository
       : TesoreriaBaseRepository<SolicitudDineroEntity>
    {
        protected override void ConfigurarParametros(DbCommand comando, SolicitudDineroEntity item)
        {
            comando.Parameters["@pdocEntry"].Value = item.docEntry;
            comando.Parameters["@pcodigo"].Value = item.codigo;
            comando.Parameters["@pfecha"].Value = item.fecha;
            comando.Parameters["@pmonto"].Value = item.monto;
            comando.Parameters["@pmoneda"].Value = item.moneda;
            comando.Parameters["@pmotivo"].Value = item.motivo;
            comando.Parameters["@pcodEmp"].Value = item.codEmp;
            comando.Parameters["@pnomEmp"].Value = item.nomEmp;
            comando.Parameters["@pmotAdicional"].Value = item.motAdicional;
            comando.Parameters["@pfecharegistro"].Value = (item.fecharegistro == null || item.fecharegistro == DateTime.MinValue) ? DateTime.Now : item.fecharegistro;
            comando.Parameters["@pestado"].Value = item.estado;
            comando.Parameters["@pcodUsu"].Value = item.Usuario.codUsu;
            comando.Parameters["@pcodProy"].Value = item.Usuario.Proyecto.codProy;
            comando.Parameters["@pcomentarios"].Value = item.comentarios;
        }

        internal override int Registrar(SolicitudDineroEntity item, out int filasAfectadas)
        {
            nombreParametroRetorno = "@pdocEntry";
            return base.Registrar("VS_OOSD_RegMod", item, out filasAfectadas);
        }

        internal override int Modificar(SolicitudDineroEntity item, out int filasAfectadas)
        {
            nombreParametroRetorno = "@pdocEntry";
            return base.Modificar("VS_OOSD", item, out filasAfectadas);
        }

        //internal override SolicitudDineroEntity Detalle(int docEntry)
        //{
        //    return base.Detalle<SolicitudDineroPopulate>("VS_OOSD_Detalle", docEntry, "@pdocEntry");
        //}

        protected override void ConfigurarParametrosBuscar(DbCommand comando, SolicitudDineroEntity item)
        {
            comando.Parameters["@pcodigo"].Value = item.codigo;
            comando.Parameters["@pfecha"].Value = item.fecha;
            comando.Parameters["@pestado"].Value = item.estado;
            comando.Parameters["@pcodProy"].Value = item.Usuario.Proyecto.codProy;
        }

        internal override List<SolicitudDineroEntity> Buscar(SolicitudDineroEntity item, PaginadorEntity paginador)
        {
            return base.Buscar<SolicitudDineroPopulate>("VS_OOSD_Buscar", item, paginador);
        }
    }
}
