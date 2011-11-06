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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("server=MIAMI;Database=EVKUR;Trusted_connection=yes");
        SqlCommand cmd;
        SqlCommand cmd2;
        SqlDataAdapter adp;
        DataSet ds = new DataSet();
        
        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                this.eVKURDataSet1.TBL_STOKKARTLARI.Rows.Clear();
                cmd = new SqlCommand();
                
                cmd.CommandText = "INSERT TBL_STOKKARTLARI VALUES(@ACIKLAMA,@BIRIMFIYAT)";
                cmd.Parameters.AddWithValue("@ACIKLAMA", txt_aciklama.Text);
                cmd.Parameters.AddWithValue("@BIRIMFIYAT", txt_birimfiyat.Text);
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();

                adp = new SqlDataAdapter("Select * FROM TBL_STOKKARTLARI", conn);
                adp.Fill(this.eVKURDataSet1.TBL_STOKKARTLARI);
                stokliste.DataSource = this.eVKURDataSet1.TBL_STOKKARTLARI;
           
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

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eVKURDataSet1.TBL_STOKKARTLARI' table. You can move, or remove it, as needed.
            this.tBL_STOKKARTLARITableAdapter.Fill(this.eVKURDataSet1.TBL_STOKKARTLARI);

        }

       

        private void stokliste_SelectionChanged(object sender, EventArgs e)
        {
            
                txt_aciklama.Text = stokliste.CurrentRow.Cells[1].Value.ToString();
                txt_birimfiyat.Text = stokliste.CurrentRow.Cells[2].Value.ToString();
            
         }

        private void btn_sil_Click(object sender, EventArgs e)
        {
              int index = Convert.ToInt32(stokliste.CurrentRow.Cells[0].Value.ToString());     
            try
            {
                this.eVKURDataSet1.TBL_STOKKARTLARI.Rows.Clear();
                cmd2 = new SqlCommand();
                conn.Open();
                cmd2.CommandText = "select * FROM TBL_STOKKARTLARI";
                cmd2.Parameters.AddWithValue("@ACIKLAMA", txt_aciklama.Text);
                cmd2.Parameters.AddWithValue("@BIRIMFIYAT", txt_birimfiyat.Text);
                cmd2.Connection = conn;
                cmd2.ExecuteNonQuery();
                adp = new SqlDataAdapter("DELETE FROM TBL_STOKKARTLARI WHERE STOKREFERANS="+index, conn);
                adp.Fill(this.eVKURDataSet1.TBL_STOKKARTLARI);
                stokliste.DataSource = this.eVKURDataSet1.TBL_STOKKARTLARI;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());

            }
            finally
            {
                cmd2.Dispose();
                conn.Close();
            }
        }

      
       
    }
}
