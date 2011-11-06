using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using KelepirEmlakOfisi.Siniflar;

namespace KelepirEmlakOfisi.Kontroller
{
    public partial class UC_Musteriler : UserControl
    {
        Dizi bilgidoldur = new Dizi();
        public Label lblMusteriSayisi;

        public UC_Musteriler()
        {
            InitializeComponent();
        }
        
        private void UC_Musteriler_Load(object sender, EventArgs e)
        {
            bilgidoldur.dosyayolu = Application.StartupPath;
            cmb_sehir.DataSource = bilgidoldur.sehirdoldur();
        }

        private void cmb_sehir_SelectedIndexChanged(object sender, EventArgs e)
        {
            int sehirID = (bilgidoldur.SehirIDGetir(cmb_sehir.SelectedItem.ToString()));
            //MessageBox.Show(sehirID.ToString());
            cmd_semt.DataSource = bilgidoldur.semtdoldur(sehirID);
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            bilgidoldur.MusteriKaydet(txt_adsoyad.Text, txt_telefon.Text, cmb_sehir.SelectedItem.ToString(), cmd_semt.SelectedItem.ToString(), txt_adres.Text);
            lblMusteriSayisi.Text = bilgidoldur.musteriSay().ToString();

            if (bilgidoldur.hataDurumu == false)
            {
                MessageBox.Show("Kayit basarili");
            }
            else
            {
                MessageBox.Show("Kayıtta hata oldu!");
            }
        }

        private void btn_yeni_Click(object sender, EventArgs e)
        {
            FormuTemizle();
        }

        void FormuTemizle()
        {
            txt_adres.Clear();
            txt_adsoyad.Clear();
            txt_telefon.Clear();
            cmb_sehir.SelectedIndex = 0;
            cmd_semt.SelectedIndex = -1;

            txt_adsoyad.Focus(); //cursor adsoyada gitsin
        }
    }
}