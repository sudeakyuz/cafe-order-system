using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace WinFormsApp1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        ArrayList list = new ArrayList();

        private void button1_Click(object sender, EventArgs e)
        {
            list.Add(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach(var stuff in list)
            {
                listBox1.Items.Add(stuff);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Stuff capacity = " + list.Count);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            list.Remove(listBox1.SelectedItems);
            MessageBox.Show("Selected element is deleted");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            bool find;

                find= list.Contains(textBox2.Text);
            if(find== true)
            {
                MessageBox.Show("Searched stuff is in the list.");
            }
            else
            {
                MessageBox.Show("Searched stuff is not in the list.");
            }
        }
    }
}
