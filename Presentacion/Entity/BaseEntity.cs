using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MISAP.Entity
{
    public class BaseEntity : IEntity
    {
        /// <summary>
        /// Obtiene o establece la cantidad de registros por página en resultados de búsqueda paginados.
        /// </summary>
        public int fila { get; set; }
        /// <summary>
        /// Obtiene o establece el usuario que realiza la operación.
        /// </summary>
        public UsuarioEntity Usuario { get; set; }

        /// <summary>
        /// Obtiene o establece los comentarios de la entidad.
        /// </summary>
        public string comentarios { get; set; }
    }
}
