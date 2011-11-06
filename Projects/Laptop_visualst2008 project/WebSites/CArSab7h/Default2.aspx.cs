using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Net;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    { HttpCookie cerez;

    if (Request.Cookies["KULLANICI"] != null)
    {
        cerez = Request.Cookies["KULLANICI"];
        Label1.Text =" MERHABA HOÞ GELDÝN" + cerez["UserName"];
    }
    }
    protected void BtnGonder_Click(object sender, EventArgs e)
    {
        HttpCookie cerez = new HttpCookie("KULLANICI");
        cerez["UserName"] = txtAd.Text;
        cerez.Expires = DateTime.Now.AddHours(1);
        Response.Cookies.Add(cerez);
        if (Request.Cookies["KULLANICI"] != null)
        {
            cerez = Request.Cookies["KULLANICI"];
            Label1.Text = " MERHABA HOÞ GELDÝN" + cerez["UserName"];
        }
    }
}
