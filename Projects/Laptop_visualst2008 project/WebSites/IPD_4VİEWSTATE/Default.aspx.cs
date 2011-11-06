using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            this.ViewState["sayac"] = 0;
            Musteri yeni = new Musteri();
            yeni.MusteriAdi = "Microsoft";
            ViewState["Musteri"] = yeni;
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (this.ViewState["sayac"] != null)
        {
            int i =Convert.ToInt32(this.ViewState["sayac"]);
            i++;
            Label1.Text = i.ToString();
            this.ViewState["sayac"] = i;
        }
        if (ViewState["Musteri"] != null) {
            Musteri mus = (Musteri)ViewState[Musteri];
            Label1.Text = mus.MusteriAdi;
            mus.MusteriAdi += "cisco";
            ViewState["Musteri"] = mus;
        }
    }
}
