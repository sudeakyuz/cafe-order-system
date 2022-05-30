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

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string conString = "Data Source=DESKTOP-6JDEBG2\\SQLEXPRESS;Initial Catalog=Dlogin;Integrated Security=True";

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open(); 
            if (con.State==System.Data.ConnectionState.Open)
            {
                string q = "insert into Table_1 (Name, TableNumber) values ('" + txtboxName.Text.ToString() + "','" + txtboxTablenum.Text.ToString() + "')";

                SqlCommand cmd = new SqlCommand(q,con);
              
                cmd.ExecuteNonQuery();
                MessageBox.Show("your info has been registered");
            }
            Form2 fr2 = new Form2();
            fr2.Show();
            Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 fr3 = new Form3();
            fr3.Show();
            Hide();
        }
    }
}
