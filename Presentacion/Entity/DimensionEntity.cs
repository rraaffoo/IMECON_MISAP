using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MISAP.Entity
{
    public class DimensionEntity
    {
        public int codigo { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }

        public List<CCostoEntity> CCostos { get; set; }
        public List<NormaRepartoEntity> NRepartos { get; set; }

        public override string ToString()
        {
            return String.Format("{0}, {1}", codigo, nombre);
        }
    }
}
