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
    public partial class Manage_inventory : Form
    {
        private MySqlConnection connection;
        String ConnectionString = "Server=192.168.0.24;Database=inventory_food_meds;Uid=jes;Pwd=!ojt2015";
        public Manage_inventory()
        {
            InitializeComponent();
        }

        private void Product_id()
        {
            connection = new MySqlConnection(ConnectionString);

            try
            {
                //open connection
                connection.Open();

                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand("select * from product_info", connection);

                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                   cbopid_pname.Items.Add(dataReader["pid"] + "|" + dataReader["p_name"]);
                  

                }
                //close connection
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Manage_inventory_Load(object sender, EventArgs e)
        {
            Product_id();
        }

        private void LoadAllproduct()
        {
            connection = new MySqlConnection(ConnectionString);
            dgvmanage.Rows.Clear();
            try
            {
                //open connection
                connection.Open();
               // string[] p_id = cbopid2.Text.Split(new char[] { '|' });
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand("select * from Stock_status where date(Prod_Added_Date)='"+dateTimePicker2.Value.ToString("yyyy-MM-dd")+"' ", connection);

                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    dgvmanage.Rows.Add(dataReader["pid"] + "", dataReader["Unit_in_stock"] + "", dataReader["Unit_out_stock"] + "", dataReader["Purchase_price"] + "", Convert.ToDateTime(dataReader["expired_date"]).ToString("yyyy-MM-dd"), dataReader["Prod_Added_Date"] + "");
                }
                //close connection
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnload_Click(object sender, EventArgs e)
        {
           
        }

        private void insertStock_status()
        {
            connection = new MySqlConnection(ConnectionString);
            try
            {

                connection.Open();

                MySqlCommand cmd = new MySqlCommand("insert into Stock_status(pid,Unit_in_stock,Unit_out_stock,Purchase_Price,Expired_Date) value('"+cbopid_pname.Text+"','" + txtboxU_in.Text + "','" + txtboxU_out.Text + "','" + txtboxp_price.Text + "','" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "')", connection);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Successfully saved");

                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void Subtract()
        {
            
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            insertStock_status();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            LoadAllproduct();
        }

       
        

  

       

    }
}
