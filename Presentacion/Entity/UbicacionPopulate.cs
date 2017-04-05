using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace MISAP.Entity
{
    internal class UbicacionPopulate
      : BasePopulate
    {
        protected static new UbicacionPopulate _instance = null;

        internal static new UbicacionPopulate Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (padlock)
                    {
                        if (_instance == null)
                            _instance = new UbicacionPopulate();
                    }
                }
                return _instance;
            }
        }

        public UbicacionEntity GetItem(IDataRecord dr)
        {
            UbicacionEntity item = new UbicacionEntity()
            {
                idUbicacion = (int)dr["idUbicacion"],
                nomUbicacion = dr["nomUbicacion"].ToString()
            };

            return item;
        }
    }
}
