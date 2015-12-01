using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\OJT\projectredux\WindowsFormsApplication1\WindowsFormsApplication1\Database1.mdf;Integrated Security=True");
        SqlCommand cmd =new SqlCommand();
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            cmd.Connection = con;
            loadlist();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text !="" && textBox2.Text !="" && textBox3.Text!="")
            {
                con.Open();
                cmd.CommandText = "Insert into info [ID],[Username],[Department] values,"+textBox1.Text+textBox2.Text+textBox3.Text;
                cmd.ExecuteNonQuery();
                cmd.Clone();
                MessageBox.Show("Record Inserted!");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                loadlist();

            }
        }
        private void loadlist ()
        {
            SqlDataReader dr;
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            con.Open();
            cmd.CommandText = "Select * from Database1";
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    listBox1.Items.Add(dr[0].ToString());
                    listBox2.Items.Add(dr[1].ToString());
                    listBox3.Items.Add(dr[2].ToString());

                }
            }
            con.Close();
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;
            if(l.SelectedIndex !=-1)
            {
                listBox1.SelectedIndex = l.SelectedIndex;
                listBox2.SelectedIndex = l.SelectedIndex;
                listBox3.SelectedIndex = l.SelectedIndex;
            }
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {

        }

    }
}
