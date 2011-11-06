using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

public partial class _Default : System.Web.UI.Page 
{
    SessionParameter V = new SessionParameter();
    protected void Page_Load(object sender, EventArgs e)
    {
    }
   
    protected void btn_Click1(object sender, EventArgs e)
    {
        Session["V"] = ddl_kategorixml.SelectedItem.Text;

        Response.Redirect("Default2.aspx");
    }
}
