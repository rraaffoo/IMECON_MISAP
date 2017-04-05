using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace MISAP.Entity
{
    internal class RendicionesPopulate : BasePopulate
    {
        protected static new RendicionesPopulate _instance = null;

        internal static new RendicionesPopulate Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (padlock)
                    {
                        if (_instance == null) _instance = new RendicionesPopulate();
                    }
                }
                return _instance;
            }
        }

        public RendicionesEntity GetItem(IDataRecord dr)
        {
            RendicionesEntity item = new RendicionesEntity()
            {
                nroRen = dr["nroRen"].ToString(),
                docEntry = (int)dr["docEntry"],
                codEmp = dr["codEmp"].ToString(),
                nomEmp = dr["nomEmp"].ToString(),
                nroOT = dr["nroOT"].ToString(),
                fecha = (DateTime)dr["fecha"],
                aprob = dr["aprob"].ToString(),
                estado = dr["estado"].ToString(),
                moneda = dr["moneda"].ToString(),
                monto = (decimal)dr["monto"],
                importeTotal = (decimal)dr["importeTotal"],
                saldo = (decimal)dr["saldo"],
                comentarios = dr["comentarios"].ToString()
            };
            item.SolicitudDinero = new SolicitudDineroEntity()
            {
                docEntry = (int)dr["SDdocEntry"],
                codigo = dr["SDcodigo"].ToString()
            };
            item.Usuario = new UsuarioEntity()
            {
                codUsu = dr["codUsuUS"].ToString(),
                nomUsu = dr["nomUsuUS"].ToString()
            };
            item.Usuario.Proyecto = new ProyectoEntity()
            {
                codProy = dr["codProyPR"].ToString(),
                nomProy = dr["nomProyPR"].ToString()
            };

            if (item.estado == "P")
                item.nomEstado = "Pendiente";
            else if (item.estado == "C")
                item.nomEstado = "Cerrado";
            else if (item.estado == "N")
                item.nomEstado = "Anulado";

            if (item.moneda == "SOL")
                item.nomMoneda = "Nuevos Soles";
            else if (item.moneda == "USD")
                item.nomMoneda = "Dólares Americanos";

            return item;
        }
    }
}
