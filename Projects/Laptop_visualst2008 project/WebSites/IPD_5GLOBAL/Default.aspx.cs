using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.Configuration;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Application.Lock();
        int i = int.Parse(Application["sayac"].ToString());
        i++;
        Response.Write(i.ToString());
        Application["sayac"]=i; //biz web ortamındayız birden fazla kişi aynı anda çalıştırabilir sayacı değiştirebilr o zaman aynı anda bir kişinn erişimini sağlamak lazım bu yüzden lock unlock ekledik bekliyolar kaçırmıyolar bişe
        Application.UnLock(); 
        //çalıştırdık sonra tekrar kapadık ıss açık o yüzden tutar bilgiyi tekrar açtıımızda iss i durdurduumuzda uygulama durduruldu

    }
    protected void btn_verigetir_Click(object sender, EventArgs e)
    {
        SqlConnection conn=new SqlConnection();
        //conn.ConnectionString = "Data Source=med-pc;Initial Catalog=myDataBase;Integrated Security=SSPI;";
        conn.ConnectionString = WebConfigurationManager.ConnectionStrings["IPD"].ConnectionString;
        try
        {
            conn.Open();
            Response.Write(conn.State.ToString());
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
          
        }
        finally
        {
            conn.Close();
            conn.Dispose();
            GC.Collect();
        }
    }
}
