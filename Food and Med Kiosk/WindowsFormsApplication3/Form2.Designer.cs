namespace WindowsFormsApplication3
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.btnManageinventory = new System.Windows.Forms.ToolStripButton();
            this.btnmedicine = new System.Windows.Forms.ToolStripButton();
            this.btnbeverage = new System.Windows.Forms.ToolStripButton();
            this.btnfood = new System.Windows.Forms.ToolStripButton();
            this.btnother = new System.Windows.Forms.ToolStripButton();
            this.btnreport = new System.Windows.Forms.ToolStripButton();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Minion Pro", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(397, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(442, 44);
            this.label1.TabIndex = 4;
            this.label1.Text = "FOOD and MEDICINE KIOSK";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkRed;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(965, 100);
            this.panel2.TabIndex = 22;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication3.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkRed;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 566);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(965, 100);
            this.panel3.TabIndex = 23;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.btnManageinventory,
            this.btnmedicine,
            this.btnbeverage,
            this.btnfood,
            this.btnother,
            this.btnreport});
            this.toolStrip1.Location = new System.Drawing.Point(0, 100);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(181, 466);
            this.toolStrip1.TabIndex = 24;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(179, 44);
            this.toolStripButton1.Text = "User Administration";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(179, 44);
            this.toolStripButton2.Text = "Product Details";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // btnManageinventory
            // 
            this.btnManageinventory.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageinventory.Image = ((System.Drawing.Image)(resources.GetObject("btnManageinventory.Image")));
            this.btnManageinventory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageinventory.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnManageinventory.Name = "btnManageinventory";
            this.btnManageinventory.Size = new System.Drawing.Size(179, 44);
            this.btnManageinventory.Text = "Manage Inventory";
            this.btnManageinventory.Click += new System.EventHandler(this.btnManageinventory_Click);
            // 
            // btnmedicine
            // 
            this.btnmedicine.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmedicine.Image = ((System.Drawing.Image)(resources.GetObject("btnmedicine.Image")));
            this.btnmedicine.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnmedicine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnmedicine.Name = "btnmedicine";
            this.btnmedicine.Size = new System.Drawing.Size(179, 44);
            this.btnmedicine.Text = "Medicine";
            this.btnmedicine.Click += new System.EventHandler(this.btnmedicine_Click);
            // 
            // btnbeverage
            // 
            this.btnbeverage.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbeverage.Image = ((System.Drawing.Image)(resources.GetObject("btnbeverage.Image")));
            this.btnbeverage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnbeverage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnbeverage.Name = "btnbeverage";
            this.btnbeverage.Size = new System.Drawing.Size(179, 44);
            this.btnbeverage.Text = "Beverage";
            this.btnbeverage.Click += new System.EventHandler(this.btnbeverage_Click);
            // 
            // btnfood
            // 
            this.btnfood.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfood.Image = ((System.Drawing.Image)(resources.GetObject("btnfood.Image")));
            this.btnfood.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnfood.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnfood.Name = "btnfood";
            this.btnfood.Size = new System.Drawing.Size(179, 44);
            this.btnfood.Text = "Food";
            this.btnfood.Click += new System.EventHandler(this.btnfood_Click);
            // 
            // btnother
            // 
            this.btnother.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnother.Image = ((System.Drawing.Image)(resources.GetObject("btnother.Image")));
            this.btnother.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnother.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnother.Name = "btnother";
            this.btnother.Size = new System.Drawing.Size(179, 44);
            this.btnother.Text = "Other Stuff";
            this.btnother.Click += new System.EventHandler(this.btnother_Click);
            // 
            // btnreport
            // 
            this.btnreport.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreport.Image = ((System.Drawing.Image)(resources.GetObject("btnreport.Image")));
            this.btnreport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnreport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnreport.Name = "btnreport";
            this.btnreport.Size = new System.Drawing.Size(179, 44);
            this.btnreport.Text = "Report";
            this.btnreport.Click += new System.EventHandler(this.btnreport_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(965, 666);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.IsMdiContainer = true;
            this.Name = "Form2";
            this.Text = "Food&Med Kiosk";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton btnManageinventory;
        private System.Windows.Forms.ToolStripButton btnmedicine;
        private System.Windows.Forms.ToolStripButton btnbeverage;
        private System.Windows.Forms.ToolStripButton btnfood;
        private System.Windows.Forms.ToolStripButton btnother;
        private System.Windows.Forms.ToolStripButton btnreport;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}