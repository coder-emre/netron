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

        private void button2_Click_1(object sender, EventArgs e)
        {
            FormuTemizle();
        }
        private void FormuTemizle()
        {
            txt_Fiyat.Clear();
            txt_Kitap.Clear();
            txt_Yazar.Clear();
            txt_Yayinevi.Clear();
            lbl_KitapID.Text = "-1";
            txt_Kitap.Focus();
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            if(lbl_KitapID.Text.Equals("-1"))// kayıt eklenecek
            {
                DataRow drow=ds.Tables["Kitaplar"].NewRow;// data setten kitapları aldı sonra viewdan datagride geçti
                drow["KITAP"]=txt_Kitap.Text;
                drow["YAZAR"]=txt_Yazar.Text;
                drow["YAYINEVI"] = txt_Yayinevi.Text;
                drow["FİYAT"] = txt_Fiyat.Text;
                ds.Tables["Kitaplar"].Rows.Add(drow);
            }
            else// güncelleme yapılacak
            {
                dv.RowFilter = "KITAPID=" + lbl_KitapID.Text;
                if (dv.Count > 0)
                { dv[0]["KİTAP"]=txt_Kitap.Text;
                dv[0]["YAZAR"] = txt_Yazar.Text;
                        dv[0]["YAYINEVI"]=txt_Yayınevi.Text;
                        dv[0]["FİYAT"] = txt_Fiyat.Text;

                }
                dv.RowFilter = null;
                //database üzerinde update yapabilmek için
                ds.Tables["KITAPLAR"];
            }
            
        }

    }
}
