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
    public partial class Medicine_Up : Form
    {
        private MySqlConnection connection;
        String ConnectionString = "Server=192.168.0.24;Database=inventory_food_meds;Uid=jes;Pwd=!ojt2015";
        public Medicine_Up()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 F = new Form2();
            F.Show();

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
        }

        private void Medicine_Up_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection = new MySqlConnection(ConnectionString);
            try
            {

                connection.Open();

                MySqlCommand cmd = new MySqlCommand("insert into category(cat_name,ctype,cat_description) value( '" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')", connection);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Successfully saved");
                //LoadAllEmployee();
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            connection = new MySqlConnection(ConnectionString);
            try
            {

                connection.Open();

                MySqlCommand cmd = new MySqlCommand("insert into product_info(p_name,p_description,quantity_per_unit,expiration_date) value( '" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "')", connection);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Successfully saved");
                //LoadAllEmployee();
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;

        }

        private void button9_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            connection = new MySqlConnection(ConnectionString);
            try
            {

                connection.Open();

                MySqlCommand cmd = new MySqlCommand("update category set cat_name = '" + textBox8.Text + "',ctype = '" + textBox9.Text + "',cat_description = '" + textBox10.Text+"' where  cid= '" + textBox15.Text + "'", connection);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Successfully updated");
               // LoadAllUpdates();

                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox15.Clear();
        }

        private void btnsaveP_info_Click(object sender, EventArgs e)
        {
            connection = new MySqlConnection(ConnectionString);
            try
            {

                connection.Open();

                MySqlCommand cmd = new MySqlCommand("update product_info set p_name = '" + textBox14.Text + "',p_description = '" + textBox13.Text + "',quantity_per_unit = '" + textBox12.Text + "',expiration_date = '" + textBox11.Text + "' where  pid= '" + textBox16.Text + "'", connection);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Successfully updated");
                // LoadAllUpdates();

                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnclearP_info_Click(object sender, EventArgs e)
        {
            textBox11.Clear();
            textBox12.Clear();
            textBox13.Clear();
            textBox14.Clear();
            textBox16.Clear();

        }
    }
}
