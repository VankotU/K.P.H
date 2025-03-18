using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KontroliFormi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            userControl11.Hide();
            userControl21.Hide();
        }

        private void forma1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void kontrola1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userControl11.Show();
            userControl21.Hide();
        }

        private void kontrola2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userControl21.Show();
            userControl11.Hide();
        }

        private void btnConnectionF_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void btnConnectionK_Click(object sender, EventArgs e)
        {
            userControl11.Show();
        }

        private void btnEntrance_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "admin")
            {
                MessageBox.Show("Correct password!");
                Admin admin = new Admin();
                admin.Show();
            }
            else
            {
                MessageBox.Show("Wrong username or password!");
            }
        }
    }
}
