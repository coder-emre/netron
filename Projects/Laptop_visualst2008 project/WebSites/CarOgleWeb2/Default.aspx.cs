using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;



public partial class _Default : System.Web.UI.Page
{
    CarOgle2.Product hisPro;


    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnNesneOlustur_Click(object sender, EventArgs e)
    {
        hisPro = new CarOgle2.Product();
        CarOgle2.Product myProduct = new CarOgle2.Product();
        myProduct.NameChange += new CarOgle2.Product.NameChangeHandler(myProduct_NameChange);
        CarOgle2.Product newPro = new CarOgle2.Product();
        newPro.NameChange += new CarOgle2.Product.NameChangeHandler(myProduct_NameChange);
        myProduct = newPro;
        myProduct.Name = " Öðretmen";
        myProduct.Price = 49.99F;
        myProduct.ImageUrl = "http://www.iticu.edu.tr/ogr/mckasapbasi/resimler/kasapbasi.jpg";
        newPro.Name = "BUSH";
        newPro.ImageUrl = "http://www.ozgurmercan.com/wp-content/uploads/2008/04/maymun22cs.jpg";
        newPro.Price = 0.0F; 
                Response.Write(myProduct.GetHTML() + newPro.GetHTML() );
                
                if (myProduct == newPro)
                { lblStatus.Text = "Doðru"; }
                else { lblStatus.Text = "Doðru"; }


    }

    void myProduct_NameChange()
    {
        lblStatus.Text = "olay çalýþtý";
      //  throw new Exception("The method or operation is not implemented.");
    }
}
