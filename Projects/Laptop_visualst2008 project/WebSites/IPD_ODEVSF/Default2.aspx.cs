using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

public partial class Default2 : System.Web.UI.Page
{
    ListItem aa;
    string txt = "";
    string secim = "";
    XmlTextReader re = new XmlTextReader("http://www.sffworld.com/rsfstories.xml");
    XmlTextReader re2 = new XmlTextReader("http://www.sffworld.com/rsfarticles.xml");
    XmlTextReader re3 = new XmlTextReader("http://www.sffworld.com/rsfnews.xml");
   
    protected void Page_Load(object sender, EventArgs e)
    {
       
        string strData = Session["V"].ToString();
        Label1.Text = ("Merhaba " + strData + " kategorisine tıkladınız...");

        if (strData == "Short Stories")
        {
            while (re.Read())
            {
                if (re.NodeType == XmlNodeType.Element)
                    if (re.Name == "title")
                    {
                        txt = re.ReadString();
                        aa = new ListItem();
                        aa.Text = txt;
                        DropDownList1.Items.Add(aa);
                        secim = "a";
                    }
            }
        }
        if (strData == "Articles")
        {
            while (re3.Read())
            {
                if (re3.NodeType == XmlNodeType.Element)
                    if (re3.Name == "title")
                    {
                        txt = re3.ReadString();
                        aa = new ListItem();
                        aa.Text = txt;
                        DropDownList1.Items.Add(aa);
                        secim = "b";
                    }
            }
        }
        if (strData == "News")
        {
            while (re2.Read())
            {
                if (re2.NodeType == XmlNodeType.Element)
                    if (re2.Name == "title")
                    {
                        txt = re2.ReadString();
                        aa = new ListItem();
                        aa.Text = txt;
                        DropDownList1.Items.Add(aa);
                        secim = "b";
                    }
            }
        }

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default3.aspx?Value=" + TextBox1.Text +"&" + "Text=" + secim);
    
    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        Session["V"] = DropDownList1.SelectedItem.Text;
       
       

    }
}
