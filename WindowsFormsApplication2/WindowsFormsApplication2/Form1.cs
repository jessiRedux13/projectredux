using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {

        private MySqlConnection connection;
        String ConnectionString = "Server=192.168.0.24;Database=inventory_food_meds;Uid=jes;Pwd=!ojt2015";

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection = new MySqlConnection(ConnectionString);

            try
            {
                //open connection
                connection.Open();

                MessageBox.Show("connected");

                //close connection
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            groupBox3.Visible = false;

        }

        private void button6_Click(object sender, EventArgs e)
        {

            connection = new MySqlConnection(ConnectionString);
            try
            {
                //open connection
                connection.Open();

                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand("insert into users(uid,uname,pword,email,fname,lname,acct_type) value('" + textBox1.Text + "', '" + textBox2.Text + "','"+textBox3.Text+"','"+textBox4.Text+"','"+textBox5.Text+"','"+textBox6.Text+"','"+textBox7.Text+"')", connection);

                //Execute command
                cmd.ExecuteNonQuery();

                MessageBox.Show("Successfully saved");
                //close connection
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = true;
            groupBox3.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            connection = new MySqlConnection(ConnectionString);
            try
            {
                //open connection
                connection.Open();

                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand("update users set pword = '" + textBox10.Text + "',email = '" + textBox11.Text + "',fname = '" + textBox12.Text + "',lname = '" + textBox13.Text + "',acct_type = '" + textBox14.Text + "' where uid = '" + textBox8.Text + "'", connection);

                //Execute command
                cmd.ExecuteNonQuery();

                MessageBox.Show("Successfully updated");

                //close connection
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

            groupBox3.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            connection = new MySqlConnection(ConnectionString);
            try
            {
                //open connection
                connection.Open();

                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand("delete from users where uid = '" + textBox9.Text + "'", connection);

                //Execute command
                cmd.ExecuteNonQuery();

                MessageBox.Show("Successfully deleted");

                //close connection
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
