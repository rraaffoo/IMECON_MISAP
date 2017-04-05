using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MISAP.Entity
{
    public class UsuarioEntity : ConfiguracionBaseEntity
    {
        public string codUsu { get; set; }
        public string nomUsu { get; set; }
        public string correo { get; set; }
        public string estado { get; set; }
        public ProyectoEntity Proyecto { get; set; }
        public bool isAdmin { get; set; }
        public bool licenciado { get; set; }

        #region Temporal
        public string nomEstado { get; set; }
        public EmpresaEntity Empresa { get; set; }

        /// <summary>
        /// Contiene las dimensiones, normas de reparto y centros de costos.
        /// </summary>
        public List<DimensionEntity> Dimensiones { get; set; }

        /// <summary>
        /// Representa el empleado asociado del usuario del sistema.
        /// </summary>
        public EmpleadoEntity Empleado { get; set; }
        #endregion
    }
}
