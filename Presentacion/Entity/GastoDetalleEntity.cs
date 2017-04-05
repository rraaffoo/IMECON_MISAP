using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MISAP.Entity
{
    public class GastoDetalleEntity
      : TesoreriaBaseEntity
    {
        public int docEntry { get; set; }
        public int lineId { get; set; }
        public String codArt { get; set; }
        public String desArt { get; set; }
        public String undMed { get; set; }
        public Decimal cant { get; set; }
        public Decimal precio { get; set; }
        public String cuentadestino { get; set; }
        public GastoEntity Gasto { get; set; }

        public string codProy { get; set; }
        public string nroOT { get; set; }

        public String codCentroCosto1 { get; set; }
        public String nomCentroCosto1 { get; set; }
        public String codCentroCosto2 { get; set; }
        public String nomCentroCosto2 { get; set; }
        public String codCentroCosto3 { get; set; }
        public String nomCentroCosto3 { get; set; }
        public String codCentroCosto4 { get; set; }
        public String nomCentroCosto4 { get; set; }
        public String codCentroCosto5 { get; set; }
        public String nomCentroCosto5 { get; set; }
    }
}
