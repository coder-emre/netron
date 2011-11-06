using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace AdoOrnek_KullaniciGiris
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("server=MIAMI;Database=NETRON08;Trusted_connection=yes");
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
                cmd.Parameters.AddWithValue("@KADI",txt_kontrol_ad.Text);
                cmd.Parameters.AddWithValue("@KSIFRE",txt_kontrol_sifre.Text);

                cmd.Connection = conn;

                sbyte KayitSayisi = sbyte.Parse(cmd.ExecuteScalar().ToString());

                     if (KayitSayisi == 1)
                    {
                        this.Height=539;
                        
                    }
                    else
                    {
                        this.Height=181;
                    MessageBox.Show("Üzgünüz! Bilgilerinize Erişemiyoruz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
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

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand();
           

                cmd.CommandText = "INSERT TBL_KULLANICILAR VALUES(@KADI,@KSIFRE)";
                cmd.Parameters.AddWithValue("@KADI", txt_adi.Text);
                cmd.Parameters.AddWithValue("@KSIFRE", txt_sifre.Text);

                cmd.Connection = conn;

                cmd.ExecuteNonQuery();

                lst_kullaniciListe.Items.Add(txt_adi.Text);

                int KayitSayisi = lst_kullaniciListe.Items.Count;
                lst_kullaniciListe.Items[KayitSayisi-1].SubItems.Add(txt_sifre.Text);
         
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

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("Select * from TBL_KULLANICILAR", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                int i = 0;
                while (dr.Read())
                {
                    lst_kullaniciListe.Items.Add(dr["KULLANICIID"].ToString());
                    lst_kullaniciListe.Items[i].SubItems.Add(dr["KULLANICIADI"].ToString());
                    lst_kullaniciListe.Items[i].SubItems.Add(dr["SIFRE"].ToString());
                    i += 1;
                }
                dr.Close();
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

        private void txt_arama_TextChanged(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("SELECT * FROM TBL_KULLANICILAR WHERE KULLANICIADI LIKE '" + txt_arama.Text + "%'", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                lst_kullaniciListe.Items.Clear();
                int i=0;
                while (dr.Read())
                {
                     lst_kullaniciListe.Items.Add(dr["KULLANICIADI"].ToString());
                    lst_kullaniciListe.Items[i].SubItems.Add(dr["SIFRE"].ToString());
                    i += 1;
                }
                dr.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
            finally
            { cmd.Dispose(); conn.Close(); }
        }
    }
}
