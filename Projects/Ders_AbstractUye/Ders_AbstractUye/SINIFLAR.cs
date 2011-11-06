using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;//Access için
using System.Data.SqlClient;//SQL server için
namespace Ders_AbstractUye
{
    abstract class TEMELISLEMLER
    {
        protected string hataAciklama;
        public abstract void kaydet(); 
    }
    class KITAPLAR:TEMELISLEMLER
    {
        private string _kitap;
        private string _kitapYazari;
        public string Kitap
        {
            get { return _kitap; }
            set { _kitap = value; }
        }
        public string KitapYazari
        {
            get { return _kitapYazari; }
            set { _kitapYazari = value; }
        }
        public override void kaydet()
        {
            try
            {
                SqlConnection conn = new SqlConnection("Server=.;Database=Test;trusted_connection=yes");
                SqlCommand cmd = new SqlCommand("Insert ...", conn);
                cmd.Parameters.AddWithValue("@KITAP", this.Kitap);
                cmd.Parameters.AddWithValue("@KITAPYAZAR", this.KitapYazari);
                conn.Open();
                cmd.ExecuteNonQuery();

                cmd.Dispose();
                conn.Close();
            }
            catch (Exception ex)
            {
                hataAciklama = ex.Message;             
            }
        }
    }
    class YAZARLAR:TEMELISLEMLER
    {
        private string _yazar;
        public string Yazar {
            get { return _yazar; }
            set { _yazar = value; }
        }
        public override void kaydet()
        {
            try
            {
                 
                OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\mydatabase.mdb;User Id=admin;Password=;");
                OleDbCommand cmd = new OleDbCommand("INSERT ...", conn);
                cmd.Parameters.AddWithValue("@YAZAR", this.Yazar);
                conn.Open();
                cmd.ExecuteNonQuery();

                cmd.Dispose();
                conn.Close();
            }
            catch (Exception ex)
            {
                hataAciklama = ex.Message;
            }

        }
      
    }
}
