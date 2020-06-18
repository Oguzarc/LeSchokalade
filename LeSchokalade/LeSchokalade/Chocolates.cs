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
    public partial class Chocolates : Form
    {
        public Chocolates()
        {
            InitializeComponent();
            SudeCombo.Items.Insert(0,"--Select--");
            SudeCombo.Items.Add("Tasting  250CC");
            SudeCombo.Items.Add("Filling  400CC");
            NerimanCombo.Items.Insert(0,"--Select--");
            NerimanCombo.Items.Add("Tasting  250CC");
            NerimanCombo.Items.Add("Filling  400CC");
            SudeCombo.SelectedIndex = 0;
            NerimanCombo.SelectedIndex = 0;
            SudeOrder.Text = "";
            NerimanOrder.Text = "";
            WaffleOrder.Text = "";
        }
        string Table = "1";       
        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked == true)
                Table = ((RadioButton)sender).Text;
        }
        
        private void SudeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SudeCombo.Text == "Tasting  250CC")
            {
                SudeOrder.Text = "";
                Baverages tasting = new LeShokaladeSude();
                tasting = new Tasting(tasting);              
                SudeOrder.Text = string.Format("Tasting Sude-${0}", tasting.GetPrice() * Convert.ToDouble(SudeUpDown.Value));
            }
            if(SudeCombo.Text == "Filling  400CC")
            {
                SudeOrder.Text = "";
                Baverages filling = new LeShokaladeSude();
                filling = new Filling(filling);
                SudeOrder.Text = string.Format("Filling Sude-${0}", filling.GetPrice() * Convert.ToDouble(SudeUpDown.Value));
            }
            if (SudeCombo.SelectedIndex == 0)
            {
                SudeOrder.Text = "";
            }
        }

        private void NerimanCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (NerimanCombo.Text == "Tasting  250CC")
            {
                NerimanOrder.Text ="";
                Baverages tasting = new LeShokaladeNeriman();
                tasting = new Tasting(tasting);               
                NerimanOrder.Text = string.Format("Tadimlik Neriman-${0}", tasting.GetPrice()* Convert.ToDouble(NerimanUpdown.Value));
            }
            if (NerimanCombo.Text == "Filling  400CC")
            {
                NerimanOrder.Text = "";
                Baverages filling = new LeShokaladeNeriman();
                filling = new Filling(filling);
                NerimanOrder.Text = string.Format("Filling Neriman-${0}", filling.GetPrice()* Convert.ToDouble(NerimanUpdown.Value));
            }
            if (NerimanCombo.SelectedIndex == 0)
            {
                NerimanOrder.Text = "";
            }
        }
        private void OrderBtn_Click(object sender, EventArgs e)
        {
            bool control = false;          
            if (SudeCombo.Text == "Tasting  250CC" )
            {
                Baverages tasting = new LeShokaladeSude();
                tasting = new Tasting(tasting);
                DatabaseInsert insert = new DatabaseInsert();
                insert.Connection();
                insert.InsertOrders(Table,"Tasting Sude",tasting.GetPrice()*Convert.ToDouble(SudeUpDown.Value), Convert.ToInt32(SudeUpDown.Value));             
                insert.Execute();
                insert.Close();
                control = true;
            }
            if (SudeCombo.Text == "Filling  400CC")
            {
                Baverages filling = new LeShokaladeSude();
                filling = new Filling(filling);
                DatabaseInsert insert = new DatabaseInsert();
                insert.Connection();
                insert.InsertOrders(Table, "Filling Sude", filling.GetPrice()* Convert.ToDouble(SudeUpDown.Value), Convert.ToInt32(SudeUpDown.Value));
                insert.Execute();
                insert.Close();
                control = true;
            }
            if (NerimanCombo.Text == "Tasting  250CC")
            {
                Baverages tasting = new LeShokaladeNeriman();
                tasting = new Tasting(tasting);
                DatabaseInsert insert = new DatabaseInsert();
                insert.Connection();
                insert.InsertOrders(Table, "Tasting Neriman", tasting.GetPrice()*Convert.ToDouble(NerimanUpdown.Value), Convert.ToInt32(NerimanUpdown.Value));
                insert.Execute();
                insert.Close();
                control = true;
            }
            if (NerimanCombo.Text == "Filling  400CC")
            {
                Baverages filling = new LeShokaladeNeriman();
                filling = new Filling(filling);
                DatabaseInsert insert = new DatabaseInsert();
                insert.Connection();
                insert.InsertOrders(Table, "Filling Neriman", filling.GetPrice()*Convert.ToDouble(NerimanUpdown.Value), Convert.ToInt32(NerimanUpdown.Value));
                insert.Execute();
                insert.Close();
                control = true;
            }
            if (WaffleCheck.Checked == true)
            {                        
                DatabaseInsert insert = new DatabaseInsert();
                insert.Connection();
                insert.InsertOrders(Table,"Waffle", 10 * Convert.ToInt32(WaffleUpDown.Value), Convert.ToInt32(WaffleUpDown.Value));             
                insert.Execute();
                insert.Close();
                control = true;
            }
            if (control)
            {
                MessageBox.Show("Your order has been received.","Thank You :)");
                SudeCombo.SelectedIndex = 0;
                NerimanCombo.SelectedIndex = 0;
                WaffleCheck.Checked = false;
            }
            else
            {
                MessageBox.Show("You did not choose any order!", "Warning!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private void SudeIng_CheckedChanged(object sender, EventArgs e)
        {
            if (SudeIng.Checked == true)
            {            
                SudeLabel.Visible = true;
                AbstractStore store = new LeShokaladeDukkan();
                SudeLabel.Text = store.OrderDessert("sude").Ingredients();
            }
            else
            {              
                 SudeLabel.Visible = false;           
            }
        }
        private void NerimanIng_CheckedChanged(object sender, EventArgs e)
        {
            if (NerimanIng.Checked == true)
            {              
                NerimanLabel.Visible = true; 
                AbstractStore store = new LeShokaladeDukkan();
                NerimanLabel.Text = store.OrderDessert("neriman").Ingredients();
            }
            else
            {
                NerimanLabel.Visible = false; 
            }
        }
        private void WaffleIng_CheckedChanged(object sender, EventArgs e)
        {
            if (WaffleIng.Checked == true)
            {          
                WaffleLabel.Visible = true;
                KlasikWaffle waffle = new KlasikWaffle();
                WaffleLabel.Text = "";
                WaffleLabel.Text += Convert.ToString(waffle.DoSpreading())+"\n"+ Convert.ToString(waffle.DoOrnaments()) + "\n"+
                Convert.ToString(waffle.DoFruit());            
            }
            else
            {
                WaffleLabel.Visible = false;           
            }
        }
        private void WaffleCheck_CheckedChanged(object sender, EventArgs e)
        {
            int price = 10;
            if (WaffleCheck.Checked == true)
            {            
                WaffleOrder.Text = string.Format("Waffle - ${0}",price* WaffleUpDown.Value);
            }
            else
            {
                WaffleOrder.Text = "";
            }
        }

        private void UpDown_ValueChanged(object sender, EventArgs e)
        {
            string numaric;           
            numaric =((NumericUpDown)sender).Name;
            if (numaric.Equals("SudeUpDown"))
            {
                int index = SudeCombo.SelectedIndex;
                SudeCombo.SelectedIndex =0;
                SudeCombo.SelectedIndex = index;
            }
            if (numaric.Equals("NerimanUpdown"))
            {
                int index = NerimanCombo.SelectedIndex;
                NerimanCombo.SelectedIndex = 0;
                NerimanCombo.SelectedIndex = index;
            }
            if (numaric.Equals("WaffleUpDown"))
            {
                if (WaffleCheck.Checked)
                {
                    WaffleCheck.Checked = false;
                    WaffleCheck.Checked = true;
                }
            }
        }
    }
}
