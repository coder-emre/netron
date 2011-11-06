using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class IPD : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string strData = Session["V"].ToString();
        lbl_IPD1.Text = ("Merhaba " + strData + " kategorisine tıkladınız...");

    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("archives.aspx");
    }
}
