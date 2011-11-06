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
        private decimal Rakammi(string deger)
        {
            try
            {
                return Convert.ToDecimal(deger);
            }
            catch (Exception)
            {

                return -1;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            //WebRequest istemiş olduğunuz sayfanın kaynak kodunu web sunucusundan talep eder.
            WebRequest myRequest = WebRequest.Create("http://www.tcmb.gov.tr/kurlar/today.html");

            // Yapılan talep sonucunda sayfanın txt cıktısı elde edilir ve bu bilgiyi webresponse tutar.
            WebResponse myResponse = myRequest.GetResponse();
            //eğer elde edilen bilgisi okumak istiyorsak bir stream nesnesine atmamız gerekir.GetResponseStream bu işi yapar.Sonucu stream eder.
            Stream ReceiveStream = myResponse.GetResponseStream();
            //Türkçe karakterlerde problem yaşamamak için encoding kullanılmalı.
            Encoding encode = System.Text.Encoding.GetEncoding("utf-8");

            //Eğer sonuçları satır satır dongu içinde okyacaksak streamreader kullanılması gerekir.Reader bir adres alabilieceği gibi bir stream nesnesi içinde ki dosyayıda alır.
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
                if (satir.StartsWith("USD/TRY") || satir.StartsWith("EUR/TRY") || satir.StartsWith("CAD/TRY")|| satir.StartsWith("SAR/TRY"))
                {

                    string Doviz = satir.Substring(0, 3).ToString();
                    string DovizAlis = "";// sonuçlar aritmetik işlemlerde kullanılmayacaksa string olarak değerler alınabilir.
                    decimal DovizSatis = 0; //Serverın decimal ayracı , ise noktalı ifade göz ardı edilir.Bu yuzden replace edilebilir.Aritmetik işlemlerde kullanılabilir artık.

                    int sayac = 0;
                    for (int i = 0; i < satir.Split(' ').Length; i++)
                    {
                        if (satir.Split(' ')[i] != "")
                        {
                            if (satir.Split(' ')[i]!="1")
                            {
                                if (sayac == 0 && Rakammi(satir.Split(' ')[i])!=-1)//Alış Bilgisi
                                {
                                    DovizAlis = satir.Split(' ')[i].ToString();
                                    sayac += 1;  
                                }
                                else if (sayac == 1 && Rakammi(satir.Split(' ')[i]) != -1)//Satış Bilgisi
                                {
                                    DovizSatis = Convert.ToDecimal(satir.Split(' ')[i].ToString().Replace(".", ","));
                                    sayac += 1;  
                                }
                                  
                            }
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