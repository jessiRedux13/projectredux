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
using System.IO;

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
           
        }
        private void loadreport()
        {
            connection = new MySqlConnection(ConnectionString);
            dgvreport.Rows.Clear();
            try
            {
                //open connection
                connection.Open();

                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(" SELECT T2.Prod_Added_Date,T1.p_name,SUM(Unit_in_stock),SUM(Unit_out_stock),(SUM(Unit_in_stock) - SUM(Unit_out_stock)) as Total_stock,T1.Reorder_level FROM product_info AS T1 Inner Join Stock_status AS T2 , category where ctype= '" + cbocattype.Text + " ' AND T1.pid =  T2.pid AND T1.cat_FK =  category.cid GROUP BY T2.pid", connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    dgvreport.Rows.Add(dataReader["Prod_Added_Date"] + "", dataReader["p_name"] + "", dataReader["SUM(Unit_in_stock)"] + "", dataReader["SUM(Unit_out_stock)"] + "", dataReader["Total_stock"] + "", dataReader["Reorder_level"] + "");
                }

                //close connection
                connection.Close();
                ValidateReorderpoint();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ValidateReorderpoint()
        {
            foreach (DataGridViewRow row in dgvreport.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() != string.Empty)
                {
                    if (Convert.ToInt32(row.Cells[4].Value.ToString()) <= Convert.ToInt32(row.Cells[5].Value.ToString()))
                    {
                        row.DefaultCellStyle.BackColor = Color.Red;
                    }
                    
                }              
            }
        }
        private void ToCsV(DataGridView dgvreport, string filename)
        {
         
            string stOutput = "";
            // Export titles:
            string sHeaders = "";
          
            for (int j = 0; j < dgvreport.Columns.Count; j++)
                sHeaders = sHeaders.ToString() + Convert.ToString(dgvreport.Columns[j].HeaderText) + "\t";
            stOutput += sHeaders + "\r\n";
            // Export data.
            for (int i = 0; i < dgvreport.RowCount - 1; i++)
            {
                string stLine = "";
                for (int j = 0; j < dgvreport.Rows[i].Cells.Count; j++)
                    stLine = stLine.ToString() + Convert.ToString(dgvreport.Rows[i].Cells[j].Value) + "\t";
                stOutput += stLine + "\r\n";
            }
            Encoding utf16 = Encoding.GetEncoding(1254);
            byte[] output = utf16.GetBytes(stOutput);
            FileStream fs = new FileStream(filename, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(output, 0, output.Length); //write the encoded file
            bw.Flush();
            bw.Close();
            fs.Close();
        }


        private void btneExport_Click(object sender, EventArgs e)
        {
            
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Excel Documents (*.xls)|*.xls";
                sfd.FileName = "Report.xls";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                     //ToCsV(dataGridView1, @"c:\export.xls")
                   ToCsV(dgvreport, sfd.FileName); // Here dataGridview1 is your grid view name
                    
                }
              
            
        }

        private void loadmonthlyreport()
        {
            connection = new MySqlConnection(ConnectionString);
            dgvreport.Rows.Clear();
            try
            {
                //open connection
                connection.Open();

                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(" SELECT T2.Prod_Added_Date,T1.p_name,SUM(Unit_in_stock),SUM(Unit_out_stock),(SUM(Unit_in_stock) - SUM(Unit_out_stock)) as Total_stock,T1.Reorder_level FROM product_info AS T1 Inner Join Stock_status AS T2 , category where date(Prod_Added_Date) >=  '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "' AND date(Prod_Added_Date) <=  '" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "' AND  ctype= '" + cbocattype.Text + " ' AND T1.pid =  T2.pid AND T1.cat_FK =  category.cid GROUP BY T2.pid", connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    dgvreport.Rows.Add(dataReader["Prod_Added_Date"] + "", dataReader["p_name"] + "", dataReader["SUM(Unit_in_stock)"] + "", dataReader["SUM(Unit_out_stock)"] + "", dataReader["Total_stock"] + "", dataReader["Reorder_level"] + "");
                }

                //close connection
                connection.Close();
                ValidateReorderpoint();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
             

        private void cbocattype_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadreport();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            loadmonthlyreport();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            loadmonthlyreport();
        }
        private void listpurchase(DataGridView dgvreport, string filename)
        {
       
        }

        private void btnlistpurchase_Click(object sender, EventArgs e)
        {
           
           
        }

        private void btncrystalreport_Click(object sender, EventArgs e)
        {
            
            formviewer fv = new formviewer();
            fv.Show();
    
        }

    
}
}

    
