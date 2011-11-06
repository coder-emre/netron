using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_PreInit(Object sender, EventArgs e)
    {
        if (Request["Theme"] == "Red")
        {
            Profile.UserTheme = "Red";
        }
        else if (Request["Theme"] == "Green")
        { 
            Profile.UserTheme = "Green"; 
        }
        Theme = Profile.UserTheme;
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        Customer musteri;
        if (ViewState["Musteri"] != null)
        { 
            musteri = (Customer) ViewState["Musteri"];
            lblMusteri.Text = musteri.AD + "\n" + musteri.SOYAD;
        }
    }
    protected void btnARTTIR_Click(object sender, EventArgs e)
    {
        if (ViewState["Counter"] == null)
        {
            ViewState["Counter"] = 1;
            lblSonuc.Text = "SONUC : 1";
        }
        else
        {
      ViewState["Counter"] = (int)ViewState["Counter"] + 1;
      lblSonuc.Text = "SONUC : "+ViewState["Counter"].ToString();
        }


    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        Customer cust = new Customer();
        cust.AD = txtName.Text ;
        cust.SOYAD = txtSoyad.Text;
        ViewState["Musteri"] = cust;
    }
    protected void btnSession_Click(object sender, EventArgs e)
    {
        Session["AD"] = txtName.Text;
        Session.Add("SOYAD", txtSoyad.Text);
        Session.Add("txtbox", txtAD);
        Response.Redirect("~/Default3.aspx");
    }
}
