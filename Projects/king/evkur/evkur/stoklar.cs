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
    public partial class stoklar : Form
    {
        public stoklar()
        {
            InitializeComponent();
        }
        int index=-1;
        private void stoklar_Load(object sender, EventArgs e)
        {
            
            this.datagridd();
            
        }
        
        private void btb_kaydet_Click(object sender, EventArgs e)
        {
            this.kaydet();         
        }

        private void datagridd ()
        {
            SqlConnection con = new SqlConnection("server=MIAMI;database=evkur;trusted_connection=yes");
            SqlDataAdapter dat = new SqlDataAdapter("select * from tbl_urunleri", con);
            DataSet ds=new DataSet();
            dat.Fill(ds, "urunler");
            this.dataGridView1.DataSource = ds.Tables[0];
            index = -1;
        }

        private void kaydet()
        {
            SqlConnection con = new SqlConnection("server=MIAMI;database=evkur;trusted_connection=yes");
            string adi = this.txt_stok.Text;
            string fiyat = this.txt_money.Text;
            if (index == -1)
            {
                
                try
                {
                    int z = Convert.ToInt32(fiyat);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("numerik değerler kullan");
                    return;
                }

                SqlDataAdapter dat = new SqlDataAdapter("select * from tbl_urunleri", con);
                DataSet ds = new DataSet();
                dat.Fill(ds, "hede");
                int a = ds.Tables[0].Rows.Count;
                a++;
                SqlCommand cmd = new SqlCommand("insert into tbl_urunleri values(" + a + ",'" +
                    adi + "'," + fiyat + ")", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                this.datagridd();
            }
            else
            {
                
                SqlCommand cmd = new SqlCommand("update tbl_urunleri set urunadi=@ad,fiyat = @fiyat where urunid=" + index, con);
                cmd.Parameters.AddWithValue("@ad", adi);
                cmd.Parameters.AddWithValue("@fiyat", fiyat);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                this.datagridd();
            }
        }

        
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
             this.txt_stok.Text=this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
             this.txt_money.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
             index = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("server=MIAMI;database=evkur;trusted_connection=yes");
            SqlCommand cmd = new SqlCommand("delete from tbl_urunleri where urunid=" + index,con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            this.datagridd();
            index = -1;
        }
    }
}
