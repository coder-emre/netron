using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml.Linq;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
  
    protected void TreeView1_SelectedNodeChanged1(object sender, EventArgs e)
    {
        Image imgBanner = Page.Master.FindControl("Image1") as Image;
        switch (TreeView1.SelectedValue)
        {
            case "1":
                imgBanner.ImageUrl = "images/Blue hills.jpg";
                break;
            case "6":
                imgBanner.ImageUrl = "images/winter.jpg";
                break;
            default:
                imgBanner.ImageUrl = "images/sunset.jpg";
                break;
        }
    }
}
