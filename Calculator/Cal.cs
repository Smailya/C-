using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        int n1, n2, re;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            if (rdSub.Checked)
            {
                btnAdd.Visible = false;
                btnMu.Visible = false;
            }

            n1 = (Convert.ToInt32(txt1.Text));
            n2 = (Convert.ToInt32(txt2.Text));
            re = n1 - n2;
            MessageBox.Show("the result is: " + re);

            
        }

        private void btnMu_Click(object sender, EventArgs e)
        {
            if (rdMul.Checked)
            {
                btnAdd.Visible = false;
                btnSub.Visible = false;
            }
            n1 = (Convert.ToInt32(txt1.Text));
            n2 = (Convert.ToInt32(txt2.Text));
            re = n1 * n2;
            MessageBox.Show("the result is: " + re);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dr= MessageBox.Show("Are you sure you want to exit?", "Exit App", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                Close();
            }
            else
            {

            }
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (rdadd.Checked)
            {
                btnMu.Visible = false;
                btnSub.Visible = false;
            }
            n1 = (Convert.ToInt32(txt1.Text));
                n2 = (Convert.ToInt32(txt2.Text));
                re = n1 + n2;
                MessageBox.Show("the result is: " + re);
          

        }

        private void btnCle_Click(object sender, EventArgs e)
        {
            txt1.Text = "";
            txt2.Text = "";

            btnAdd.Visible = true;
            btnMu.Visible = true;
            btnSub.Visible = true;
         

        }
    }
}
