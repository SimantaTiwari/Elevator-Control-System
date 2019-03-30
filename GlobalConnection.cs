using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.OleDb;
using System.Data;

namespace ElevatorSystem
{
    class GlobalConnection
    {
        public static OleDbConnection cn;
        public static void DbConnection()
        {
            cn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database.mdb");
            cn.Open();
        }
    }
}
