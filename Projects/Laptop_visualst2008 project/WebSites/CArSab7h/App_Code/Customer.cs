using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

/// <summary>
/// Summary description for Customer
/// </summary>
/// 
[Serializable]
public class Customer
{
    private string mAd;

    public string AD
    {
        get { return mAd; }
        set { mAd = value; }
    }
    private string mSoyad;

    public string SOYAD
    {
        get { return mSoyad; }
        set { mSoyad = value; }
    }


	public Customer()
	{
		//
		// TODO: Add constructor logic here
		//
	}
}
