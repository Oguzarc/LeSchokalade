using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace LeSchokalade.Database
{
    class DatabaseInsert
    {
        DbConnection dbConnec = new DbConnection();
        private SqlCommand cmd;
        private string insert;
        private double price;
        public void Connection()
        {
            dbConnec.Connection();
        }
        public void InsertOrders(string table,string product,double _price,int quantity)
        {
            price = _price;
            insert = "INSERT INTO Orders(_Table,Product,Price,Quantity) VALUES(' " + table + " ',' " + product + " ',@price,'"+ quantity +"')";
        }
        public void InsertTakeAway(string name, string product, double _price)
        {
            price = _price;
            insert = "INSERT INTO TakeAway(CustomerName,ProductName,Price) VALUES(' " + name + " ',' " + product + " ',@price)";
        }
        public void Execute()
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            cmd = new SqlCommand(insert, DbConnection.Mycon);
            cmd.Parameters.AddWithValue("@price", price);
            adapter.InsertCommand = cmd;
            adapter.InsertCommand.ExecuteNonQuery();
        }
        public void Close()
        {
            cmd.Dispose();
            DbConnection.Mycon.Close();
        }
    }
}
