using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DERS_ADO_OFFLINE2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("SERVER=MIAMI;DATABASE=NETRON08;TRUSTED_CONNECTION=YES");
        SqlDataAdapter adp;
        DataSet ds=new DataSet();

        private void Form1_Load(object sender, EventArgs e)
        {
            adp = new SqlDataAdapter("Select SEHIRID,SEHIRADI FROM TBL_SEHIRLER", conn);
            adp.Fill(ds, "dt_SEHIRLER");
            cmb_sehirler.DataSource = ds.Tables[0];
            cmb_sehirler.DisplayMember = "SEHIRADI";
            cmb_sehirler.ValueMember = "SEHIRID";

           //Dataset içinde ki Tabloya Satır eklemek için
            DataRow drow = ds.Tables[0].NewRow(); //Datatable da yeni bir satır oluştu
            drow[0] = "-1"; //Satırın ilk kolonuna (SehirID) deger atadım
            drow[1] = "SEÇİNİZ";//Satırın 2. kolonuna (Sehir) deger atadım
            ds.Tables[0].Rows.Add(drow); //Satırı datatable a ekledim.

            cmb_sehirler.SelectedValue = "-1"; //Sehirler içinde value değeri -1 olanı seçili hale getirdim.



            //Dataset'e her fill yaptığımızda kendi içinde bir tablo oluşur ve index numarası artar.

           // adp = new SqlDataAdapter("Select * FROM TBL_KULLANICILAR", conn);
           // adp.Fill(ds,"dt_KULLANICILAR");
          // dataGridView1.DataSource = ds.Tables[1];



        }

        private void cmb_sehirler_SelectedIndexChanged(object sender, EventArgs e)
        {

            string SecilenSehirID =cmb_sehirler.SelectedValue.ToString();
            if (SecilenSehirID.Substring(0, 1) != "S")
            {
                adp = new SqlDataAdapter("SELECT ILCEID,ILCEADI FROM TBL_ILCELER WHERE SEHIRID=" + SecilenSehirID, conn);
                //1.Yöntem
                //DataSet dsIlceler = new DataSet();
                //adp.Fill(dsIlceler, "dt_ILCELER");

                //2.Yontem
                //DataTable dtIlceler = new DataTable();
                //adp.Fill(dtIlceler);
                //cmb_ilceler.DataSource = dtIlceler;

                //3.Yol
                if (ds.Tables["dtIlceler"] != null)
                {
                    ds.Tables["dtIlceler"].Rows.Clear();
                }

                adp.Fill(ds,"dtIlceler");
                cmb_ilceler.DataSource = ds.Tables["dtIlceler"];
                cmb_ilceler.DisplayMember = "ILCEADI";
                cmb_ilceler.ValueMember = "ILCEID";

              
            }
        }
    }
}
