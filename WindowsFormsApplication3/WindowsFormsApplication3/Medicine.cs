using MySql.Data.MySqlClient;
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
    public partial class Medicine : Form
    {
        
        public Medicine()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 main = new Form2();
            main.Show();
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            products cat = new products();
            cat.categorymodule = "HighbloodPressure";
            cat.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            products cat = new products();
            cat.categorymodule = "colds";
            cat.Show();

           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            products cat = new products();
            cat.categorymodule = "Cough";
            cat.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            products cat = new products();
            cat.categorymodule = "Anti-diarrheal";
            cat.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            products cat = new products();
            cat.categorymodule = "Flu";
            cat.Show();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            products cat = new products();
            cat.categorymodule = "Anti-histamine";
            cat.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            products cat = new products();
            cat.categorymodule = "Anti-pasmodic";
            cat.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            products cat = new products();
            cat.categorymodule = "Pain-reliever";
            cat.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            products cat = new products();
            cat.categorymodule = "Dysmenorrhea";
            cat.Show();
        }

        private void Medicine_Load(object sender, EventArgs e)
        {

        }

    }
}
