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
    public partial class Form1 : Form
    {
        private MySqlConnection connection;
        String ConnectionString = "Server=192.168.0.24;Database=inventory_food_meds;Uid=jes;Pwd=!ojt2015";
        public Form1()
        {
            InitializeComponent();
        }
                           
        private void badgeno(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                string accttype = "";
                int accntid = 0;
                connection = new MySqlConnection(ConnectionString);
                try
                {

                    connection.Open();
                    MySqlCommand cmd = new MySqlCommand("select * from users where badge_no='" + textBox1.Text + "'", connection);

                    MySqlDataReader dataReader = cmd.ExecuteReader();

                    while (dataReader.Read())
                    {

                        accttype = dataReader.GetString("acct_type");
                        accntid = dataReader.GetInt32("uid");
                    }

                    connection.Close();

                    if (accntid > 0)
                    {
                        this.Hide();
                        Form2 main = new Form2();
                        main.rights = accttype;
                        main.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid badge no.");
                    }

                  
                }
                catch (Exception)
                {
                    MessageBox.Show("");
                }
            }
        }       
    }
      
    
        
         
       
   }

