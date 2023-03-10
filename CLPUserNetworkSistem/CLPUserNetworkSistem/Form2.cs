using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLPUserNetworkSistem
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close(); 
            Form form1 = new Form1();
            form1.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void b_ShowPassW_CheckedChanged(object sender, EventArgs e)
        {
            if (b_ShowPassY.Checked)
            {
                b_Pass.UseSystemPasswordChar = false;
                c_Pass.UseSystemPasswordChar = false;
            }
            else
            {
                b_Pass.UseSystemPasswordChar = true;
                c_Pass.UseSystemPasswordChar = true;
            }
        }
    }
}
