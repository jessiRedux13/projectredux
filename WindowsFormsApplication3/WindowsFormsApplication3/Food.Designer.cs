namespace WindowsFormsApplication3
{
    partial class Food
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnF_fruits = new System.Windows.Forms.Button();
            this.catF_cupnoodles = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.catF_oatmeal = new System.Windows.Forms.Button();
            this.catF_condiments = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1091, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "E&xit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnF_fruits
            // 
            this.btnF_fruits.Location = new System.Drawing.Point(378, 127);
            this.btnF_fruits.Name = "btnF_fruits";
            this.btnF_fruits.Size = new System.Drawing.Size(121, 109);
            this.btnF_fruits.TabIndex = 1;
            this.btnF_fruits.Text = "Fruits";
            this.btnF_fruits.UseVisualStyleBackColor = true;
            this.btnF_fruits.Click += new System.EventHandler(this.btnF_fruits_Click);
            // 
            // catF_cupnoodles
            // 
            this.catF_cupnoodles.Location = new System.Drawing.Point(708, 127);
            this.catF_cupnoodles.Name = "catF_cupnoodles";
            this.catF_cupnoodles.Size = new System.Drawing.Size(121, 109);
            this.catF_cupnoodles.TabIndex = 2;
            this.catF_cupnoodles.Text = "CupNoodles";
            this.catF_cupnoodles.UseVisualStyleBackColor = true;
            this.catF_cupnoodles.Click += new System.EventHandler(this.catF_cupnoodles_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(260, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Category";
            // 
            // catF_oatmeal
            // 
            this.catF_oatmeal.Location = new System.Drawing.Point(378, 360);
            this.catF_oatmeal.Name = "catF_oatmeal";
            this.catF_oatmeal.Size = new System.Drawing.Size(121, 109);
            this.catF_oatmeal.TabIndex = 4;
            this.catF_oatmeal.Text = "Oatmeal";
            this.catF_oatmeal.UseVisualStyleBackColor = true;
            this.catF_oatmeal.Click += new System.EventHandler(this.catF_oatmeal_Click);
            // 
            // catF_condiments
            // 
            this.catF_condiments.Location = new System.Drawing.Point(708, 360);
            this.catF_condiments.Name = "catF_condiments";
            this.catF_condiments.Size = new System.Drawing.Size(121, 109);
            this.catF_condiments.TabIndex = 5;
            this.catF_condiments.Text = "Condiments";
            this.catF_condiments.UseVisualStyleBackColor = true;
            this.catF_condiments.Click += new System.EventHandler(this.catF_condiments_Click);
            // 
            // Food
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication3.Properties.Resources.abstract_crimson_landscape_backgrounds_powerpoint1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1229, 775);
            this.Controls.Add(this.catF_condiments);
            this.Controls.Add(this.catF_oatmeal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.catF_cupnoodles);
            this.Controls.Add(this.btnF_fruits);
            this.Controls.Add(this.button1);
            this.Name = "Food";
            this.Text = "Food";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnF_fruits;
        private System.Windows.Forms.Button catF_cupnoodles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button catF_oatmeal;
        private System.Windows.Forms.Button catF_condiments;
    }
}