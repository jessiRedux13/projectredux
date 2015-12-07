namespace WindowsFormsApplication3
{
    partial class Beverage
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
            this.btncoffee = new System.Windows.Forms.Button();
            this.btnjuice = new System.Windows.Forms.Button();
            this.btnmilk = new System.Windows.Forms.Button();
            this.btntea = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btncoffee
            // 
            this.btncoffee.Location = new System.Drawing.Point(333, 150);
            this.btncoffee.Name = "btncoffee";
            this.btncoffee.Size = new System.Drawing.Size(165, 136);
            this.btncoffee.TabIndex = 0;
            this.btncoffee.Text = "Coffee";
            this.btncoffee.UseVisualStyleBackColor = true;
            this.btncoffee.Click += new System.EventHandler(this.btncoffee_Click);
            // 
            // btnjuice
            // 
            this.btnjuice.Location = new System.Drawing.Point(690, 150);
            this.btnjuice.Name = "btnjuice";
            this.btnjuice.Size = new System.Drawing.Size(165, 136);
            this.btnjuice.TabIndex = 1;
            this.btnjuice.Text = "Juice";
            this.btnjuice.UseVisualStyleBackColor = true;
            this.btnjuice.Click += new System.EventHandler(this.btnjuice_Click);
            // 
            // btnmilk
            // 
            this.btnmilk.Location = new System.Drawing.Point(333, 381);
            this.btnmilk.Name = "btnmilk";
            this.btnmilk.Size = new System.Drawing.Size(165, 136);
            this.btnmilk.TabIndex = 2;
            this.btnmilk.Text = "Milk/Choco";
            this.btnmilk.UseVisualStyleBackColor = true;
            this.btnmilk.Click += new System.EventHandler(this.btnmilk_Click);
            // 
            // btntea
            // 
            this.btntea.Location = new System.Drawing.Point(700, 381);
            this.btntea.Name = "btntea";
            this.btntea.Size = new System.Drawing.Size(165, 136);
            this.btntea.TabIndex = 3;
            this.btntea.Text = "Tea";
            this.btntea.UseVisualStyleBackColor = true;
            this.btntea.Click += new System.EventHandler(this.btntea_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(1027, 24);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(75, 23);
            this.btnexit.TabIndex = 4;
            this.btnexit.Text = "E&xit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // Beverage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication3.Properties.Resources.abstract_crimson_landscape_backgrounds_powerpoint2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 676);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btntea);
            this.Controls.Add(this.btnmilk);
            this.Controls.Add(this.btnjuice);
            this.Controls.Add(this.btncoffee);
            this.Name = "Beverage";
            this.Text = "Beverage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btncoffee;
        private System.Windows.Forms.Button btnjuice;
        private System.Windows.Forms.Button btnmilk;
        private System.Windows.Forms.Button btntea;
        private System.Windows.Forms.Button btnexit;
    }
}