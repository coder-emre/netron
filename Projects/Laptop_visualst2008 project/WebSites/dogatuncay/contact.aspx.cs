using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Net.Mail;

public partial class contact : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btn_information_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("information.aspx");
    }
    protected void btn_portfolio_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("portfolio.aspx");
    }
    protected void btn_archives_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("archives.aspx");
    }
    protected void btn_blog_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("blog.aspx");
    }
    protected void btn_contact_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("contact.aspx");
    }
    
    protected void btn_menu_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("main.aspx");
    }
    protected void btn_send_Click(object sender, EventArgs e)
    {
        SmtpClient client = new SmtpClient();
        MailMessage msg = new MailMessage();

        msg.To.Add("dogatuncay@hotmail.com ");
        msg.From = new MailAddress("dogatuncay@gmail.com");
        msg.Subject = txt_subject.Text;
        msg.IsBodyHtml = true;
        msg.Body = txt_message.Text;

        NetworkCredential guvenlikKarti = new NetworkCredential("dogatuncay@gmail.com ", "36si:42ma");
        client.Credentials = guvenlikKarti;
        client.Port = 25;
        client.Host = "smtp.gmail.com";
        client.EnableSsl = true;
        client.Send(msg);


     
    }
    protected void btn_danger_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("Login.aspx");
    }
}
