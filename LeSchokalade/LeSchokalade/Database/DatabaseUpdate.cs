using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace LeSchokalade.Database
{
    
    class DatabaseUpdate
    {
        DbConnection dbConnec = new DbConnection();        
        private SqlCommand cmd;
        SqlDataAdapter adapter = new SqlDataAdapter();
        int id;
        public void Connection()
        {
            dbConnec.Connection();          
        }
        public void Command(int _id)
        {
            id = _id;
            cmd = new SqlCommand("update ORDERS set Activity=0 where ID=@id", DbConnection.Mycon);
            cmd.Parameters.AddWithValue("@id", id);
        }
        public void CommandInactive(int _id)
        {
            id = _id;
            cmd = new SqlCommand("update ORDERS set isPrint=0 where ID=@id", DbConnection.Mycon);
            cmd.Parameters.AddWithValue("@id", id);
        }
        public void CommandTake(int _id)
        {
            id = _id;
            cmd = new SqlCommand("update TakeAway set Activty=0 where ID=@id", DbConnection.Mycon);
            cmd.Parameters.AddWithValue("@id", id);
        }
        public void Execute()
        {              
            adapter.UpdateCommand = cmd;
            adapter.UpdateCommand.ExecuteNonQuery();            
        }       
        public void Close()
        {           
            cmd.Dispose();
            DbConnection.Mycon.Close();
        }
    }
}
