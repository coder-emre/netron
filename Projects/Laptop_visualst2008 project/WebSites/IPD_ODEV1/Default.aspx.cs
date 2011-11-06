using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Data;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        XmlTextReader reader = new XmlTextReader("http://www.ntvmsnbc.com/id/24928011/device/rss/rss.xml");
        DataSet ds = new DataSet();
        ds.ReadXml(reader);
        DataList1.DataSource = ds.Tables[2];
        DataList1.DataBind();
    }
}
