using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(ConfigurationSettings.AppSettings["conn"]);
        SqlDataAdapter adp;
        DataSet ds = new DataSet();

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text=ConfigurationSettings.AppSettings["FirmaAdi"];
          adp = new SqlDataAdapter("select * from KITAPLAR ORDER BY KITAP", conn);
            DataSet ds = new DataSet();
            adp.Fill(ds, "Kitaplar");
            dg_Kitaplar.DataSource=ds.Tables["Kitaplar"];

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder cbuild = new SqlCommandBuilder(adp);
            adp.Update(ds, "kitaplar");
            MessageBox.Show("Eşleşme işlemi tamamlanmıştır.");
        }
    }
}
