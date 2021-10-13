namespace Restaurant_Order_Taker
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Tbx1 = new System.Windows.Forms.TextBox();
            this.Tcl1 = new System.Windows.Forms.TabControl();
            this.TbpGuests = new System.Windows.Forms.TabPage();
            this.TbpOrders = new System.Windows.Forms.TabPage();
            this.TbpMenu = new System.Windows.Forms.TabPage();
            this.Tcl1.SuspendLayout();
            this.TbpGuests.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(6, 49);
            this.textBox1.MinimumSize = new System.Drawing.Size(100, 20);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(112, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 22);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Tbx1
            // 
            this.Tbx1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tbx1.Location = new System.Drawing.Point(6, 6);
            this.Tbx1.Multiline = true;
            this.Tbx1.Name = "Tbx1";
            this.Tbx1.Size = new System.Drawing.Size(180, 37);
            this.Tbx1.TabIndex = 3;
            this.Tbx1.Text = "Hello, Please enter the amount of guests you will require menus for.";
            // 
            // Tcl1
            // 
            this.Tcl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tcl1.Controls.Add(this.TbpGuests);
            this.Tcl1.Controls.Add(this.TbpOrders);
            this.Tcl1.Controls.Add(this.TbpMenu);
            this.Tcl1.Location = new System.Drawing.Point(12, 12);
            this.Tcl1.Name = "Tcl1";
            this.Tcl1.SelectedIndex = 0;
            this.Tcl1.Size = new System.Drawing.Size(201, 101);
            this.Tcl1.TabIndex = 4;
            // 
            // TbpGuests
            // 
            this.TbpGuests.Controls.Add(this.textBox1);
            this.TbpGuests.Controls.Add(this.button1);
            this.TbpGuests.Controls.Add(this.Tbx1);
            this.TbpGuests.Location = new System.Drawing.Point(4, 22);
            this.TbpGuests.Name = "TbpGuests";
            this.TbpGuests.Padding = new System.Windows.Forms.Padding(3);
            this.TbpGuests.Size = new System.Drawing.Size(193, 75);
            this.TbpGuests.TabIndex = 0;
            this.TbpGuests.Text = "Input Guests";
            this.TbpGuests.UseVisualStyleBackColor = true;
            // 
            // TbpOrders
            // 
            this.TbpOrders.Location = new System.Drawing.Point(4, 22);
            this.TbpOrders.Name = "TbpOrders";
            this.TbpOrders.Padding = new System.Windows.Forms.Padding(3);
            this.TbpOrders.Size = new System.Drawing.Size(193, 75);
            this.TbpOrders.TabIndex = 1;
            this.TbpOrders.Text = "Input Orders";
            this.TbpOrders.UseVisualStyleBackColor = true;
            // 
            // TbpMenu
            // 
            this.TbpMenu.Location = new System.Drawing.Point(4, 22);
            this.TbpMenu.Name = "TbpMenu";
            this.TbpMenu.Padding = new System.Windows.Forms.Padding(3);
            this.TbpMenu.Size = new System.Drawing.Size(193, 75);
            this.TbpMenu.TabIndex = 2;
            this.TbpMenu.Text = "Menu";
            this.TbpMenu.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 125);
            this.Controls.Add(this.Tcl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(241, 164);
            this.Name = "Form1";
            this.Text = "Input Guests";
            this.Tcl1.ResumeLayout(false);
            this.TbpGuests.ResumeLayout(false);
            this.TbpGuests.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Tbx1;
        private System.Windows.Forms.TabControl Tcl1;
        private System.Windows.Forms.TabPage TbpGuests;
        private System.Windows.Forms.TabPage TbpOrders;
        private System.Windows.Forms.TabPage TbpMenu;
    }
}

