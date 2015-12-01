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
    public partial class colds : Form
    {
        public colds()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void colds_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            

            if (checkBox1.Checked)
            {
                panel2.Visible = true;
                panel1.Visible = false;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your request has beeen recorded!");
        }
    }
}
