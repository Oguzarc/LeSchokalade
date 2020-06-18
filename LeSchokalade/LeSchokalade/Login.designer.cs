namespace LeSchokalade
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.NickName = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.logBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NickName
            // 
            this.NickName.Location = new System.Drawing.Point(117, 43);
            this.NickName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NickName.Name = "NickName";
            this.NickName.Size = new System.Drawing.Size(132, 28);
            this.NickName.TabIndex = 0;
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(117, 84);
            this.pass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(132, 28);
            this.pass.TabIndex = 1;
            this.pass.UseSystemPasswordChar = true;
            // 
            // logBTN
            // 
            this.logBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.logBTN.Image = ((System.Drawing.Image)(resources.GetObject("logBTN.Image")));
            this.logBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logBTN.Location = new System.Drawing.Point(139, 136);
            this.logBTN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.logBTN.Name = "logBTN";
            this.logBTN.Size = new System.Drawing.Size(80, 37);
            this.logBTN.TabIndex = 2;
            this.logBTN.Text = "Accept";
            this.logBTN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.logBTN.UseVisualStyleBackColor = true;
            this.logBTN.Click += new System.EventHandler(this.LogBTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "NickName :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password :";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(175)))), ((int)(((byte)(180)))));
            this.ClientSize = new System.Drawing.Size(320, 187);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logBTN);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.NickName);
            this.Font = new System.Drawing.Font("Pristina", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NickName;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.Button logBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}