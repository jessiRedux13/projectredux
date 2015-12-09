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
    public partial class Gen_Report : Form
    {
        private MySqlConnection connection;
        String ConnectionString = "Server=192.168.0.24;Database=inventory_food_meds;Uid=jes;Pwd=!ojt2015";
        public Gen_Report()
        {
            InitializeComponent();
        }

        private void Gen_Report_Load(object sender, EventArgs e)
        {
            connection = new MySqlConnection(ConnectionString);
            dgvreport.Rows.Clear();
            try
            {
                //open connection
                connection.Open();

                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand("select * from Stock_status ", connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    dgvreport.Rows.Add(dataReader["Pro_Added_Date"] + "", dataReader["Unit_in_stock"] + "", dataReader["Unit_out_stock"] + "", dataReader["Purchase_price"] + "");
                }
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
    
