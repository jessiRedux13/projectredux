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
    public partial class User : Form
    {
        private MySqlConnection connection;
        String ConnectionString = "Server=192.168.0.24;Database=inventory_food_meds;Uid=jes;Pwd=!ojt2015";
        public User()
        {
            InitializeComponent();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            connection = new MySqlConnection(ConnectionString);

            try
            {
               
                connection.Open();
                MessageBox.Show("connected");               
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            connection = new MySqlConnection(ConnectionString);
            try
            {
                
                connection.Open();
              
                MySqlCommand cmd = new MySqlCommand("update users set badge_no = '"+textBox10.Text + "',email = '" + textBox11.Text + "',fname = '" + textBox12.Text + "',lname = '" + textBox13.Text + "',acct_type = '" + textBox14.Text + "' where uid = '" + textBox8.Text + "'", connection);
               
                cmd.ExecuteNonQuery();

                MessageBox.Show("Successfully updated");
                LoadAllUpdates();

                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadAllEmployee()
        {
            connection = new MySqlConnection(ConnectionString);
            dataGridView1.Rows.Clear();
            try
            {
                
                connection.Open();

                
                MySqlCommand cmd = new MySqlCommand("select * from users", connection);

                
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    dataGridView1.Rows.Add(dataReader["uid"] + "", dataReader["badge_no"] + "", dataReader["email"] + "", dataReader["fname"] + "", dataReader["lname"] + "", dataReader["acct_type"]);
                }
                
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

            connection = new MySqlConnection(ConnectionString);
            try
            {
                
                connection.Open();
              
                MySqlCommand cmd = new MySqlCommand("insert into users(badge_no,email,fname,lname,acct_type) value( '" + textBox6.Text + "','" + textBox4.Text + "','" + textBox3.Text + "','" + textBox2.Text + "','" + textBox1.Text + "')", connection);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Successfully saved");
                LoadAllEmployee();
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

           
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            connection = new MySqlConnection(ConnectionString);
            try
            {
              
                connection.Open();

               
                MySqlCommand cmd = new MySqlCommand("delete from users where uid = '" + textBox15.Text + "'", connection);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Successfully deleted");               
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 main = new Form2();
            main.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 main = new Form2();
            main.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 main = new Form2();
            main.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 main = new Form2();
            main.Show();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            textBox8.Clear();
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();
            textBox13.Clear();
            textBox14.Clear();
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox6.Clear();
            

        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox15.Clear();
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void User_Load(object sender, EventArgs e)
        {
            LoadAllEmployee();
            LoadAllUpdates();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
        private void LoadAllUpdates()
        {
            connection = new MySqlConnection(ConnectionString);
            dataGridView2.Rows.Clear();
            try
            {
                //open connection
                connection.Open();

                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand("select * from users", connection);

                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    dataGridView2.Rows.Add(dataReader["uid"] + "", dataReader["badge_no"] + "", dataReader["email"] + "", dataReader["fname"] + "", dataReader["lname"] + "", dataReader["acct_type"]);
                }
                //close connection
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
       }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        
    }
   }

