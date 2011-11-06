using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            MessageBox.Show("giriş yapılacak");
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("cıkmak istediğinzden emin misiniz?", "soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (sonuc == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {  
                MessageBox.Show("yardım penceresini açıyorm");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frm_SifremiUnuttum frmSifre = new Frm_SifremiUnuttum();
            frmSifre.Show();
        }

      
       

    }
}
