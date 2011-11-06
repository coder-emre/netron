using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.IO;



public partial class _Default : System.Web.UI.Page 
{
    protected void Button1_Click1(object sender, EventArgs e)
    {
       
        gvUrunler.PagerSettings.Visible = false;

        GereksizKolonlariSil();

        if (rbl.SelectedIndex == 1) // İlk 50 kayıt
        {
            gvUrunler.PageIndex = 0;
            gvUrunler.PageSize = 50;
        }
        else if (rbl.SelectedIndex == 2)

            gvUrunler.AllowPaging = false;
            gvUrunler.DataBind();
            GridiExceleKaydet();
    }
    private void GereksizKolonlariSil()
    {
        
        for (int i = 0; i < gvUrunler.Columns.Count; i++)
        {
            if (gvUrunler.Columns[i] is CommandField)
                gvUrunler.Columns.RemoveAt(i);
        }
    }
    protected void GridiExceleKaydet()
    {
       
        gvUrunler.GridLines = GridLines.Both;

        StringWriter stringYaz = new StringWriter();
        HtmlTextWriter htw = new HtmlTextWriter(stringYaz);
        gvUrunler.RenderControl(htw);
        Response.Clear();
        Response.AddHeader("content-disposition", "attachment;filename=Urunler.xls");
        Response.ContentType = "application/ms-excel";
        Response.Write(stringYaz.ToString());
        Response.End();
    }
    public override void VerifyRenderingInServerForm(Control control)
    {
        if (control.ID != "gvUrunler")
            base.VerifyRenderingInServerForm(control);
    }
 
}
