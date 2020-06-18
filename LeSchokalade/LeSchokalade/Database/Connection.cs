using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeSchokalade.Database
{   
    public class DbConnection
    {
        public static SqlConnection Mycon { get; set; }
        public void Connection()
        {              
            Mycon = new SqlConnection("Data Source=USER-BILGISAYAR\\MSSQLSERVERR;Initial Catalog=deneme;Integrated Security=True");
            Mycon.Open();              
        }
    }
}
