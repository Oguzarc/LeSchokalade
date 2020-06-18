using System.Data.SqlClient;
using System.IO;

namespace LeSchokalade.Database
{
    class UserDatabase
    {
        DbConnection DbConnection = new DbConnection();
        private SqlCommand cmd;
        private SqlDataReader reader;
        private string select;
        public void Connection()
        {
            DbConnection.Connection();
        }
        public void checkUser(string nickname, string password)
        {        
            select = string.Format("select * from Personnel WHERE nickname='{0}' AND pass='{1}'", nickname, password);
            cmd = new SqlCommand(select, DbConnection.Mycon);      
        }
        public void Execute()
        {
            reader = cmd.ExecuteReader();
        }
        public bool GetUser()
        {
            bool ctrl = false;
            try
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        User.Session.Instance.user.Nickname = reader.GetValue(0).ToString();
                    }
                    ctrl = true;
                }
            }
            catch
            {
                ctrl = false;
            }
            return ctrl;
        }
        public void Close()
        {
            reader.Close();
            cmd.Dispose();
            DbConnection.Mycon.Close();
        }
    }
}
