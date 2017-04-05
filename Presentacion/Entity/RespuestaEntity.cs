using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MISAP.Entity
{
    public class RespuestaEntity
    {
        public RespuestaEntity()
        {
            this.success = true;
        }

        public String extra { get; set; }

        private String _mensaje;

        public String message { get { return (!String.IsNullOrEmpty(_mensaje) ? _mensaje.Replace("\r", String.Empty).Replace("\n", String.Empty) : String.Empty); } set { _mensaje = value; } }

        public virtual bool success { get; set; }

        #region Métodos
        public void SetMessage(Exception ex)
        {
            success = false;
            message = ex.Message + (ex.InnerException != null ? Environment.NewLine + (ex.InnerException.Message ?? "") : String.Empty);
        }

        public void SetMessage(String message)
        {
            this.message = message;
        }

        public void SetMessage(params string[] messages)
        {
            foreach (string message in messages)
            {
                this.message += (message + Environment.NewLine);
            }
        }
        #endregion
    }

    public sealed class RespuestaEntity<T>
       : RespuestaEntity
    {
        private bool _success;

        public override bool success
        {
            get { if ((items != null && items.Count > 0) || items != null || item != null) return true; else return false; }
            set { _success = value; }
        }

        public T item { get; set; }

        public List<T> items { get; set; }

        public int total
        {
            get { return (items == null || items.Count == 0) ? 0 : items.Count; }
            set { }
        }
    }
}
