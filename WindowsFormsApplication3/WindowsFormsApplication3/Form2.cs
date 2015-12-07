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
        public char keyChar;
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            User u = new User();
            u.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Medicine med = new Medicine();
            med.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Food f = new Food();
            f.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Beverage bev = new Beverage();
            bev.Show();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Medicine_Up mu = new Medicine_Up();
            mu.Show();
        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            this.Close();
            Manage_inventory manage = new Manage_inventory();
            manage.Show();
        }

       
       

    }
}
