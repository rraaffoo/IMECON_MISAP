using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace MISAP.Entity
{
    public sealed class DatabaseHelper
    {
        public static Database GetDatabase()
        {
            Database db = DatabaseFactory.CreateDatabase("conn");
            return db;
        }
    }
}
