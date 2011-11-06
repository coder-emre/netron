using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using System.ComponentModel;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
        {
            // renk
            string[] colorArray = Enum.GetNames(typeof(System.Drawing.KnownColor));
            lstBackColor.DataSource = colorArray;
            lstBackColor.DataBind();

            // font
            System.Drawing.Text.InstalledFontCollection fonts = new System.Drawing.Text.InstalledFontCollection();
            foreach (FontFamily family in fonts.Families)
            {
                lstFontName.Items.Add(family.Name);
            }

            ListItem item = new ListItem();
            string[] borderStyleArray = Enum.GetNames(typeof(BorderStyle));
            lstBorder.DataSource = borderStyleArray;
            lstBorder.DataBind();

            lstBorder.SelectedIndex = 0;

            imgDefault.ImageUrl = "images/default-user-image.png";
            imgDefault.Visible = false;
        }
    }

    protected void cmdUpdate_Click(object sender, System.EventArgs e)
    {
        TypeConverter cnvrt = TypeDescriptor.GetConverter(typeof(BorderStyle));

        pnlcard.BackColor = Color.FromName(lstBackColor.SelectedItem.Text);

        lblGreeting.Font.Name = lstFontName.SelectedItem.Text;

        if (Int32.Parse(txtFontSize.Text) > 0)
        {
            lblGreeting.Font.Size = FontUnit.Point(Int32.Parse(txtFontSize.Text));
        }

        
        int borderValue = Int32.Parse(lstBorder.SelectedItem.Value);
        pnlcard.BorderStyle = (BorderStyle)borderValue;

        if (chkPicture.Checked)
        {
            imgDefault.Visible = true;
        }
        else
        {
            imgDefault.Visible = false;
        }

        lblGreeting.Text = txtGreeting.Text;
    }
}
