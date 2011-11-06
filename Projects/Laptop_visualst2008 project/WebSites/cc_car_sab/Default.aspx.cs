using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml;

public partial class _Default : System.Web.UI.Page 
{


    protected void Page_Load(object sender, EventArgs e)
    {
        XmlReader rd = new XmlTextReader("http://www.tcmb.gov.tr/kurlar/today.xml");
        string kur="",capraz="";
        if (!this.IsPostBack)
        {

            while (rd.Read())
            {
                if (rd.NodeType == XmlNodeType.Element)
                {
                    if (rd.Name == "Isim")
                    {
                        kur = rd.ReadString();
                    }
                    if (rd.Name == "CrossRateUSD")
                    {
                        capraz = rd.ReadString();
                    }
                    if (kur != "" && capraz != "")
                    {
                kurlar.Items.Add(new ListItem(kur, capraz));
                    kur = "";
                    capraz = "";

                    }
                    
                }
            
            }
       

        }

    }

   
    protected void btnClick(object sender, EventArgs e)
    {
    float dolarmiktar = float.Parse(txtKur.Value);
    float euromitar = dolarmiktar * float.Parse(kurlar.Items[kurlar.SelectedIndex].Value.Replace(".",",") ) ;
        dvResult.InnerText = txtKur.Value + " $==>" + euromitar.ToString("N3") + kurlar.Items[kurlar.SelectedIndex].Text; 
    }
   
}
