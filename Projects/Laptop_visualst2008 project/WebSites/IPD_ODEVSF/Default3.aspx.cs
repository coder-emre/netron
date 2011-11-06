using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

public partial class Default3 : System.Web.UI.Page
{
    ListItem bb;
    string txt2 = "";
    string val = "";
    XmlTextReader re = new XmlTextReader("http://www.sffworld.com/rsfstories.xml");
    XmlTextReader re2 = new XmlTextReader("http://www.sffworld.com/rsfarticles.xml");
    XmlTextReader re3 = new XmlTextReader("http://www.sffworld.com/rsfnews.xml");

    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Text = "Kişisel notunuz: " + Request.QueryString["Value"];
        Label2.Text = "Seçtiğiniz haber başlığı  " + Session["V"].ToString();
        Label3.Text = Request.QueryString["Text"];

        if (Label3.Text == "a")
        {
             while (re.Read())
                {
                    if (re.NodeType == XmlNodeType.Element)
                        if (re.Name == "link")
                        {
                            txt2 = re.ReadString();
                            bb = new ListItem();
                            bb.Text = txt2;
                            BulletedList1.Items.Add(bb);
                           
                        }
                }
          
        }
        if (Label3.Text == "b")
        {
            while (re2.Read())
            {
                if (re2.NodeType == XmlNodeType.Element)
                    if (re2.Name == "link")
                    {
                        txt2 = re2.ReadString();
                        bb = new ListItem();
                        bb.Text = txt2;
                        BulletedList1.Items.Add(bb);

                    }
            }

        }
        if (Label3.Text == "c")
        {
            while (re3.Read())
            {
                if (re3.NodeType == XmlNodeType.Element)
                    if (re3.Name == "link")
                    {
                        txt2 = re.ReadString();
                        bb = new ListItem();
                        bb.Text = txt2;
                        BulletedList1.Items.Add(bb);

                    }
            }

        }
    }
}
