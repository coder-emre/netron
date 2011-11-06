using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

public partial class _Default : System.Web.UI.Page
{
    
    protected void Page_Load(object sender, EventArgs e)
    {
       ListItem aa;
    XmlTextReader re = new XmlTextReader("http://www.cnnturk.com/servisler/rss/anasayfa.rss");
    string txt = "";
    string value = "";
        {  
            
            
           if(!Page.IsPostBack) 
            while (re.Read())
            {

                if (re.NodeType == XmlNodeType.Element)

                    if (re.Name == "title")
                    {
                        txt = re.ReadString();
                        aa = new ListItem();
                        aa.Text = txt;
                        DropDownList1.Items.Add(aa);
                     }

                //if (re.Name == "link")
                //{
                //    aa = new ListItem();
                //    value = re.ReadString();

                //    aa.Text = txt;
                //    aa.Value = value;

                //    DropDownList1.Items.Add(aa);
                //}
              

               

            }
        }
    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {

        Response.Redirect(DropDownList1.SelectedItem.Value);
    }
}
