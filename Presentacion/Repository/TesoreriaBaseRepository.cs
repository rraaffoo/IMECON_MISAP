using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MISAP.Entity;

namespace MISAP.Repository
{
    internal class TesoreriaBaseRepository<TEntity>
      : BaseRepository<TEntity>
      where TEntity : TesoreriaBaseEntity, new()
    {
    }
}
