using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DersAdoOffline
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nETRON08DataSet.TBL_KULLANICILAR' table. You can move, or remove it, as needed.
            this.tBL_KULLANICILARTableAdapter.Fill(this.nETRON08DataSet.TBL_KULLANICILAR);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tBL_KULLANICILARTableAdapter.Update(nETRON08DataSet);
            MessageBox.Show("Kayıtlar Veritabani ile Eşleştirilmiştir.");

        }
    }
}
