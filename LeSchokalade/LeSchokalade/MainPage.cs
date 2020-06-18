using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LeSchokalade
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void BeveragesBtn_Click(object sender, EventArgs e)
        {
            panel4.Controls.Clear();
            FormBaverages form = new FormBaverages();
            form.TopLevel = false;
            panel4.Controls.Add(form);
            form.Show();
            form.Dock = DockStyle.Fill;
            form.BringToFront();
        }
             
        private void Staff_Click(object sender, EventArgs e)
        {
            if (!User.Session.Instance.logged)
            {
                if ((Application.OpenForms["Login"] as Login) != null)
                {
                    MessageBox.Show("Already Opened", "Warning!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Login login = new Login();
                    login.Show();
                    login.BringToFront();
                }
            }
            else
            {
                if ((Application.OpenForms["Personnel"] as Personnel) != null)
                {
                    MessageBox.Show("Already Opened", "Warning!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Personnel personnel = new Personnel();
                    personnel.Show();
                    personnel.BringToFront();
                }
            }
        }
        private void TakeAwayBtn_Click(object sender, EventArgs e)
        {
            panel4.Controls.Clear();
            TakeAway takeAway = new TakeAway();
            takeAway.TopLevel = false;
            panel4.Controls.Add(takeAway);
            takeAway.Show();
            takeAway.Dock = DockStyle.Fill;
            takeAway.BringToFront();        
        }

        private void MainBtn_Click(object sender, EventArgs e)
        {
            panel4.Controls.Clear();
            MainPanel main = new MainPanel();
            main.TopLevel = false;
            panel4.Controls.Add(main);
            main.Show();
            main.Dock = DockStyle.Fill;
            main.BringToFront();
        }

        private void ChocolatesBtn_Click(object sender, EventArgs e)
        {
            panel4.Controls.Clear();
            Chocolates chocolates = new Chocolates();
            chocolates.TopLevel = false;
            panel4.Controls.Add(chocolates);
            chocolates.Show();
            chocolates.Dock = DockStyle.Fill;
            chocolates.BringToFront();
        }
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms["Auth"] as Auth) != null)
            {
                MessageBox.Show("Already Opened", "Warning!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Auth auth = new Auth();
                auth.Show();
                auth.BringToFront();
            }
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            timer1.Start();
            Date.Text = DateTime.Now.ToShortDateString();
            Time.Text = DateTime.Now.ToLongTimeString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Time.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void About_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }
    }
}
