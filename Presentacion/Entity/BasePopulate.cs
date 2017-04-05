using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace MISAP.Entity
{
    internal partial class BasePopulate : IPopulate
    {
        protected static volatile BasePopulate _instance = null;
        protected static readonly object padlock = new object();

        protected BasePopulate()
        {
        }

        internal static BasePopulate Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (padlock)
                    {
                        if (_instance == null)
                            _instance = new BasePopulate();
                    }
                }

                return _instance;
            }
        }

        internal virtual T GetItem<T>(IDataRecord dr) where T : BaseEntity, new()
        {
            T item = new T();
            this.GetItem(dr, item);
            return item;
        }

        protected void GetItem(IDataRecord dr, BaseEntity item, string id = "Id", string nombre = "Nombre", string codigo = "Codigo", string descripcion = "Descripcion", string observacion = "Observacion", string estado = "Estado")
        {
        }

        protected void GetItemWithTable(IDataRecord dr, BaseEntity item, string tabla, string id = "Id", string nombre = "Nombre", string codigo = "Codigo", string descripcion = "Descripcion", string observacion = "Observacion", string estado = "Estado")
        {
            this.GetItem(dr, item, tabla + id, tabla + nombre, tabla + codigo, tabla + descripcion, tabla + observacion, tabla + estado);
        }

        internal virtual T GetItem<T>(DataRow dr) where T : BaseEntity, new()
        {
            T item = new T();
            this.GetItem(dr, item);
            return item;
        }

        protected void GetItem(DataRow dr, BaseEntity item, string id = "Id", string nombre = "Nombre", string codigo = "Codigo", string descripcion = "Descripcion", string observacion = "Observacion", string estado = "Estado")
        {
        }

        protected void GetItemWithTable(DataRow dr, BaseEntity item, string tabla, string id = "Id", string nombre = "Nombre", string codigo = "Codigo", string descripcion = "Descripcion", string observacion = "Observacion", string estado = "Estado")
        {
            this.GetItem(dr, item, tabla + id, tabla + nombre, tabla + codigo, tabla + descripcion, tabla + observacion, tabla + estado);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
