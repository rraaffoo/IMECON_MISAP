using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace MISAP.Entity
{
    internal class ProyectoPopulate
      : BasePopulate
    {
        protected static new ProyectoPopulate _instance = null;

        internal static new ProyectoPopulate Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (padlock)
                    {
                        if (_instance == null)
                            _instance = new ProyectoPopulate();
                    }
                }
                return _instance;
            }
        }

        public ProyectoEntity GetItem(IDataRecord dr)
        {
            ProyectoEntity item = new ProyectoEntity()
            {
                codProy = dr["codProy"].ToString(),
                nomProy = dr["nomProy"].ToString(),
                nroOT = dr["nroOT"].ToString(),
                estado = dr["estado"].ToString(),
                codAlm = dr["codAlm"].ToString(),
                nomAlm = dr["nomAlm"].ToString(),
                idUbicacion = (int)dr["idUbicacion"],
                nomUbicacion = dr["nomUbicacion"].ToString(),
                totalCaja = (decimal)dr["totalCaja"],
                moneda = dr["moneda"].ToString(),
                comentarios = dr["comentarios"].ToString(),

                // its - Joseph 
                //codCentroCosto1 = dr.GetStringbyName("codCentroCosto1"),
                //nomCentroCosto1 = dr.GetStringbyName("nomCentroCosto1"),
                //codCentroCosto2 = dr.GetStringbyName("codCentroCosto2"),
                //nomCentroCosto2 = dr.GetStringbyName("nomCentroCosto2"),
                //codCentroCosto3 = dr.GetStringbyName("codCentroCosto3"),
                //nomCentroCosto3 = dr.GetStringbyName("nomCentroCosto3"),
                //codCentroCosto4 = dr.GetStringbyName("codCentroCosto4"),
                //nomCentroCosto4 = dr.GetStringbyName("nomCentroCosto4"),
                //codCentroCosto5 = dr.GetStringbyName("codCentroCosto5"),
                //nomCentroCosto5 = dr.GetStringbyName("nomCentroCosto5"),
            };
            item.Cuenta = new CuentaEntity()
            {
                codigo = dr["codCuenta"].ToString(),
                nombre = dr["nomCuenta"].ToString()
            };
            item.CuentaRendicion = new CuentaEntity()
            {
                codigo = dr["codCuentaRendicion"].ToString(),
                nombre = dr["nomCuentaRendicion"].ToString()
            };
            item.Rol = new RolEntity()
            {
                id = (int)dr["idRO"],
                codRol = dr["codRolRO"].ToString(),
                nomRol = dr["nomRolRO"].ToString(),
                estado = dr["estadoRO"].ToString(),
                isContab = (Boolean)dr["isContabRO"],
                isAdmin = (Boolean)dr["isAdminRO"],
                isSupervisor = (Boolean)dr["isSupervisorRO"]
            };
            if (item.Rol.id == 0)
                item.Rol = null;

            if (item.moneda == "SOL")
                item.nomMoneda = "Nuevos Soles";
            else if (item.moneda == "USD")
                item.nomMoneda = "Dólares Americanos";

            if (item.estado == "A")
                item.nomEstado = "Activo";
            else if (item.estado == "I")
                item.nomEstado = "Inactivo";

            return item;
        }
    }
}
