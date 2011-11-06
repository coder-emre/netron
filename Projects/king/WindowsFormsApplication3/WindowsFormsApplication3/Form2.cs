using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void sIPARISKARTLARIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 menu = new Form3();
            menu.Show();
            this.Hide();
        }
    }
}
