using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Ders_AdonetOffline
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
        DataView dv;
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kITAPCIDataSet.KITAPLAR' table. You can move, or remove it, as needed.
           
            this.Text = ConfigurationSettings.AppSettings["FirmaAdi"];
            adp = new SqlDataAdapter("Select * From KITAPLAR ORDER BY KITAP", conn);
           
            adp.Fill(ds, "Kitaplar");

            dv = new DataView(ds.Tables["Kitaplar"]);

            dg_Kitaplar.DataSource = dv;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder cbuild = new SqlCommandBuilder(adp);
            adp.Update(ds, "Kitaplar");
            MessageBox.Show("Eşleşme işlemi tamamlanmıştır");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            
        }

        private void txt_Arama_TextChanged(object sender, EventArgs e)
        {
            dv.RowFilter = "KITAP like '" + txt_Arama.Text + "%' or YAZAR LIKE '" + txt_Arama.Text + "%' or YAYINEVI LIKE '" + txt_Arama.Text + "%'";
            lbl_Sonuc.Text = "Arama Sonucunda " + dv.Count.ToString() + " Kayıt Bulundu";
        }

        private void dg_Kitaplar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex>=0)
            {
                  txt_Kitap.Text= dg_Kitaplar.Rows[e.RowIndex].Cells["KITAP"].Value.ToString();
            //DİĞER YOL
           txt_Yazar.Text = dg_Kitaplar.CurrentRow.Cells["YAZAR"].Value.ToString();
           txt_Yayinevi.Text = dg_Kitaplar.CurrentRow.Cells["YAYINEVI"].Value.ToString();
           txt_Fiyat.Text = dg_Kitaplar.CurrentRow.Cells["FIYAT"].Value.ToString();
           lbl_KitapID.Text = dg_Kitaplar.CurrentRow.Cells["KITAPID"].Value.ToString(); 
            }
        
        }

    }
}
