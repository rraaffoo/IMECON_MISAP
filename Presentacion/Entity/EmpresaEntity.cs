using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MISAP.Entity
{
    public class EmpresaEntity : ConfiguracionBaseEntity
    {
        public int id { get; set; }
        public String ruc { get; set; }
        public String nombre { get; set; }
        private byte[] _licencia { get; set; }
        public byte[] licencia() { return _licencia; }
        public void setlicencia(byte[] value) { _licencia = value; }
        public Boolean estado { get; set; }

        #region Temporales
        public int cantidadTotal { get; set; }
        public int cantidadDisponible { get; set; }
        #endregion
    }
}
