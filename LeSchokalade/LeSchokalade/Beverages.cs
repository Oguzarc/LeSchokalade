using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LeSchokalade.Database;
using LeSchokalade.DesignPatterns;
namespace LeSchokalade
{
    public partial class FormBaverages : Form
    {
        public FormBaverages()
        {
            InitializeComponent();
            LemonadeOrder.Text = "";
            AmericanoOrder.Text = "";
            TCoffeOrder.Text = "";
        }
        string Table = "1";
        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked == true)
                Table = ((RadioButton)sender).Text;
        }
        private void Order_Click(object sender, EventArgs e)
        {
            bool control=false;            
            if (LemonCheck.Checked)
            {
                Baverages bev = new Lemonade();                          
                DatabaseInsert insert = new DatabaseInsert();
                insert.Connection();
                insert.InsertOrders(Table, bev.GetDescription(), bev.GetPrice()* Convert.ToDouble(LemonUpDown.Value),Convert.ToInt32(LemonUpDown.Value));
                insert.Execute();
                insert.Close();
                control = true;
            }
            if(AmericanoCheck.Checked)
            {
                if (NormalAmericano.Checked)
                {
                    Baverages bev = new Americano();
                    DatabaseInsert insert = new DatabaseInsert();
                    insert.Connection();
                    insert.InsertOrders(Table, bev.GetDescription(), bev.GetPrice()* Convert.ToDouble(AmericanoUpDown.Value), Convert.ToInt32(AmericanoUpDown.Value));
                    insert.Execute();
                    insert.Close();
                    control = true;
                }
                if (ExtraAmericano.Checked)
                {
                    Baverages bev = new Americano();
                    bev = new Milk(bev);
                    DatabaseInsert insert = new DatabaseInsert();
                    insert.Connection();
                    insert.InsertOrders(Table, bev.GetDescription(), bev.GetPrice()* Convert.ToDouble(AmericanoUpDown.Value), Convert.ToInt32(AmericanoUpDown.Value));
                    insert.Execute();
                    insert.Close();
                    control = true;
                }                                     
            }
            if (TCoffeeCheck.Checked)
            {
                if (SugarFree.Checked)
                {
                    Baverages bev = new TurkishCoffee();
                    bev = new SugarFree(bev);
                    DatabaseInsert insert = new DatabaseInsert();
                    insert.Connection();
                    insert.InsertOrders(Table, bev.GetDescription(), bev.GetPrice()* Convert.ToDouble(TCoffeeUpDown.Value), Convert.ToInt32(TCoffeeUpDown.Value));
                    insert.Execute();
                    insert.Close();
                    control = true;
                }
                if (MidSugar.Checked)
                {
                    Baverages bev = new TurkishCoffee();
                    bev = new MidSugar(bev);
                    DatabaseInsert insert = new DatabaseInsert();
                    insert.Connection();
                    insert.InsertOrders(Table, bev.GetDescription(), bev.GetPrice()* Convert.ToDouble(TCoffeeUpDown.Value), Convert.ToInt32(TCoffeeUpDown.Value));
                    insert.Execute();
                    insert.Close();
                    control = true;
                }
                if (Sugary.Checked)
                {
                    Baverages bev = new TurkishCoffee();
                    bev = new Sugary(bev);
                    DatabaseInsert insert = new DatabaseInsert();
                    insert.Connection();
                    insert.InsertOrders(Table, bev.GetDescription(), bev.GetPrice()* Convert.ToDouble(TCoffeeUpDown.Value), Convert.ToInt32(TCoffeeUpDown.Value));
                    insert.Execute();
                    insert.Close();
                    control = true;
                }             
            }
            if (control)
            {
                MessageBox.Show("Your order has been received.");
                LemonCheck.Checked = false;
                AmericanoCheck.Checked = false;
                TCoffeeCheck.Checked = false;
        
            }
            else
            {
                MessageBox.Show("You did not choose any order!", "Warning!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        string rAmericano="";
        private void AmericanoRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked == true)
                rAmericano = ((RadioButton)sender).Name;
            if (rAmericano == "NormalAmericano")
            {
                Baverages bev = new Americano();
                string x =
                    string.Format("{0} - ${1}",
                        bev.GetDescription(),
                        bev.GetPrice() * Convert.ToDouble(AmericanoUpDown.Value));
                AmericanoOrder.Text = x;
            }
            if(rAmericano== "ExtraAmericano")
            {
                Baverages bev = new Americano();
                bev = new Milk(bev);
                string x =
                    string.Format("{0} - ${1}",
                     bev.GetDescription(),
                        bev.GetPrice() * Convert.ToDouble(AmericanoUpDown.Value));
                AmericanoOrder.Text = x;
            }
        }
        string rTCoffee = "";
        private void TCoffeeRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked == true)
                rTCoffee = ((RadioButton)sender).Name;
            if(rTCoffee== "SugarFree")
            {
                Baverages bev = new TurkishCoffee();
                bev = new SugarFree(bev);
                string x =
                    string.Format("{0} - ${1}",
                        bev.GetDescription(),
                        bev.GetPrice() * Convert.ToDouble(TCoffeeUpDown.Value));
                TCoffeOrder.Text = x;
            }
            if(rTCoffee== "MidSugar")
            {
                Baverages bev = new TurkishCoffee();
                bev = new MidSugar(bev);
                string x =
                    string.Format("{0} - ${1}",
                        bev.GetDescription(),
                        bev.GetPrice() * Convert.ToDouble(TCoffeeUpDown.Value));
                TCoffeOrder.Text = x;
            }
            if (rTCoffee == "Sugary")
            {
                Baverages bev = new TurkishCoffee();
                bev = new Sugary(bev);
                string x =
                    string.Format("{0} - ${1}",
                        bev.GetDescription(),
                        bev.GetPrice() * Convert.ToDouble(TCoffeeUpDown.Value));
                TCoffeOrder.Text = x;
            }
        }
         private void LemonCheck_CheckedChanged(object sender, EventArgs e)
         {
             if (LemonCheck.Checked == true)
             {
                 Baverages bev = new Lemonade();
                 string x =
                     string.Format("{0} - ${1}",
                         bev.GetDescription(),
                         bev.GetPrice()*Convert.ToDouble(LemonUpDown.Value));
                 LemonadeOrder.Text = x;
             }
             else
             {
                 LemonadeOrder.Text = "";
             }
         }

         private void AmericanoCheck_CheckedChanged(object sender, EventArgs e)
         {
             if (AmericanoCheck.Checked == true)         
             {
                 AmericanoFlowPanel.Visible = true;             
             }
             else
             {
                 AmericanoFlowPanel.Visible = false;
                 NormalAmericano.Checked = false;
                 ExtraAmericano.Checked = false;
                 AmericanoOrder.Text = "";
             }
         }

         private void TCoffeeCheck_CheckedChanged(object sender, EventArgs e)
         {
             if (TCoffeeCheck.Checked == true)
             {
                 TCoffeeFlowPanel.Visible = true;             
             }
             else
             {
                 TCoffeeFlowPanel.Visible = false;
                 SugarFree.Checked = false;
                 MidSugar.Checked = false;
                 Sugary.Checked = false;
                 TCoffeOrder.Text = "";
             }
         }
        private void UpDown_ValueChanged(object sender, EventArgs e)
        {
            string numaric;
            numaric = ((NumericUpDown)sender).Name;
            if (numaric.Equals("LemonUpDown"))
            {
                if (LemonCheck.Checked)
                {
                    LemonCheck.Checked = false;
                    LemonCheck.Checked = true;
                }
            }
            if (numaric.Equals("AmericanoUpDown"))
            {
                if (AmericanoCheck.Checked)
                {
                    if (rAmericano == "NormalAmericano")
                    {
                        NormalAmericano.Checked = false;
                        NormalAmericano.Checked = true;
                    }
                    if (rAmericano == "ExtraAmericano")
                    {
                        ExtraAmericano.Checked = false;
                        ExtraAmericano.Checked = true;
                    }
                }
            }
            if (numaric.Equals("TCoffeeUpDown"))
            {
                if (TCoffeeCheck.Checked)
                {
                    if (rTCoffee == "SugarFree")
                    {
                        SugarFree.Checked = false;
                        SugarFree.Checked = true;
                    }
                    if (rTCoffee == "MidSugar")
                    {
                        MidSugar.Checked = false;
                        MidSugar.Checked = true;
                    }
                    if (rTCoffee == "Sugary")
                    {
                        Sugary.Checked = false;
                        Sugary.Checked = true;
                    }
                }
            }
        }
    }
}
