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
    public partial class Beverage : Form
    {
        public Beverage()
        {
            InitializeComponent();
        }

        private void btncoffee_Click(object sender, EventArgs e)
        {
            products cat = new products();
            cat.categorymodule = "Coffee";
            cat.Show();
        }

        private void btnjuice_Click(object sender, EventArgs e)
        {
            products cat = new products();
            cat.categorymodule = "Juice";
            cat.Show();
        }

        private void btnmilk_Click(object sender, EventArgs e)
        {
            products cat = new products();
            cat.categorymodule = "MilkChoco";
            cat.Show();
        }

        private void btntea_Click(object sender, EventArgs e)
        {
            products cat = new products();
            cat.categorymodule = "Tea";
            cat.Show();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 main = new Form2();
            main.Show();
        }
    }
}
