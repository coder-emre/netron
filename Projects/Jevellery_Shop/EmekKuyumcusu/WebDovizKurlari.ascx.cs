using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Net;
using System.IO;
using System.Text;
namespace WebDovizKurlari
{
    public partial class WebDovizKurlari : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            WebRequest myRequest = WebRequest.Create("http://www.tcmb.gov.tr/kurlar/today.html");

            // Return the response. 
            WebResponse myResponse = myRequest.GetResponse();

            Stream ReceiveStream = myResponse.GetResponseStream();

            Encoding encode = System.Text.Encoding.GetEncoding("utf-8");

            // Pipe the stream to a higher level stream reader with the required encoding format. 
            StreamReader readStream = new StreamReader(ReceiveStream, encode);

            Table tbl = new Table();
            tbl.Style.Add("font-family", "verdana");
            tbl.Style.Add("font-size", "11px");
            tbl.Style.Add("border", "solid 1px");

            TableRow Hsatir;
            TableCell kolon;

            Hsatir = new TableRow();
            //Boş kolon ekliyoruz
            kolon = new TableCell();
            kolon.Text = "<b>DOVİZ</b>";
            Hsatir.Cells.Add(kolon);

            //Başlık bilgisi oluşuyor
            kolon = new TableCell();
            kolon.Text = "<b>ALIŞ</b>";
            Hsatir.Cells.Add(kolon);

            //Başlık bilgisi oluşuyor
            kolon = new TableCell();
            kolon.Text = "<b>SATIŞ</b>";
            Hsatir.Cells.Add(kolon);

            tbl.Rows.Add(Hsatir);

            while (readStream.Peek() != -1)
            {
                string satir = readStream.ReadLine();
                if (satir.StartsWith("USD/TRY") || satir.StartsWith("EUR/TRY") || satir.StartsWith("CAD/TRY"))
                {

                    string Doviz = satir.Substring(0, 3).ToString();
                    string DovizAlis = "";// sonuçlar aritmetik işlemlerde kullanılmayacaksa string olarak değerler alınabilir.
                    decimal DovizSatis = 0; //Serverın decimal ayracı , ise noktalı ifade göz ardı edilir.Bu yuzden replace edilebilir.Aritmetik işlemlerde kullanılabilir artık.

                    int sayac = 0;
                    for (int i = 0; i < satir.Split(' ').Length; i++)
                    {
                        if (satir.Split(' ')[i] != "")
                        {
                            if (sayac == 4)
                            {
                                DovizAlis = satir.Split(' ')[i].ToString();
                            }
                            else if (sayac == 5)
                            {
                                DovizSatis = Convert.ToDecimal(satir.Split(' ')[i].ToString().Replace(".", ","));
                            }
                            sayac += 1;
                        }
                    }

                    Hsatir = new TableRow();
                    //Boş kolon ekliyoruz

                    kolon = new TableCell();
                    kolon.Text = Doviz;
                    Hsatir.Cells.Add(kolon);

                    kolon = new TableCell();
                    kolon.Text = DovizAlis.ToString();
                    Hsatir.Cells.Add(kolon);

                    kolon = new TableCell();
                    kolon.Text = DovizSatis.ToString();
                    Hsatir.Cells.Add(kolon);

                    tbl.Rows.Add(Hsatir);


                }
            }
            readStream.Close();
            myResponse.Close();
            this.Controls.Add(tbl);

        }
    }
}