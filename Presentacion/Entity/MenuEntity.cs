using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MISAP.Entity
{
    public class MenuEntity : SeguridadBaseEntity
    {
        public String codMenu { get; set; }
        public String nomMenu { get; set; }
        public int nivel { get; set; }
        public int orden { get; set; }
        public String ruta { get; set; }
        public String estado { get; set; }
        public MenuEntity Menu { get; set; }
        public List<MenuEntity> Menus { get; set; }
        public String rutaLogo { get; set; }

        #region Temporales
        public String nomEstado { get; set; }
        public MenuEntity Padre { get; set; }
        public List<MenuEntity> Hijos { get; set; }
        #endregion
    }
}
