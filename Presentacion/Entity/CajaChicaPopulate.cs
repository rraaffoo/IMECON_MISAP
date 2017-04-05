using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace MISAP.Entity
{
    internal class CajaChicaPopulate
      : BasePopulate
    {
        protected static new CajaChicaPopulate _instance = null;

        internal static new CajaChicaPopulate Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (padlock)
                    {
                        if (_instance == null)
                            _instance = new CajaChicaPopulate();
                    }
                }
                return _instance;
            }
        }

        public CajaChicaEntity GetItem(IDataRecord dr)
        {
            CajaChicaEntity item = new CajaChicaEntity()
            {
                docEntry = (int)dr["docEntry"],
                nroCC = dr["nroCC"].ToString(),
                nroOT = dr["nroOT"].ToString(),
                codProy = dr["codProy"].ToString(),
                totalCaja = (decimal)dr["totalCaja"],
                moneda = dr["moneda"].ToString(),
                fechaCierre = (DateTime)dr["fechaCierre"],
                aprob = dr["aprob"].ToString(),
                estado = dr["estado"].ToString(),
                monto = (decimal)dr["monto"],
                importeTotal = (decimal)dr["importeTotal"],
                saldo = (decimal)dr["saldo"],
                comentarios = dr["comentarios"].ToString()
            };
            item.setidCC(dr["idCC"].ToString());
            item.setcorrelativoCC(dr["correlativoCC"].ToString());
            item.setTiempoFecha((Boolean)dr["tiempoFecha"]);
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
