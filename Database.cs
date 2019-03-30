using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.OleDb;
using System.Data;

namespace ElevatorSystem
{
    class Database
    {
        public void elevatordown(DateTime Time, string Status,string Floor)
        {
            string sql = "INSERT INTO [Database]([Time],[Status],[Floor]) VALUES(@Time,@Status,@Floor)";
            OleDbCommand cmd = new OleDbCommand(sql, GlobalConnection.cn);
            cmd.Parameters.AddWithValue("@Time", DateTime.Now.ToLongTimeString());
            cmd.Parameters.AddWithValue("@Status",Status);
            cmd.Parameters.AddWithValue("@Floor", Floor);
            cmd.ExecuteNonQuery();
        }
       
        public DataTable View()
        {
            string sql = "SELECT ID,Time,Status,Floor FROM [Database]";
            OleDbDataAdapter da = new OleDbDataAdapter(sql, GlobalConnection.cn);
            DataSet ds = new DataSet();
            da.Fill(ds, "Database");
            return ds.Tables[0] ;
            
           
        }
       
         


    
    }
}
