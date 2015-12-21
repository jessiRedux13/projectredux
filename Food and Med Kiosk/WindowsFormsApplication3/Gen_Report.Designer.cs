namespace WindowsFormsApplication3
{
    partial class Gen_Report
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
            this.dgvreport = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btneExport = new System.Windows.Forms.Button();
            this.cbocattype = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.btnlistpurchase = new System.Windows.Forms.Button();
            this.btncrystalreport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvreport)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvreport
            // 
            this.dgvreport.BackgroundColor = System.Drawing.Color.White;
            this.dgvreport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvreport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column3,
            this.Column7});
            this.dgvreport.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvreport.Location = new System.Drawing.Point(20, 68);
            this.dgvreport.Name = "dgvreport";
            this.dgvreport.Size = new System.Drawing.Size(675, 550);
            this.dgvreport.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ProductAddedDate";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "ProductName";
            this.Column2.Name = "Column2";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Stock In";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Stock Out";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Total Stock";
            this.Column6.Name = "Column6";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Reorder_level";
            this.Column3.Name = "Column3";
            this.Column3.Visible = false;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Select";
            this.Column7.Name = "Column7";
            this.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // btneExport
            // 
            this.btneExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneExport.Location = new System.Drawing.Point(399, 623);
            this.btneExport.Name = "btneExport";
            this.btneExport.Size = new System.Drawing.Size(121, 34);
            this.btneExport.TabIndex = 1;
            this.btneExport.Text = "Export to Excel";
            this.btneExport.UseVisualStyleBackColor = true;
            this.btneExport.Click += new System.EventHandler(this.btneExport_Click);
            // 
            // cbocattype
            // 
            this.cbocattype.FormattingEnabled = true;
            this.cbocattype.Items.AddRange(new object[] {
            "Food",
            "Beverage",
            "Medicine",
            "Other"});
            this.cbocattype.Location = new System.Drawing.Point(143, 28);
            this.cbocattype.Name = "cbocattype";
            this.cbocattype.Size = new System.Drawing.Size(121, 21);
            this.cbocattype.TabIndex = 2;
            this.cbocattype.SelectedIndexChanged += new System.EventHandler(this.cbocattype_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(35, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Category Type";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(441, 32);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(650, 32);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(99, 20);
            this.dateTimePicker2.TabIndex = 5;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // btnlistpurchase
            // 
            this.btnlistpurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlistpurchase.Location = new System.Drawing.Point(539, 624);
            this.btnlistpurchase.Name = "btnlistpurchase";
            this.btnlistpurchase.Size = new System.Drawing.Size(132, 33);
            this.btnlistpurchase.TabIndex = 6;
            this.btnlistpurchase.Text = "List to Purchase";
            this.btnlistpurchase.UseVisualStyleBackColor = true;
            this.btnlistpurchase.Click += new System.EventHandler(this.btnlistpurchase_Click);
            // 
            // btncrystalreport
            // 
            this.btncrystalreport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncrystalreport.Location = new System.Drawing.Point(688, 623);
            this.btncrystalreport.Name = "btncrystalreport";
            this.btncrystalreport.Size = new System.Drawing.Size(127, 32);
            this.btncrystalreport.TabIndex = 7;
            this.btncrystalreport.Text = "Crystalreport";
            this.btncrystalreport.UseVisualStyleBackColor = true;
            this.btncrystalreport.Click += new System.EventHandler(this.btncrystalreport_Click);
            // 
            // Gen_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(827, 725);
            this.Controls.Add(this.btncrystalreport);
            this.Controls.Add(this.btnlistpurchase);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbocattype);
            this.Controls.Add(this.btneExport);
            this.Controls.Add(this.dgvreport);
            this.Name = "Gen_Report";
            this.Text = "Gen_Report";
            this.Load += new System.EventHandler(this.Gen_Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvreport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvreport;
        private System.Windows.Forms.Button btneExport;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column7;
        private System.Windows.Forms.ComboBox cbocattype;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button btnlistpurchase;
        private System.Windows.Forms.Button btncrystalreport;
    }
}