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
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
            userControl21.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userControl21.Show();
             userControl21.BringToFront();
           
        }

        private void btnBacks_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
