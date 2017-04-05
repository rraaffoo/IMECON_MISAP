using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MISAP.Entity
{
    public class RolEntity : SeguridadBaseEntity
    {
        public String codRol { get; set; }
        public String nomRol { get; set; }
        public String estado { get; set; }
        public Boolean isContab { get; set; }
        public Boolean isAdmin { get; set; }
        public Boolean isSupervisor { get; set; }
        public MenuEntity Menu { get; set; }
        public List<MenuEntity> Menus { get; set; }

        #region Temporales
        public String nomEstado { get; set; }
        #endregion
    }
}
