using CrystalDecisions.CrystalReports.Engine;
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
    public partial class formviewer : Form
    {
       

        public formviewer()
        {
            InitializeComponent();
        }

        private void formviewer_Load(object sender, EventArgs e)
        {

           
        }

        private void btnloadreport_Click(object sender, EventArgs e)
        {
            ReportDocument myReport = new ReportDocument();
            DataSet myData = new DataSet();
            MySqlConnection conn = new MySqlConnection();
            MySqlCommand cmd = new MySqlCommand();
            MySqlDataAdapter myAdapter = new MySqlDataAdapter();

            conn.ConnectionString = "Server=192.168.0.24;Database=inventory_food_meds;Uid=jes;Pwd=!ojt2015";

            try
            {
                DataTable dt = new DataTable();
                dt.TableName = "DataTable1";

                cmd.CommandText = "SELECT T2.Prod_Added_Date,T1.p_name,SUM(Unit_in_stock) AS total_in,SUM(Unit_out_stock) AS total_out,(SUM(Unit_in_stock) - SUM(Unit_out_stock)) as Total_stock,T1.Reorder_level FROM product_info AS T1 Inner Join Stock_status AS T2 , category where date(Prod_Added_Date) >=  '" + datefrom.Value.ToString("yyyy-MM-dd") + "' AND date(Prod_Added_Date) <=  '" + dateto.Value.ToString("yyyy-MM-dd") + "' AND  ctype= '" + cbocategory.Text + " ' AND T1.pid =  T2.pid AND T1.cat_FK =  category.cid GROUP BY T2.pid ORDER BY T2.Prod_Added_Date ASC";
                cmd.Connection = conn;

                myAdapter.SelectCommand = cmd;
                myAdapter.Fill(dt);

                myData.Tables.Add(dt);

                string reportPath = @"C:\Users\OJT\projectredux\WindowsFormsApplication3\WindowsFormsApplication3\generalreport.rpt";
                myReport.Load(reportPath);
                myReport.SetDataSource(myData);
                crystalReportViewer1.ReportSource = myReport;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Report could not be created",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnlistpurchase_Click(object sender, EventArgs e)
        {
            ReportDocument myReport = new ReportDocument();
            DataSet myData = new DataSet();
            MySqlConnection conn = new MySqlConnection();
            MySqlCommand cmd = new MySqlCommand();
            MySqlDataAdapter myAdapter = new MySqlDataAdapter();

            conn.ConnectionString = "Server=192.168.0.24;Database=inventory_food_meds;Uid=jes;Pwd=!ojt2015";

            try
            {
                DataTable dt = new DataTable();
                dt.TableName = "DataTable1";

                cmd.CommandText = "SELECT T2.Prod_Added_Date,T1.p_name,SUM(Unit_in_stock) AS total_in,SUM(Unit_out_stock) AS total_out,(SUM(Unit_in_stock) - SUM(Unit_out_stock)) as Total_stock,T1.Reorder_level FROM product_info AS T1 Inner Join Stock_status AS T2 , category where date(Prod_Added_Date) >=  '" + datefrom.Value.ToString("yyyy-MM-dd") + "' AND date(Prod_Added_Date) <=  '" + dateto.Value.ToString("yyyy-MM-dd") + "' AND  ctype= '" + cbocategory.Text + " ' AND T1.pid =  T2.pid AND T1.cat_FK =  category.cid GROUP BY T2.pid HAVING  Total_stock <=  Reorder_level ORDER BY T2.Prod_Added_Date ASC ";
                cmd.Connection = conn;

                myAdapter.SelectCommand = cmd;
                myAdapter.Fill(dt);

                myData.Tables.Add(dt);

                string reportPath = @"C:\Users\OJT\projectredux\WindowsFormsApplication3\WindowsFormsApplication3\generalreport.rpt";
                myReport.Load(reportPath);
                myReport.SetDataSource(myData);
                crystalReportViewer1.ReportSource = myReport;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Report could not be created",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


      }
          
}
