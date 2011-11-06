using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("server=LG-PC;Database=EVKUR;Trusted_connection=yes");
        SqlCommand cmd;

        private void btn_giris_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand();
                //cmd.CommandText = "SELECT COUNT(*) FROM TBL_KULLANICILAR WHERE KULLANICIADI='" + txt_kontrol_ad.Text +"' AND SIFRE='" + txt_kontrol_sifre.Text + "'";
                //veya

                cmd.CommandText = "SELECT COUNT(*) FROM TBL_KULLANICILAR WHERE KULLANICIADI=@KADI AND SIFRE=@KSIFRE";
                cmd.Parameters.AddWithValue("@KADI", txt_kontrol_ad.Text);
                cmd.Parameters.AddWithValue("@KSIFRE", txt_kontrol_sifre.Text);

                cmd.Connection = conn;

                sbyte KayitSayisi = sbyte.Parse(cmd.ExecuteScalar().ToString());

                if (KayitSayisi == 1)
                {
                  Form2 menu=new Form2();
                  menu.Show();
                  this.Hide();

                }
                else
                {
                    
                    MessageBox.Show("YANLIŞ KULLANICI ADI VE ŞİFRE!!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());

            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }

        }

     
      
    }
}
