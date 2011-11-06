using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace evkur
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string adi = this.txt_adi.Text;
            string sifre = this.txt_sifre.Text;
            SqlConnection con = new SqlConnection("server=MIAMI;database=evkur;trusted_connection=yes");
            SqlCommand cmd = new SqlCommand("select count(*) from tbl_kullanicilar where adi='" + adi +
                "' and sifre='" + sifre + "'", con);
            con.Open();
            int a = Convert.ToInt32(cmd.ExecuteScalar().ToString());
            con.Close();
            if (a != 0)
            {
                menu menu = new menu();
                this.Hide();
                menu.Show();
                
            }
            



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.txt_adi.Focus();
        }
    }
}
