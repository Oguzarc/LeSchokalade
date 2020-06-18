namespace LeSchokalade
{
    partial class TakeAway
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TakeAway));
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Orders = new System.Windows.Forms.Label();
            this.GiveOrder = new System.Windows.Forms.Button();
            this.Customer = new System.Windows.Forms.TextBox();
            this.Box = new System.Windows.Forms.Label();
            this.inf = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.ProductList = new System.Windows.Forms.CheckedListBox();
            this.Price = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(175)))), ((int)(((byte)(180)))));
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.Orders);
            this.panel4.Controls.Add(this.GiveOrder);
            this.panel4.Controls.Add(this.Customer);
            this.panel4.Controls.Add(this.Box);
            this.panel4.Controls.Add(this.inf);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.button2);
            this.panel4.Controls.Add(this.ProductList);
            this.panel4.Controls.Add(this.Price);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(673, 534);
            this.panel4.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Pristina", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(249, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "Your Choices :";
            // 
            // Orders
            // 
            this.Orders.AutoSize = true;
            this.Orders.Font = new System.Drawing.Font("Pristina", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Orders.Location = new System.Drawing.Point(249, 120);
            this.Orders.Name = "Orders";
            this.Orders.Size = new System.Drawing.Size(78, 27);
            this.Orders.TabIndex = 3;
            this.Orders.Text = "Any Order";
            // 
            // GiveOrder
            // 
            this.GiveOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GiveOrder.Font = new System.Drawing.Font("Pristina", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GiveOrder.Location = new System.Drawing.Point(447, 342);
            this.GiveOrder.Name = "GiveOrder";
            this.GiveOrder.Size = new System.Drawing.Size(123, 31);
            this.GiveOrder.TabIndex = 2;
            this.GiveOrder.Text = "Give Order";
            this.GiveOrder.UseVisualStyleBackColor = true;
            this.GiveOrder.Click += new System.EventHandler(this.GiveOrder_Click);
            // 
            // Customer
            // 
            this.Customer.Font = new System.Drawing.Font("Pristina", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customer.Location = new System.Drawing.Point(447, 129);
            this.Customer.MaxLength = 10;
            this.Customer.Name = "Customer";
            this.Customer.Size = new System.Drawing.Size(123, 32);
            this.Customer.TabIndex = 11;
            this.Customer.Text = "Your Name";
            this.Customer.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Customer_MouseClick);
            // 
            // Box
            // 
            this.Box.AutoSize = true;
            this.Box.Font = new System.Drawing.Font("Pristina", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box.Location = new System.Drawing.Point(399, 310);
            this.Box.Name = "Box";
            this.Box.Size = new System.Drawing.Size(24, 27);
            this.Box.TabIndex = 8;
            this.Box.Text = "...";
            // 
            // inf
            // 
            this.inf.AutoSize = true;
            this.inf.Font = new System.Drawing.Font("Pristina", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inf.Location = new System.Drawing.Point(399, 93);
            this.inf.Name = "inf";
            this.inf.Size = new System.Drawing.Size(223, 27);
            this.inf.TabIndex = 12;
            this.inf.Text = "Please write your name before order!!";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Pristina", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(58, 307);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 32);
            this.label6.TabIndex = 10;
            this.label6.Text = "...";
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Pristina", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(62, 342);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 32);
            this.button2.TabIndex = 9;
            this.button2.Text = "İsReady?";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ProductList
            // 
            this.ProductList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(175)))), ((int)(((byte)(180)))));
            this.ProductList.CheckOnClick = true;
            this.ProductList.Font = new System.Drawing.Font("Pristina", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductList.FormattingEnabled = true;
            this.ProductList.Items.AddRange(new object[] {
            "TastingSude",
            "FillingSude",
            "TastingNeriman",
            "FillingNeriman",
            "Lemonade",
            "Americano",
            "MilkyAmericano"});
            this.ProductList.Location = new System.Drawing.Point(62, 93);
            this.ProductList.Name = "ProductList";
            this.ProductList.Size = new System.Drawing.Size(162, 165);
            this.ProductList.TabIndex = 0;
            this.ProductList.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Font = new System.Drawing.Font("Pristina", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price.Location = new System.Drawing.Point(421, 104);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(0, 27);
            this.Price.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(763, 501);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Pristina", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 27);
            this.label1.TabIndex = 13;
            this.label1.Text = "Order Status";
            // 
            // TakeAway
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 534);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TakeAway";
            this.Text = "SiparisVer";
            this.Load += new System.EventHandler(this.TakeAway_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button GiveOrder;
        private System.Windows.Forms.CheckedListBox ProductList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Orders;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Box;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label inf;
        private System.Windows.Forms.TextBox Customer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
    }
}