﻿using MySql.Data.MySqlClient;
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
    public partial class products : Form
    {
        public string categorymodule = string.Empty;
        private MySqlConnection connection;
        String ConnectionString = "Server=192.168.0.24;Database=inventory_food_meds;Uid=jes;Pwd=!ojt2015";
        public products()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void colds_Load(object sender, EventArgs e)
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
                MySqlCommand cmd = new MySqlCommand("SELECT product_info.pid, product_info.p_name FROM category Inner Join product_info ON category.cid = product_info.cat_FK where category.cat_name = '" + categorymodule + "'", connection);

                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    dataGridView1.Rows.Add(dataReader["pid"], dataReader["p_name"]);
                }

                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }   
               
        private void productOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Selected == true)
                {
                    string qtyout = Microsoft.VisualBasic.Interaction.InputBox("Input quantity", " ", "");
                    dataGridView2.Rows.Add(row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString(), qtyout);
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Rows[e.RowIndex].Selected = true;
        }

        private void btncheckout_Click(object sender, EventArgs e)
        {
            connection = new MySqlConnection(ConnectionString);
            try
            {

                connection.Open();

                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() != string.Empty)
                    {
                        MySqlCommand cmd = new MySqlCommand("insert into Stock_status(pid,Unit_out_stock) value('" + row.Cells[0].Value.ToString() + "','" + row.Cells[2].Value.ToString() + "')", connection);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Successfully saved");
                    } 
                    //else
                    //{
                    //    checkoutfailed();
                    //}
                  
                   
                    
                }
             
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
                   
        }
        //private void checkoutfailed()
        //{
        //    int totalstock = 0;
        //    connection = new MySqlConnection(ConnectionString);
        //    try
        //    {

        //        connection.Open();
        //        foreach (DataGridViewRow row in dataGridView2.Rows)
        //        {
        //            MySqlCommand cmd = new MySqlCommand("SELECT T2.Prod_Added_Date,T1.p_name,SUM(Unit_in_stock) AS total_in,SUM(Unit_out_stock) AS total_out,(SUM(Unit_in_stock) - SUM(Unit_out_stock)) as Total_stock  FROM product_info AS T1 Inner Join Stock_status AS T2 , category where  T1.pid =  T2.pid AND T1.cat_FK =  category.cid GROUP BY T2.pid ORDER BY T2.Prod_Added_Date ASC", connection);

        //            MySqlDataReader dataReader = cmd.ExecuteReader();

        //            while (dataReader.Read())
        //            {


        //                totalstock = dataReader.GetInt32("Total_stock");
        //            }

        //            connection.Close();

        //            if (totalstock <= 0)
        //            {
        //                MessageBox.Show("Stock is empty");
        //            }

        //        }

        //    }
        //    catch (Exception)
        //    {
        //        MessageBox.Show("");
        //    }
        //}

      
     }
  }

