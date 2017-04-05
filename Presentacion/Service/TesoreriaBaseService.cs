using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MISAP.Entity;
using MISAP.Repository;

namespace MISAP.Service
{
    public class TesoreriaBaseService<TEntity> : MaestroService<TEntity> where TEntity : TesoreriaBaseEntity, new()
    {
        internal TesoreriaBaseService(BaseRepository<TEntity> repositorio)
            : base(repositorio)
        {
        }
    }
}
