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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void btnCloser_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'daza11DataSet.Tablica' table. You can move, or remove it, as needed.
            this.tablicaTableAdapter.Fill(this.daza11DataSet.Tablica);
            // TODO: This line of code loads data into the 'danni1DataSet.Danni' table. You can move, or remove it, as needed.


        }

        private void btnAdding_Click(object sender, EventArgs e)
        {
            //tablicaBindingSource.AddNew();
            daza11DataSet.Tablica.AddTablicaRow(txtBoxNameSong.Text,txtProducing.Text,txtNaming.Text,int.Parse(txtGifting.Text),int.Parse(txtDating.Text),txtBoxArtist.Text);
        }

        private void btnDeleting_Click(object sender, EventArgs e)
        {
            tablicaBindingSource.RemoveCurrent();
        }

        private void btnSaving_Click(object sender, EventArgs e)
        {
            tablicaBindingSource.MoveNext();
            tablicaBindingSource.EndEdit();
            tablicaTableAdapter.Update(daza11DataSet.Tablica);
            MessageBox.Show("Record saved!");
        }
    }
}
