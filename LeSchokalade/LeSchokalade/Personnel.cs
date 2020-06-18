using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LeSchokalade.Database;
namespace LeSchokalade
{
    public partial class Personnel : Form
    {
        public Personnel()
        {
            InitializeComponent();
            timer1.Start();
        }
        private string toolstrip = "";
        private int table;
        void ActiveTable()
        {
            if (table == 1)
            {
                try
                {
                    this.oRDERSTableAdapter.TABLE1(this.denemeDataSet1.ORDERS);
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
            }
            if (table == 2)
            {
                try
                {
                    this.oRDERSTableAdapter.Table2(this.denemeDataSet1.ORDERS);
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
            }
            if (table == 3)
            {
                try
                {
                    this.oRDERSTableAdapter.Table3(this.denemeDataSet1.ORDERS);
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
            }
            if (table == 4)
            {
                try
                {
                    this.oRDERSTableAdapter.Table4(this.denemeDataSet1.ORDERS);
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
            }
        }
        void InActiveTable()
        {
            if (toolstrip == "InActiveTable1Tool")
            {
                try
                {
                    this.oRDERSTableAdapter1.InActiveTable1(this.inactiveTableData.ORDERS);
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
            }
            if (toolstrip == "InActiveTable2Tool")
            {
                try
                {
                    this.oRDERSTableAdapter1.InActiveTable2(this.inactiveTableData.ORDERS);
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
            }
            if (toolstrip == "InActiveTable3Tool")
            {
                try
                {
                    this.oRDERSTableAdapter1.InActiveTable3(this.inactiveTableData.ORDERS);
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
            }
            if (toolstrip == "InActiveTable4Tool")
            {
                try
                {
                    this.oRDERSTableAdapter1.InActiveTable4(this.inactiveTableData.ORDERS);
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
            }
        }
        private int i = 0;
        private bool printControl;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.HasMorePages = false;
            float x = 10;
            float y = 10;
            int imgWidth = 200;
            int imgHeight = 200;
            string invCompany = "LeSchokalade";
            string invDate = "Date : " + DateTime.Now.ToShortDateString();
            string invAddress = "Address: Al. Marszałka Rydza Śmigłego Edwarda 88\n" +
                                "Łódź-93-272 ";
            Image newImage = Image.FromFile(@"C:\Users\user\source\repos\LeSchokalade\LeSchokalade\logo\Logo.jpg");
            //Pen
            Pen p = new Pen(Color.Black, 1);
            //Font text
            Font f = new Font("Pristina", 20, FontStyle.Bold);
            //Size of text
            SizeF strSizeInvCompany = e.Graphics.MeasureString(invCompany, f);
            SizeF strSizeDate = e.Graphics.MeasureString(invDate, f);
            SizeF strSizeAdress = e.Graphics.MeasureString(invAddress, f);
            //Draw Image 
            e.Graphics.DrawImage(newImage, x, y, imgWidth, imgHeight);
            //Draw Invoice Company
            e.Graphics.DrawString(invCompany, f, Brushes.Black, (e.PageBounds.Width - strSizeInvCompany.Width) / 2, y);
            //Draw Invoice Address
            e.Graphics.DrawString(invAddress, f, Brushes.Black, imgWidth + x, y + imgHeight / 3);
            //Draw Invoice Date
            e.Graphics.DrawString(invDate, f, Brushes.Black, imgWidth + x, y + strSizeInvCompany.Height + strSizeDate.Height * 3);
            //Draw Rectangle
            float preHeight = strSizeInvCompany.Height + strSizeDate.Height + strSizeAdress.Height + imgHeight + y;
            e.Graphics.DrawRectangle(p, x, imgHeight + y * 2, e.PageBounds.Width - x * 2, e.PageBounds.Height - preHeight);
            //Column Height
            float colHeight = 60;
            //Column Width
            float col1Width = 500;
            float col2Width = 125 + col1Width;
            //Draw Line
            e.Graphics.DrawLine(p, x, preHeight, e.PageBounds.Width - x, preHeight);

            e.Graphics.DrawString("Product", f, Brushes.Black, x * 2, preHeight - colHeight);
            e.Graphics.DrawLine(p, x * 2 + col1Width, imgHeight + y * 2, x * 2 + col1Width, e.PageBounds.Height - colHeight - y * 4);
           
            //Invoice Content
            float rowHeight = 60;
            if (!printControl)
            {
                e.Graphics.DrawString("Quantity", f, Brushes.Black, x * 2 + col1Width, preHeight - colHeight);
                e.Graphics.DrawLine(p, x * 2 + col2Width, imgHeight + y * 2, x * 2 + col2Width, e.PageBounds.Height - colHeight - y * 4);
                e.Graphics.DrawString("Price", f, Brushes.Black, x * 2 + col2Width, preHeight - colHeight);
                for (; i < inActiveGrid.Rows.Count; i++)
                {
                    if (Convert.ToBoolean(inActiveGrid.Rows[i].Cells[4].Value))
                    {
                        if (rowHeight >= e.PageBounds.Height - preHeight - colHeight)
                        {
                            e.HasMorePages = true;
                            break;
                        }
                        e.Graphics.DrawString(inActiveGrid.Rows[i].Cells[1].Value.ToString(), f, Brushes.Black, x * 2, preHeight + rowHeight - colHeight);
                        e.Graphics.DrawString(inActiveGrid.Rows[i].Cells[2].Value.ToString(), f, Brushes.Black, x * 2 + col1Width, preHeight + rowHeight - colHeight);
                        e.Graphics.DrawString(inActiveGrid.Rows[i].Cells[3].Value.ToString(), f, Brushes.Black, x * 2 + col2Width, preHeight + rowHeight - colHeight);

                        e.Graphics.DrawLine(p, x, preHeight + rowHeight, e.PageBounds.Width - x,
                            preHeight + rowHeight);

                        rowHeight += 60;
                    }
                }
            }
            if (printControl)
            {
                e.Graphics.DrawString("Name", f, Brushes.Black, x * 2 + col1Width, preHeight - colHeight);
                e.Graphics.DrawLine(p, x * 2 + col2Width, imgHeight + y * 2, x * 2 + col2Width, e.PageBounds.Height - colHeight - y * 4);
                e.Graphics.DrawString("Price", f, Brushes.Black, x * 2 + col2Width, preHeight - colHeight);
                for (; i < TakeAwayGrid.Rows.Count; i++)                  
                {
                    if (Convert.ToBoolean(TakeAwayGrid.Rows[i].Cells[4].Value))
                    {
                        if (rowHeight >= e.PageBounds.Height - preHeight - colHeight)
                        {
                            e.HasMorePages = true;
                            break;
                        }
                        e.Graphics.DrawString(TakeAwayGrid.Rows[i].Cells[2].Value.ToString(), f, Brushes.Black, x * 2, preHeight + rowHeight - colHeight);
                        e.Graphics.DrawString(TakeAwayGrid.Rows[i].Cells[1].Value.ToString(), f, Brushes.Black, x * 2 + col1Width, preHeight + rowHeight - colHeight);
                        e.Graphics.DrawString(TakeAwayGrid.Rows[i].Cells[3].Value.ToString(), f, Brushes.Black, x * 2 + col2Width, preHeight + rowHeight - colHeight);

                        e.Graphics.DrawLine(p, x, preHeight + rowHeight, e.PageBounds.Width - x,
                            preHeight + rowHeight);

                        rowHeight += 60;
                    }
                }
            }
            if (rowHeight < e.PageBounds.Height - preHeight - colHeight)
            {
                    e.Graphics.DrawString("Total", f, Brushes.Black, x * 2 + col1Width, preHeight + rowHeight - colHeight);
                    e.Graphics.DrawString(sum.ToString(), f, Brushes.Black, x * 2 + col2Width, preHeight + rowHeight - colHeight);
            }
        }       
        private void ActiveTable_Click(object sender, EventArgs e)
        {
            table=((Button)sender).TabIndex;
            ActiveTable();
        }             
        private void TableGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                DatabaseUpdate update = new DatabaseUpdate();
                DataGridViewRow row = TableGrid.Rows[e.RowIndex];
                update.Connection();
                update.Command((Convert.ToInt32(row.Cells[0].Value.ToString())));
                update.Execute();
                update.Close();
                ActiveTable();
            }           
        }
        double sum = 0;
        private void TakeAwayPreview_Click(object sender, EventArgs e)
        {
            sum = 0;
            printControl = true;
            foreach (DataGridViewRow row in TakeAwayGrid.Rows)
            {
                if (Convert.ToBoolean(row.Cells[4].Value))
                {
                    sum += Convert.ToDouble(row.Cells[3].Value);                                              
                }
            }
            printPreviewDialog1.WindowState = FormWindowState.Maximized;
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
            i=0;        
        }
        public static string customerName="";
        public static bool OrderReady = false;
        private void TakeAwayPrint_Click(object sender, EventArgs e)
        {
            sum = 0;
            printControl = true;
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
                foreach (DataGridViewRow row in TakeAwayGrid.Rows)
                {
                    if (Convert.ToBoolean(row.Cells[4].Value))
                    {
                        customerName = row.Cells[1].Value.ToString();
                        sum += Convert.ToDouble(row.Cells[3].Value);
                        DatabaseUpdate update = new DatabaseUpdate();
                        update.Connection();
                        update.CommandTake(Convert.ToInt32(row.Cells[0].Value.ToString()));
                        update.Execute();
                        update.Close();
                        OrderReady = true;
                    }
                }
                timer1.Start();
                count = 100;
            }
            i = 0;                  
        }

        private void TablePreview_Click(object sender, EventArgs e)
        {
            sum = 0;
            printControl = false;
            foreach (DataGridViewRow row in inActiveGrid.Rows)
            {
                if (Convert.ToBoolean(row.Cells[4].Value))
                {
                    sum += Convert.ToDouble(row.Cells[3].Value);
                }
            }
            printPreviewDialog1.WindowState = FormWindowState.Maximized;
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
            i = 0;                     
        }

        private void TablePrint_Click(object sender, EventArgs e)
        {
            sum = 0;
            printControl = false;
            foreach (DataGridViewRow row in inActiveGrid.Rows)
            {
                if (Convert.ToBoolean(row.Cells[4].Value))
                {
                    sum += Convert.ToDouble(row.Cells[3].Value);
                    DatabaseUpdate update = new DatabaseUpdate();
                    update.Connection();
                    update.CommandInactive(Convert.ToInt32(row.Cells[0].Value.ToString()));
                    update.Execute();
                    update.Close();
                }
            }
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
                InActiveTable();
            }
            i = 0;
        }
        int count = 100;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (count == 100)
            {
                this.takeAwayTableAdapter.Fill(this.denemeDataSet.TakeAway);
                count = 0;
            }
            count++;
        }
        private void TakeAwayGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn &&
                e.RowIndex >= 0)
            {
                timer1.Stop();
            }
        }       
        private void InActiveTool_Click(object sender, EventArgs e)
        {
            toolstrip = ((ToolStripButton)sender).Name;
            InActiveTable();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User.Session.Instance.clear();
            this.Close();
        }

        private void Personnel_Load(object sender, EventArgs e)
        {
            ToolNickName.Text = User.Session.Instance.user.Nickname;
        }
    }    
}
