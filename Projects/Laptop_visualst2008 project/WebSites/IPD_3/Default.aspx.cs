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
        ListItem li;
        li = new ListItem("hurriyet", "http://www.hurriyet.com");
        BulletedList1.Items.Add(li);

    }
    protected void BulletedList1_Click(object sender, BulletedListEventArgs e)
    {
        string URL = BulletedList1.Items[e.Index].Value;
        Response.Redirect(URL);
    }
}
