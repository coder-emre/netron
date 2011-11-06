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
using System.IO;
using System.Text;
namespace DersKontroller2
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Server.MapPath sizi uygulama klasörü içine gönderir.
            //Uygulama klasorunde ki Data klasoru içinde ki Havadurumu.txt

            //--------------------------------------
            //Literal Kontrol & Panel Kontrol Ekleme
            //--------------------------------------
            StreamReader sr = new StreamReader(Server.MapPath(@"Data/HavaDurumu.txt"),Encoding.Default);

            StringBuilder sBuilder = new StringBuilder("<marquee>");

            while (sr.Peek()!=-1)
            {

                sBuilder.Append(sr.ReadLine().ToString());
                sBuilder.Append("&nbsp;");//bir pt lik bir boşluk bırakacak.
            }

            sr.Close();

            sBuilder.Append("</marquee>");
            //Response.Write(sBuilder.ToString());
            LiteralControl ltControl = new LiteralControl();
            ltControl.Text = sBuilder.ToString();

            Panel1.Controls.Add(ltControl);
            //--------------------------------------
            //Literal Kontrol & Panel Kontrol Ekleme İşlem Sonu
            //--------------------------------------

            if (Request.Cookies["KullaniciBilgisi"]==null)
            {
                MultiView1.ActiveViewIndex = 0;
            }
            else
            {
                HttpCookie oku = Request.Cookies["KullaniciBilgisi"];
                lbl_kullanici.Text = "Hoşgeldiniz Sn. " + oku["KullaniciAdi"].ToString();

                MultiView1.ActiveViewIndex = 1;

            }

                
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (hd_UrunID.Value=="-1")
            {
                Response.Write("Kaydetme Yapılacak.");
            }
            else
            {
                Response.Write("Güncelleme Yapılacak.");
            }
            hd_UrunID.Value = "25";
            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            HttpCookie cerez = new HttpCookie("KullaniciBilgisi");

            cerez["KullaniciAdi"] = TextBox1.Text;
            cerez.Expires = DateTime.Now.AddDays(2);

            Response.Cookies.Add(cerez);


        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Session.Abandon();//Tüm sessionları sonlandır.
            //oluşmuş olan bir Cookie yi silmek için expires süresini Now a eşitlemeniz gerekmektedir.
            HttpCookie cerez = new HttpCookie("KullaniciBilgisi");
            cerez.Expires = DateTime.Now;
            Response.Cookies.Add(cerez);
        }
    }
}
