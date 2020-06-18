using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LeSchokalade.Database;
using LeSchokalade.User;
namespace LeSchokalade
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void LogBTN_Click(object sender, EventArgs e)
        {
            UserController user = new UserController();
            string test = user.checkUser(NickName.Text,pass.Text);
            if (string.IsNullOrEmpty(test))
            {
                Personnel personnel = new Personnel();
                personnel.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show(test);
            }
        }
    }
}
