using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
namespace LeSchokalade.Database
{
    class DatabaseSelect
    {
        DbConnection DbConnection = new DbConnection();
        private SqlCommand cmd;
        private SqlDataReader reader;
        private string output,output1;
        private string select;
        public void Connection()
        {
            DbConnection.Connection();
        }

        public void CommandOrders(string _table)
        {
            select = string.Format("select * from ORDERS WHERE _Table={0} AND Activity=1",_table);
            cmd = new SqlCommand(select, DbConnection.Mycon);
        }
        public void CommandTakeAway(string _name)
        {
            select = string.Format("select ProductName,CustomerName from TakeAway WHERE CustomerName=' {0} ' AND Activty=1", _name);
            cmd = new SqlCommand(select, DbConnection.Mycon);
        }
        public void CommandTotal(string _name)
        {
            select = string.Format("select CustomerName,Sum(Price)TotalPrice from TakeAway WHERE CustomerName=' {0} ' Group by CustomerName", _name);
            cmd = new SqlCommand(select, DbConnection.Mycon);
        }
        public void Execute()
        {
            reader = cmd.ExecuteReader();       
        }
        public string ShowProduct()
        {
            while (reader.Read())
            {
                output = output + reader.GetValue(0)+"---"+ reader.GetValue(1) + "\n";
            }
            return output;
        }
        public string ShowPrice()
        {
            while (reader.Read())
            {               
                output1 = output1 + reader.GetValue(0) + reader.GetValue(1) + "\n";
            }
            return output1;
        }
        public void Close()
        {
            reader.Close();
            cmd.Dispose();
            DbConnection.Mycon.Close();
        }
    }
}
