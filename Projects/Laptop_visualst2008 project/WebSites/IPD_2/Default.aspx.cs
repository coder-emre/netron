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
        if (!Page.IsPostBack) //sürekli japon yeni ni ekliyodu butonda bu yüzden bunu ekledik sadece ilk postback olduğunda yapar sonraki postbackları yapmaz
        {
            ListItem aa;
            //ddlKurlar.Items.Add(new ListItem("japon yeni", "2,2")); 7/merkez bankasından xml alıcaz
            XmlTextReader re = new XmlTextReader("http://www.tcmb.gov.tr/kurlar/today.xml");
            string txt = "";
            string value = "";
            while (re.Read()) {
               
             if(re.NodeType==XmlNodeType.Element)
                 
                 if (re.Name == "Isim") {
                     
                     txt = re.ReadString();

                 }
             if (re.Name == "CrossRateUSD")
             {
                 value = re.ReadString();
                 if (value == "")
                     continue;  //boş değerleri böylece götürdük ddl deki
                 aa = new ListItem();
                 aa.Text = txt;
                 aa.Value = value.Replace(".", ",");
                 ddlKurlar.Items.Add(aa);
             }
               
            }
        }
    }

    protected void btnGonder_Click(object sender, EventArgs e)
    {
        double kur = Convert.ToDouble(ddlKurlar.SelectedItem.Value);
        double tl = Convert.ToDouble(txtKur.Text);
        double ypb = tl * kur;
        lblSonuc.Text = ypb.ToString();
    }
}
