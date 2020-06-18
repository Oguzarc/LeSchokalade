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
    public partial class TakeAway : Form
    {
        public TakeAway()
        {
            InitializeComponent();
            Box.Text = " ";
        }       
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Orders.Text = " ";
            foreach(string secilen in ProductList.CheckedItems)
            {
                Orders.Text += secilen + ",\n";
            }
        }
        private void GiveOrder_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Customer.Text))
            {
                MessageBox.Show("Please specify a name!", "Warning!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                bool control = false;
                foreach (string choice in ProductList.CheckedItems)
                {
                    string CustomerSent = Customer.Text;
                    if (choice == "TastingSude")
                    {
                        Baverages tasting = new LeShokaladeSude();
                        tasting = new Tasting(tasting);
                        DatabaseInsert insert = new DatabaseInsert();
                        insert.Connection();
                        insert.InsertTakeAway(CustomerSent, choice, tasting.GetPrice());
                        insert.Execute();
                        insert.Close();
                        control = true;
                    }
                    if (choice == "FillingSude")
                    {
                        Baverages filling = new LeShokaladeSude();
                        filling = new Filling(filling);
                        DatabaseInsert insert = new DatabaseInsert();
                        insert.Connection();
                        insert.InsertTakeAway(CustomerSent, choice, filling.GetPrice());
                        insert.Execute();
                        insert.Close();
                        control = true;
                    }
                    if (choice == "TastingNeriman")
                    {
                        Baverages tasting = new LeShokaladeNeriman();
                        tasting = new Tasting(tasting);
                        DatabaseInsert insert = new DatabaseInsert();
                        insert.Connection();
                        insert.InsertTakeAway(CustomerSent, choice, tasting.GetPrice());
                        insert.Execute();
                        insert.Close();
                        control = true;
                    }
                    if (choice == "FillingNeriman")
                    {
                        Baverages filling = new LeShokaladeNeriman();
                        filling = new Filling(filling);
                        DatabaseInsert insert = new DatabaseInsert();
                        insert.Connection();
                        insert.InsertTakeAway(CustomerSent, choice, filling.GetPrice());
                        insert.Execute();
                        insert.Close();
                        control = true;
                    }
                    if (choice == "Lemonade")
                    {
                        Baverages bev = new Lemonade();
                        DatabaseInsert insert = new DatabaseInsert();
                        insert.Connection();
                        insert.InsertTakeAway(CustomerSent, bev.GetDescription(), bev.GetPrice());
                        insert.Execute();
                        insert.Close();
                        control = true;
                    }
                    if (choice == "Americano")
                    {
                        Baverages bev = new Americano();
                        DatabaseInsert insert = new DatabaseInsert();
                        insert.Connection();
                        insert.InsertTakeAway(CustomerSent, bev.GetDescription(), bev.GetPrice());
                        insert.Execute();
                        insert.Close();
                        control = true;
                    }
                    if (choice == "MilkyAmericano")
                    {
                        Baverages bev = new Americano();
                        bev = new Milk(bev);
                        DatabaseInsert insert = new DatabaseInsert();
                        insert.Connection();
                        insert.InsertTakeAway(CustomerSent, bev.GetDescription(), bev.GetPrice());
                        insert.Execute();
                        insert.Close();
                        control = true;
                    }
                }
                if (control)
                {
                    MessageBox.Show("Your order has been received.", "Thank you :)");
                    AbstractStore store = new LeShokaladeDukkan();
                    Box.Text = store.OrderDessert("sude").Box();
                    for (int i = 0; i < ProductList.Items.Count; i++)
                    {
                        ProductList.SetItemChecked(i, false);
                    }
                    Orders.Text = " ";
                    Customer.Text = "Your Name";
                }
                else
                {
                    MessageBox.Show("You did not choose any order!", "Warning!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }          
        }
        ConcreteSubject order = new ConcreteSubject();
        private void button2_Click(object sender, EventArgs e)
        {
            OrderLoad();
        }

        private void Customer_MouseClick(object sender, MouseEventArgs e)
        {
            if(Customer.Text.Equals("Your Name"))
                Customer.Text = "";
        }
        int counter = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (counter == 100)
            {
                OrderLoad();
                counter=0;
            }
            counter++;
        }
        public void OrderLoad()
        {
            order.Attach(new ConcreteObserver(order));
            label6.Text = order.Notify();
            if (Personnel.OrderReady)
            {
                order.SubjectState = "Your Order Ready";
                label6.Text = order.Notify();
            }
        }
        private void TakeAway_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }  
}
