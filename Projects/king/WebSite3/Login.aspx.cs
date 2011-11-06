using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.Sql;
using System.Data.SqlClient;

public partial class _Default : System.Web.UI.Page 
{
    // PAGE LOAD !!!
    protected void Page_Load(object sender, EventArgs e)
    {
        Image1.ImageUrl = "denizbank.jpg";
        
    
    }

    //LOG IN BUTTON
    protected void  Button1_Click(object sender, EventArgs e)
{
    string user_id = Username.Text;
    string user_pass = Password.Text;
    Session["username"] = Username.Text;
    

    bool set = false;

    // SQL Connection Initialization
    SqlConnection connection = new SqlConnection(@"Data Source=YOUR-139F20E2F6\SQLEXPRESS;Initial Catalog=Siparis;Integrated Security=True");
    SqlCommand cmd = new SqlCommand("SELECT User_id,User_pass FROM [User]", connection);
    SqlDataAdapter data = new SqlDataAdapter(cmd);
    connection.Open();
    DataSet login_dataset = new DataSet();

    data.Fill(login_dataset, "lev");

    foreach(DataRow login_datarow in login_dataset.Tables[0].Rows)
    {
            if (user_id == login_datarow[0].ToString())
            {

                if (user_pass == login_datarow[1].ToString())
                {
                    set = true;
                }

            }
            else { }

    }
    if (set == true)
    {

        Response.Redirect("main.aspx");
        
    }
    else
    {
        Label1.Text = "Yanlýþ Þifre veya Kullanýcý ID";
        Response.Write("<script>alert('Yanlýþ Þifre veya Kullanýcý ID')</script>");
        connection.Close();
    }
}

    protected void Button1_Click1(object sender, EventArgs e)
    {
        Username.Text = "";
        Password.Text = "";
    }

}