using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ( textBox1.Text =="" || textBox2.Text=="")
            {
                MessageBox.Show("enter username and password !!!");
            }
            else
            {
                if (textBox1.Text=="sude" && textBox2.Text == "123" )
                {
                    Form4 frm4 = new Form4();
                    frm4.Show();
                    Hide();

                }
                else
                {
                    MessageBox.Show("Wrong Username or Password");
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
