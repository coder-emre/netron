using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Product
/// </summary>
public class Product
{
    private string mProductName;
    private int mProductPrize;

    public int MProductPrize
    {
        get { return mProductPrize; }
        set { mProductPrize = value; }
    }
    private string mImageUrl;

    public string MImageUrl
    {
        get { return mImageUrl; }
        set { mImageUrl = value; }
    }

    public string ProductName
    {
        get { return mProductName; }
        set
        {
            mProductName = value;
            if (NameChange != null)
            {
                NameChange();
            }
        }
    }

	public Product()
	{
		
	}
    public string Goster()
    {
        string str = "<h1> URUN ADI";
        str += this.ProductName + "</h1>";
        str += "<h2> URUN FIYATI";
        str += this.MProductPrize + "</h2>";
        str += "<img src=\"" +this.MImageUrl+"\"><br/>";

        return str;
    }
    public delegate void NameChangeHandler();
    public event NameChangeHandler NameChange;
}
