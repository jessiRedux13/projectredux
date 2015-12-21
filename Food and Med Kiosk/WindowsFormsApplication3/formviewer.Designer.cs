namespace WindowsFormsApplication3
{
    partial class formviewer
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.cbocategory = new System.Windows.Forms.ComboBox();
            this.datefrom = new System.Windows.Forms.DateTimePicker();
            this.dateto = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnloadreport = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnlistpurchase = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.ForeColor = System.Drawing.Color.Black;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1206, 618);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // cbocategory
            // 
            this.cbocategory.FormattingEnabled = true;
            this.cbocategory.Items.AddRange(new object[] {
            "Food",
            "Beverage",
            "Medicine",
            "Other"});
            this.cbocategory.Location = new System.Drawing.Point(123, 56);
            this.cbocategory.Name = "cbocategory";
            this.cbocategory.Size = new System.Drawing.Size(129, 21);
            this.cbocategory.TabIndex = 1;
            // 
            // datefrom
            // 
            this.datefrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datefrom.Location = new System.Drawing.Point(383, 59);
            this.datefrom.Name = "datefrom";
            this.datefrom.Size = new System.Drawing.Size(115, 20);
            this.datefrom.TabIndex = 2;
            // 
            // dateto
            // 
            this.dateto.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateto.Location = new System.Drawing.Point(598, 61);
            this.dateto.Name = "dateto";
            this.dateto.Size = new System.Drawing.Size(122, 20);
            this.dateto.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(22, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Category";
            // 
            // btnloadreport
            // 
            this.btnloadreport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnloadreport.Location = new System.Drawing.Point(781, 57);
            this.btnloadreport.Name = "btnloadreport";
            this.btnloadreport.Size = new System.Drawing.Size(96, 23);
            this.btnloadreport.TabIndex = 5;
            this.btnloadreport.Text = "LoadReport";
            this.btnloadreport.UseVisualStyleBackColor = true;
            this.btnloadreport.Click += new System.EventHandler(this.btnloadreport_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(291, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Date from";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(550, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "To";
            // 
            // btnlistpurchase
            // 
            this.btnlistpurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlistpurchase.Location = new System.Drawing.Point(917, 55);
            this.btnlistpurchase.Name = "btnlistpurchase";
            this.btnlistpurchase.Size = new System.Drawing.Size(122, 23);
            this.btnlistpurchase.TabIndex = 8;
            this.btnlistpurchase.Text = "List to Purchase";
            this.btnlistpurchase.UseVisualStyleBackColor = true;
            this.btnlistpurchase.Click += new System.EventHandler(this.btnlistpurchase_Click);
            // 
            // formviewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1206, 618);
            this.Controls.Add(this.btnlistpurchase);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnloadreport);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateto);
            this.Controls.Add(this.datefrom);
            this.Controls.Add(this.cbocategory);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "formviewer";
            this.Text = "formviewer";
            this.Load += new System.EventHandler(this.formviewer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.ComboBox cbocategory;
        private System.Windows.Forms.DateTimePicker datefrom;
        private System.Windows.Forms.DateTimePicker dateto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnloadreport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnlistpurchase;
    }
}