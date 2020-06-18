using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LeSchokalade.DesignPatterns;

namespace LeSchokalade
{
    public partial class Auth : Form
    {
        public Auth()
        {
            InitializeComponent();
        }
     
        private void button1_Click(object sender, EventArgs e)
        {
            string entrypass;
            Singleton pass = Singleton.GiveObj();
            pass.ConfigPass(1234);
            string calc = pass.Compare().ToString();
            entrypass = textBox1.Text;
            if (calc == entrypass)
            {
                Application.Exit();              
            }       
            else
            {
                MessageBox.Show("wrong password!!!");
            }          
        }
    }
}
