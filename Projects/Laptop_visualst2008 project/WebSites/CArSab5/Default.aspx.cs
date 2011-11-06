using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Drawing;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
        txtAD.Focus();
    }
    protected void txtAD_TextChanged(object sender, EventArgs e)
    {
Response.Write(txtAD.Text); 
    }
    protected void btnGonder_Click(object sender, EventArgs e)
    {int i;
        pnlPanel.Height = Unit.Percentage(75);
        pnlPanel.Width = Unit.Pixel(200);
        lblAd.BorderStyle = BorderStyle.Dotted;
        lblAd.BackColor = Color.LawnGreen;
        lblAd.BorderColor = Color.FromArgb(255, 255, 0, 0);
        txtAD.ForeColor = ColorTranslator.FromHtml("#00ff00");
        ListItem  Li=new ListItem("nolsun","denemeeee");
        chklCheckDeneme.Items.Add( Li);
///*****************************************************
///
        tbl.Controls.Clear();
        tbl.BorderStyle = BorderStyle.Double;
        tbl.BorderWidth = Unit.Pixel(1);  

        int rows = 3, cols = 4;
        TableCell tc;
        for (int sat = 0; sat < rows; sat++)
        {
            TableRow tr = new TableRow();
            tbl.Controls.Add(tr);

            for (int sut = 0; sut < cols; sut++)
            {
                tc = new TableCell();
                tc.BorderStyle = BorderStyle.Double;
                tc.BorderWidth = Unit.Pixel(1);  
                tc.Text = sat.ToString() + "  " + sut.ToString();
                tr.Controls.Add(tc);  
            }
        
        }


    }
    protected void chklCheckDeneme_SelectedIndexChanged(object sender, EventArgs e)
    {
        string str=""        ;
        foreach (ListItem li in chklCheckDeneme.Items)
        {
            if (li.Selected)
                str += li.Value.ToString();
        }
     txtAD.Text =str;
    }
}
