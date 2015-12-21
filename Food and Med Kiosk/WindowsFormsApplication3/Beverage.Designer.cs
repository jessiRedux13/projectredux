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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btncoffee
            // 
            this.btncoffee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnjuice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnmilk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btntea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntea.Location = new System.Drawing.Point(700, 381);
            this.btntea.Name = "btntea";
            this.btntea.Size = new System.Drawing.Size(165, 136);
            this.btntea.TabIndex = 3;
            this.btntea.Text = "Tea";
            this.btntea.UseVisualStyleBackColor = true;
            this.btntea.Click += new System.EventHandler(this.btntea_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(255, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 37);
            this.label1.TabIndex = 5;
            this.label1.Text = "Category";
            // 
            // Beverage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::WindowsFormsApplication3.Properties.Resources.abstract_crimson_landscape_backgrounds_powerpoint2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1217, 714);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btntea);
            this.Controls.Add(this.btnmilk);
            this.Controls.Add(this.btnjuice);
            this.Controls.Add(this.btncoffee);
            this.Name = "Beverage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Beverage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncoffee;
        private System.Windows.Forms.Button btnjuice;
        private System.Windows.Forms.Button btnmilk;
        private System.Windows.Forms.Button btntea;
        private System.Windows.Forms.Label label1;
    }
}