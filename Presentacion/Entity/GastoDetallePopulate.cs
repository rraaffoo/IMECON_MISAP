using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace MISAP.Entity
{
    internal class GastoDetallePopulate
      : BasePopulate
    {
        protected static new GastoDetallePopulate _instance = null;

        internal static new GastoDetallePopulate Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (padlock)
                    {
                        if (_instance == null)
                            _instance = new GastoDetallePopulate();
                    }
                }
                return _instance;
            }
        }

        public GastoDetalleEntity GetItem(IDataRecord dr)
        {
            GastoDetalleEntity item = new GastoDetalleEntity()
            {
                nroOT = dr["nroOT"].ToString(),
                codProy = dr["codProy"].ToString(),
                docEntry = (int)dr["docEntry"],
                lineId = (int)dr["lineId"],
                codArt = dr["codArt"].ToString(),
                desArt = dr["desArt"].ToString(),
                undMed = dr["undMed"].ToString(),
                cant = (decimal)dr["cant"],
                precio = (decimal)dr["precio"],
                cuentadestino = dr["cuentadestino"].ToString(),
                codCentroCosto1 = dr["codCentroCosto1"].ToString(),
                nomCentroCosto1 = dr["nomCentroCosto1"].ToString(),
                codCentroCosto2 = dr["codCentroCosto2"].ToString(),
                nomCentroCosto2 = dr["nomCentroCosto2"].ToString(),
                codCentroCosto3 = dr["codCentroCosto3"].ToString(),
                nomCentroCosto3 = dr["nomCentroCosto3"].ToString(),
                codCentroCosto4 = dr["codCentroCosto4"].ToString(),
                nomCentroCosto4 = dr["nomCentroCosto4"].ToString(),
                codCentroCosto5 = dr["codCentroCosto5"].ToString(),
                nomCentroCosto5 = dr["nomCentroCosto5"].ToString()
            };

            item.Gasto = new GastoEntity()
            {
                docEntry = (int)dr["docEntryGC"]
            };

            return item;
        }
    }
}
