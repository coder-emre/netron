using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

namespace DataGridViewOrnek
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            //NewValues : Yeni girilen değerler
            
            if (e.NewValues["KITAP"]==null || e.NewValues["KITAP"].Equals(""))
            {
                e.Cancel = true; // eğer şart sağlanmıyorsa Update işlemini iptal et ve uyarı ver.
                Response.Write("Kitap Adı Boş Geçilemez");
            }
            else
            {
                e.Cancel = false;//Bundan sonra ki event olan Updated ı çalıştır.
                //Seçilen satır içinde sonradan eklenen fileUpload nesnesine erişim ğlıyorum.zaten oluşmuş olan bir nesne olduğu için new ifadesi ile set etmiyoruz.
                FileUpload fupl = (FileUpload)(GridView1.Rows[e.RowIndex].FindControl("FileUpload1"));// as FileUpload;//as ifadesi ile bulunan kontrolu bir başka tipe eşitliyebilirsiniz.

                string DosyaAdi = fupl.FileName;//seçilen dosyaadını al.
                Session["ResimAdresi"] ="images/" + DosyaAdi;//Session a eşitle.

                DosyaKopyala(fupl.PostedFile.FileName, Server.MapPath("images/" + DosyaAdi));
            }
        }
        private void DosyaKopyala(string Kaynak, string Hedef)
        {
            System.IO.File.Copy(Kaynak, Hedef);
        }
      
    }
}
