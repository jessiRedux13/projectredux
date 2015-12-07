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
    public partial class Food : Form
    {
        public Food()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 main = new Form2();
            main.Show();
        }

        private void btnF_fruits_Click(object sender, EventArgs e)
        {
            products cat = new products();
            cat.categorymodule = "Fruits";
            cat.Show();
        }

        private void catF_cupnoodles_Click(object sender, EventArgs e)
        {
            products cat = new products();
            cat.categorymodule = "CupNoodle";
            cat.Show();
        }

        private void catF_oatmeal_Click(object sender, EventArgs e)
        {
            products cat = new products();
            cat.categorymodule = "Oatmeal";
            cat.Show();
        }

        private void catF_condiments_Click(object sender, EventArgs e)
        {
            products cat = new products();
            cat.categorymodule = "Condiments";
            cat.Show();
        }
    }
}
