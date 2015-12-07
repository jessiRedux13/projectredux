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
    public partial class Report : Form
    {
        public string categorymodule = string.Empty;
        private MySqlConnection connection;
        String ConnectionString = "Server=192.168.0.24;Database=inventory_food_meds;Uid=jes;Pwd=!ojt2015";
        public Report()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Report_Load(object sender, EventArgs e)
        {
            loadProducts();
        }
        private void loadProducts()
        {
            connection = new MySqlConnection(ConnectionString);
            dataGridView1.Rows.Clear();
            try
            {
                //open connection
                connection.Open();

                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand("SELECT product_info.p_name FROM category Inner Join product_info ON category.cid = product_info.cat_FK where category.cat_name = '" + categorymodule + "'", connection);

                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    dataGridView1.Rows.Add(dataReader["p_name"] + "");
                }

                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}
