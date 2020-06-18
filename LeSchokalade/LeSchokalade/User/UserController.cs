using System;
using LeSchokalade.Database;
namespace LeSchokalade.User
{
    class UserController
    {      
        public string checkUser(string nickname,string password)
        {
            string message = string.Empty;
            UserDatabase user = new UserDatabase();
            user.Connection();
            user.checkUser(nickname, password);
            user.Execute();
            bool control=user.GetUser();
            if (!control)
            {
                message = "Wrong identity!!";               
            }
            user.Close();
            return message;
        }       
    }
}
