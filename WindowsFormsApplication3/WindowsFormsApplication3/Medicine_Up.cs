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

        private void Delete()
        {
            connection = new MySqlConnection(ConnectionString);
            try
            {

                connection.Open();


                MySqlCommand cmd = new MySqlCommand("delete from category where cid = '" + txtCatID.Text + "'", connection);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Successfully deleted");
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateCategory()
        {
            connection = new MySqlConnection(ConnectionString);
            try
            {

                connection.Open();

                MySqlCommand cmd = new MySqlCommand("update category set cat_name = '" + txtCatname.Text + "',ctype = '" + cboCattype.Text + "',cat_description = '" + txtCatDesc.Text + "' where  cid= '" + txtCatID.Text + "'", connection);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Successfully updated");

                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }




        private void InsertCategory()
        {
            connection = new MySqlConnection(ConnectionString);
            try
            {

                connection.Open();

                MySqlCommand cmd = new MySqlCommand("insert into category(cat_name,ctype,cat_description) value( '" + txtCatname.Text + "','" + cboCattype.Text + "','" + txtCatDesc.Text + "')", connection);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Successfully saved");

                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void LoadAllcategory()
        {
            connection = new MySqlConnection(ConnectionString);
            dgvCategory.Rows.Clear();
            try
            {
                //open connection
                connection.Open();

                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand("select * from category", connection);

                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    dgvCategory.Rows.Add(dataReader["cid"] + "", dataReader["cat_name"] + "", dataReader["cat_description"] + "", dataReader["ctype"] + "");                    
                }
                //close connection
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSaveCategory_Click(object sender, EventArgs e)
        {
            InsertCategory();
            LoadAllcategory();
        }

        private void btnCancelCategory_Click(object sender, EventArgs e)
        {
            txtCatID.Text = "";
            txtCatname.Text = "";
            cboCattype.Text = "";
            txtCatDesc.Text = "";
        }

        private void btnLoadCat_Click(object sender, EventArgs e)
        {
            LoadAllcategory();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateCategory();
            LoadAllcategory();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete();
            LoadAllcategory();
        }

        private void dgvCategory_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCatID.Text = dgvCategory.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtCatname.Text = dgvCategory.Rows[e.RowIndex].Cells[1].Value.ToString();
            cboCattype.Text = dgvCategory.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtCatDesc.Text = dgvCategory.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

       

        private void btnsave_Click(object sender, EventArgs e)
        {
            InsertProduct();
            LoadAllproduct();
        }
        private void InsertProduct()
        {
            connection = new MySqlConnection(ConnectionString);
            try
            {

                connection.Open();
                string[] cat_id = cbocategory.Text.Split(new char[] { '|' });

                MySqlCommand cmd = new MySqlCommand("insert into product_info(p_name,p_description,Reorder_level,cat_fk) value( '" + txtp_name.Text + "','" + txtp_description.Text + "','" + txtReorderlevel.Text + "','" + cat_id[0] + "')", connection);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Successfully saved");

                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void UpdateProduct()
        {
            connection = new MySqlConnection(ConnectionString);
            try
            {

                connection.Open();
                string[] cat_id = cbocategory.Text.Split(new char[] { '|' });
                MySqlCommand cmd = new MySqlCommand("update product_info set p_name = '" + txtp_name.Text + "',p_description = '" + txtp_description.Text + "',Reorder_level = '" + txtReorderlevel.Text + "',cat_FK='" + cat_id[0] + "' where  pid= '" + txtpid.Text + "'", connection);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Successfully updated");

                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void DeleteProduct()
        {
            connection = new MySqlConnection(ConnectionString);
            try
            {

                connection.Open();


                MySqlCommand cmd = new MySqlCommand("delete from product_info where pid = '" + txtpid.Text + "'", connection);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Successfully deleted");
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void btnclear_Click(object sender, EventArgs e)
        {
            txtpid.Text = "";
            txtp_name.Text = "";
            txtp_description.Text = "";
            txtReorderlevel.Text = "";
            cbocategory.Text = "";
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            UpdateProduct();
            LoadAllproduct();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            Delprod();
            LoadAllproduct();
        }
        private void LoadAllproduct()
        {
            connection = new MySqlConnection(ConnectionString);
            dgvProduct.Rows.Clear();
            try
            {
                //open connection
                connection.Open();

                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand("select * from product_info ", connection);

                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    dgvProduct.Rows.Add(dataReader["pid"] + "", dataReader["p_name"] + "", dataReader["p_description"] + "", dataReader["Reorder_level"] + "");
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
            LoadAllproduct();
        }

        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtpid.Text = dgvProduct.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtp_name.Text = dgvProduct.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtp_description.Text = dgvProduct.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtReorderlevel.Text = dgvProduct.Rows[e.RowIndex].Cells[3].Value.ToString();
          
        }
        private void Category()
        {
            connection = new MySqlConnection(ConnectionString);

            try
            {
                //open connection
                connection.Open();

                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand("select * from category", connection);

                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    cbocategory.Items.Add(dataReader["cid"] + "|" + dataReader["cat_name"]);

                }
                //close connection
                connection.Close();

            }
            catch (Exception ex)
            {
               MessageBox.Show(ex.Message);
            }
        }

        private void Medicine_Up_Load(object sender, EventArgs e)
        {
            LoadAllcategory();
            LoadAllproduct();
            Category();
        }
        private void Delprod()
        {
            connection = new MySqlConnection(ConnectionString);
            try
            {

                connection.Open();


                MySqlCommand cmd = new MySqlCommand("delete from product_info where pid = '" + txtpid.Text + "'", connection);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Successfully deleted");
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button7_Click(object sender, EventArgs e)
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

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void dgvCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }
}
