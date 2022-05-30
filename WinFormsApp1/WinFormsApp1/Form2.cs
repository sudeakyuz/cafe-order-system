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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            SqlConnection con = new SqlConnection(conString);
            SqlCommand com1 = new SqlCommand("Select * From Kitchen", con);
            SqlDataReader xd;
            con.Open();
            xd = com1.ExecuteReader();
            while (xd.Read())
            {
                comboxfood.Items.Add(xd["Food"]);
                comboxbevarages.Items.Add(xd["Bevarages"]);
            }
            con.Close();
        }
        public string conString = "Data Source=DESKTOP-6JDEBG2\\SQLEXPRESS;Initial Catalog=Dlogin;Integrated Security=True";




        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void savebutton2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                string q = "insert into Customer (CustomerF, CustomerB) values ('" + comboxfood.Text.ToString() + "','" + comboxbevarages.Text.ToString() + "')";

                SqlCommand cmd = new SqlCommand(q, con);

                cmd.ExecuteNonQuery();
                MessageBox.Show("You have been ordered...");
            }
            Form2 fr2 = new Form2();
            fr2.Show();
           Hide();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
