using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form2 : Form
    {
        public string rights = string.Empty;
        public char keyChar;
        public Form2()
        {
            InitializeComponent();
        }
                                
        private void Form2_Load(object sender, EventArgs e)
        {
            if (rights == "User")
            {
                toolStripButton1.Enabled = false;
                toolStripButton2.Enabled = false;
                btnManageinventory.Enabled = false;
                btnbeverage.Enabled = false;
                btnfood.Enabled = false;
                btnother.Enabled = false;
                btnreport.Enabled = false;
                Medicine med = new Medicine();
                med.MdiParent = this;
                med.Dock = DockStyle.Fill;
                med.Show();
            }
            else 
            {
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            User u = new User();
            u.MdiParent = this;
            u.Dock = DockStyle.Fill;
            u.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
          
            Medicine_Up mu = new Medicine_Up();
            mu.MdiParent = this;
            mu.Dock = DockStyle.Fill;
            mu.Show();
        }

        private void btnManageinventory_Click(object sender, EventArgs e)
        {
            Manage_inventory manage = new Manage_inventory();
            manage.MdiParent = this;
            manage.Dock = DockStyle.Fill;
            manage.Show();
        }

        private void btnmedicine_Click(object sender, EventArgs e)
        {
            Medicine med = new Medicine();
            med.MdiParent = this;
            med.Dock = DockStyle.Fill;
            med.Show();
        }

        private void btnbeverage_Click(object sender, EventArgs e)
        {
            
            Beverage bev = new Beverage();
            bev.MdiParent = this;
            bev.Dock = DockStyle.Fill;
            bev.Show();
        }

        private void btnfood_Click(object sender, EventArgs e)
        {
            
            Food f = new Food();
            f.MdiParent = this;
            f.Dock = DockStyle.Fill;
            f.Show();
        }

        private void btnother_Click(object sender, EventArgs e)
        {
            products cat = new products();
            cat.categorymodule = "OtherStuff";
            cat.MdiParent = this;
            cat.Dock = DockStyle.Fill;
            cat.Show();
        }

        private void btnreport_Click(object sender, EventArgs e)
        {
            
            Gen_Report report = new Gen_Report();
            report.MdiParent = this;
            report.Dock = DockStyle.Fill;
            report.Show();
        }

        
      
       
       

    }
}
