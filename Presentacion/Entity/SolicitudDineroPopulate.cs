using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace MISAP.Entity
{
    internal class SolicitudDineroPopulate
      : BasePopulate
    {
        protected static new SolicitudDineroPopulate _instance = null;

        internal static new SolicitudDineroPopulate Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (padlock)
                    {
                        if (_instance == null) _instance = new SolicitudDineroPopulate();
                    }
                }
                return _instance;
            }
        }

        /// <summary>
        /// Devuelve una entidad creada desde un registro de datos.
        /// </summary>
        /// <param name="dr">registro de datos obtenido del origen de datos.</param>
        /// <returns>Entidad con los datos cargados.</returns>
        public SolicitudDineroEntity GetItem(IDataRecord dr)
        {
            SolicitudDineroEntity item = new SolicitudDineroEntity()
            {
                docEntry = (int)dr["docEntry"],
                codigo = dr["codigo"].ToString(),
                fecha = (DateTime)dr["fecha"],
                monto = (Decimal)dr["monto"],
                moneda = dr["moneda"].ToString(),
                motivo = dr["motivo"].ToString(),
                codEmp = dr["codEmp"].ToString(),
                nomEmp = dr["nomEmp"].ToString(),
                motAdicional = dr["motAdicional"].ToString(),
                fecharegistro = (DateTime)dr["fecharegistro"],
                estado = dr["estado"].ToString(),
                comentarios = dr["comentarios"].ToString()
            };
            item.Rendicion = new RendicionesEntity()
            {
                nroRen = dr["REnroRen"].ToString()
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
            else if (item.estado == "R")
                item.nomEstado = "Rechazado";
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
