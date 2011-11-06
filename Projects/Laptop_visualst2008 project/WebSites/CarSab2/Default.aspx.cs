using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
//using CarsambaSabahSiniflar;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnNesne_Click(object sender, EventArgs e)
    {
     CarsambaSabahSiniflar.Product myProduct = new CarsambaSabahSiniflar.Product();
     myProduct.NameChange += new CarsambaSabahSiniflar.Product.NameChangeHandler(myProduct_NameChange);
        CarsambaSabahSiniflar.Product newPro = new CarsambaSabahSiniflar.Product("kova", "kova.jpg", 20.5F);
        newPro.NameChange += new CarsambaSabahSiniflar.Product.NameChangeHandler(myProduct_NameChange);
        myProduct.Name = "ÖÐRETMEN";
        myProduct.Price = 49.99F;
        myProduct.ImageUrl = "http://www.iticu.edu.tr/ogr/mckasapbasi/resimler/kasapbasi.jpg";
        Response.Write(myProduct.GetHTML() + newPro.GetHTML());
      

    }

    void myProduct_NameChange()
    {
        lblStatus.Text = "Olay çalýþtý";
        //throw new Exception("The method or operation is not implemented.");
    }
}
