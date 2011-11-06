using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace evkur
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void stokKartlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stoklar stok = new stoklar();
            stok.Show();
         
        }

        private void menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
