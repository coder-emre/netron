using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Drawing;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btn_tabloolustur_Click(object sender, EventArgs e)
    {
        int satir = int.Parse(txt_satir.Text);
        int sutun = int.Parse(txt_sutun.Text);
        TableCell td;
        tbl.BorderWidth = Unit.Point(1);
        tbl.BorderStyle = BorderStyle.Dashed;
        for (int i = 1; i <= satir; i++)
        {
            TableRow rw = new TableRow();

            for (int j = 1; j < sutun; j++)
            {
               td = new TableCell();
               td.Text = i.ToString() + " " + j.ToString();
               td.BorderWidth = Unit.Pixel(3);
               if (i % 2 == 0)
                   td.BackColor = Color.Aqua;
               else
                   td.BackColor = Color.Red;
               tbl.Controls.Add(rw);
                
            }
        
        
        }
    }
}
