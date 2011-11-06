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

    }
    protected void btnGoster_Click(object sender, EventArgs e)
    {
        Product yeniurun = new Product();
        btnGoster.Click+=new EventHandler(btnGoster_Click);
        yeniurun.NameChange += new Product.NameChangeHandler(yeniurun_NameChange);
        yeniurun.ProductName = "Hasan";
        yeniurun.MProductPrize = 45 ;
        yeniurun.MImageUrl= "http://www.iticu.edu.tr/ogr/mckasapbasi/kasapbasi.jpg";

       // Response.Write(yeniurun.ProductName+"</br>"+ yeniurun.MProductPrize.ToString()+"</br>"+<img src=\""+ yeniurun.MImageUrl);

        Response.Write(yeniurun.Goster());

    }

    void yeniurun_NameChange()
    {
        Response.Write("adı değişti");
        //throw new NotImplementedException();
    }
}
