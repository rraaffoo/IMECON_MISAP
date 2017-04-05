using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MISAP.Entity
{
    public class NormaRepartoEntity
    {
        public string codigo { get; set; }
        public string nombre { get; set; }
        public int dimensionId { get; set; }

        public List<NormaRepartoCostosEntity> DistCCostos { get; set; }

        public override string ToString()
        {
            return String.Format("{0}, {1}", codigo, nombre);
        }
    }

    public class NormaRepartoCostosEntity
    {
        //public string NrepartoId { get; set; }
        public string CCostoId { get; set; }
        public decimal porcentaje { get; set; }
        public decimal total { get; set; }

        public override string ToString()
        {
            return String.Format("{0}, {1} %", CCostoId, porcentaje);
        }
    }
}
