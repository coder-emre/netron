using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class information : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
   
    protected void btn_portfolio_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("portfolio.aspx");
    }
    protected void btn_archives_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("archives.aspx");
    }
    protected void btn_blog_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("blog.aspx");
    }
    protected void btn_contact_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("contact.aspx");
    }
     
    protected void btn_menu_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("main.aspx");
    }
    protected void btn_danger_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("Login.aspx");
    }
}
