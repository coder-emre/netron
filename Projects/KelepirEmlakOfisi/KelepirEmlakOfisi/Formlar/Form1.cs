using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using KelepirEmlakOfisi.Kontroller;
using KelepirEmlakOfisi.Siniflar;

namespace KelepirEmlakOfisi
{
    public partial class frm_anakelepir : Form
    {
        int sayac = 0;

        public frm_anakelepir()
        {
            InitializeComponent();
        }

        private void timer_yuklebar_Tick(object sender, EventArgs e)
        {
            if (sayac <= 10)
            {
                pbar_acilis.Value = sayac;              
            }

            sayac++;

            if (sayac == 11)
            {
                pnl_icerik.Controls.Clear(); //panelin içindeki eski ontroller silindi
                UC_Musteriler Musteriler = new UC_Musteriler(); //user kontrolün bir kopyası oluşturuldu
                Musteriler.lblMusteriSayisi = lbl_musterisayisi;
                pnl_icerik.Controls.Add(Musteriler); // oluşan kontrol panel içine ekleniyor
                Musteriler.Dock = DockStyle.Fill;
            }
        }
        
        private void frm_anakelepir_Load(object sender, EventArgs e)
        {
            Dizi BilgiGetir = new Dizi();
            lbl_musterisayisi.Text = BilgiGetir.musteriSay().ToString();
        }
       
        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            switch (e.Node.Name)
            { case "nd_kullanicilar":
                    
                pnl_icerik.Controls.Clear(); //panelin içindeki eski ontroller silindi
                UC_Musteriler Musteriler = new UC_Musteriler(); //user kontrolün bir kopyası oluşturuldu
                Musteriler.lblMusteriSayisi = lbl_musterisayisi;
                pnl_icerik.Controls.Add(Musteriler); // oluşan kontrol panel içine ekleniyor
                Musteriler.Dock = DockStyle.Fill;
            break;
            default:
            break;            
            }          
        }
    }
}