using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Data;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
        goster(-1);
    }

    private void goster(int kayitno)
    {
        SqlConnection conn = new SqlConnection();
        //   conn.ConnectionString = "Server=MED-PC;Database=IPD_OGRENCIDERS;Integrated Security=true" ;
        conn.ConnectionString = WebConfigurationManager.ConnectionStrings["connectionstring"].ConnectionString;
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = conn;
        //   cmd.CommandText = "select * from ogrenci";
        cmd.CommandText = "OgrenciSelect";
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@OgrenciId", kayitno);
        SqlDataReader dr; // satır satır kayıtları okuyor

        try
        {
            conn.Open();
            // Response.Write(conn.State.ToString());
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                TableRow tr = new TableRow();

                for (int i = 0; i < dr.VisibleFieldCount; i++)
                {
                    TableCell tc = new TableCell();
                    tc.Text = dr[i].ToString();
                    tr.Controls.Add(tc);

                }
                tbl_ogrenci.Controls.Add(tr);
            }
        }
        catch (Exception ex)
        {


        }
        finally
        {
            conn.Close();
            conn.Dispose();
            cmd.Dispose();
            GC.Collect();
        }
        // Response.Write("yazması gerekir");
    }
    protected void btn_ogrenci_Click(object sender, EventArgs e)
    {
        goster(-1);
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["connectionstring"].ConnectionString);
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "Update OGRENCI Set OGRENCI_AD='" + TextBox1.Text +
            "',OGRENCI_SOYAD='" + TextBox2.Text +
            "',OGRENCI_ADRES='" + TextBox4.Text +
            "'where OGRENCI_ID=" + TextBox3.Text;
        //scope identity yeni olusturacak id nin output parametresi olarak geri alınacağını soylüyo

    }
}
