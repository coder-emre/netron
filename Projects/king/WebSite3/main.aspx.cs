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

public partial class main : System.Web.UI.Page
{
    
    SqlConnection connection = new SqlConnection(@"Data Source=YOUR-139F20E2F6\SQLEXPRESS;Initial Catalog=Siparis;Integrated Security=True");
    SqlCommand cmd;
    SqlDataAdapter data;

    DataTable table;
    DataSet user_dataset;
    
    int order_id = 0;

    string user_id;
    string new_order = "";
    string date;
    string decision;

    
    // PAGE LOAD!!!!
    protected void Page_Load(object sender, EventArgs e)
    {
        string name = Page.User.Identity.Name;

        Image1.ImageUrl = "denizbank.gif";
        //user_id = "admin";
        user_id = Session["username"].ToString();

        if (user_id == "admin")
        {
            TextBox3.Visible = true;
            Button3.Visible = true;
            Button4.Visible = true;
            Button5.Visible = true;
            Button6.Visible = true;
        }
     

        welcome_message(user_id);
        siparis_sayisi_yenile();
        max_siparis_secimi();
        duyuru_gosterme();
        siparis_bitir_basla_kontrol();
    }


    //GRUPLANMIS SÝPARÝS LÝSTESÝ
    protected void siparis_sayisi_yenile()
    {
        SqlCommand cmd2 = new SqlCommand("SELECT COUNT(*) AS En_Cok_Siparis, Order_place FROM [Order] GROUP BY Order_place", connection);
        SqlDataAdapter data2 = new SqlDataAdapter(cmd2);
        connection.Open();
        DataSet user_dataset2 = new DataSet();
        data2.Fill(user_dataset2, "lev");

        table = user_dataset2.Tables["lev"];

        GridView3.DataSource = table;
        GridView3.DataBind();
        connection.Close();
    }

    // EN COK SÝPARÝS VERÝLEN LOKANTA GOSTERLIYOR
    protected void max_siparis_secimi()
    {
        string restorant = "";

        //MAX ORDER SELECTION ***********************************

        SqlCommand cmd2 = new SqlCommand("SELECT TOP 1 Order_place FROM [Order] GROUP BY [Order_place]ORDER BY Count(Order_place) DESC", connection);
        
        
        SqlDataAdapter data2 = new SqlDataAdapter(cmd2);
        connection.Open();
       
        DataSet user_dataset2 = new DataSet();

        data2.Fill(user_dataset2, "lev");


        connection.Close();

        if (user_dataset2.Tables[0].Rows.Count > 0)
        {
            DataRow order_datarow2 = user_dataset2.Tables[0].Rows[0];
            restorant = order_datarow2[0].ToString();
            Label4.Text = "Þu anda siparis " + restorant + "  restorantýndan verilecektir!";
        }
        else 
        {
            Label4.Text = "Daha siparis verilmemiþtir";
        }
        
        


        //MAX ORDER SELECTION ***********************************

    }

    //SIPARIS TARIHI DUYURUSU GOSTERILIYOR
    protected void duyuru_gosterme()
    {


        SqlCommand cmd3 = new SqlCommand("SELECT TOP 1 Siparis_duyurusu FROM [Duyuru] Order by duyuru_id DESC", connection);    
        SqlDataAdapter data3 = new SqlDataAdapter(cmd3);
        connection.Open();
        DataSet user_dataset3 = new DataSet();
        data3.Fill(user_dataset3, "lev");

        DataRow order_datarow3 = user_dataset3.Tables[0].Rows[0];

        string due_date3 = Convert.ToString(order_datarow3[0]);

        connection.Close();


        Label5.Text = "Lütfen saat " + due_date3 + " 'e kadar tüm siparislerinizi veriniz! - Admin";

    }

    // LOG OUT
    protected void Button2_Click(object sender, EventArgs e)
    {
        // LOG OUT - TERMINATION **************************

        connection.Close();
        Session.Abandon();
        Response.Redirect("login.aspx");

        // LOG OUT - TERMINATION **************************
    }

    //WELCOME MESSAGE
    protected void welcome_message(string user_id)
    {

        // WELCOME MESSAGE **************************************
        cmd = new SqlCommand("SELECT User_name,User_surname FROM [User] WHERE (User_id = '" + user_id + "')", connection);
        data = new SqlDataAdapter(cmd);
        connection.Open();
        user_dataset = new DataSet();
        data.Fill(user_dataset, "lev");
        foreach (DataRow user_datarow in user_dataset.Tables[0].Rows)
        {
            string user_name_welcome = user_datarow[0].ToString();
            string user_surname_welcome = user_datarow[1].ToString();
            Label3.Text = "Welcome " + user_name_welcome + "  " + user_surname_welcome + "!";
        }
        connection.Close();

        // WELCOME MESSAGE ************************************** 
    }

    // STORE LISTESINDEN SECIM ACTIONI
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        get_store_name();

    }

    // Order Insertion!
    protected void Button1_Click(object sender, EventArgs e)
    {

        string store_name = "";
        string a = GridView1.SelectedIndex.ToString();

        if (a == "-1")
        {
            Response.Write("<script>alert('Lütfen Bir Restorant Seçiniz!')</script>");
            Label2.Text = "Select Restaurant!";
        }
        else if (TextBox2.Text == "" || TextBox2.Text == "Please, write your order here" ||TextBox2.Text == "Please, write your order!")
        {
            Response.Write("<script>alert('Lütfen Sipariþinizi Yazýnýz!')</script>");
            TextBox2.Text = "Please, write your order!"; }
        else
        {
            // STORE SELECTION *************************************
            SqlCommand cmd = new SqlCommand("SELECT Stores FROM [Store] WHERE Store_id ='" + a + "' ", connection);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            connection.Open();
            DataSet store_dataset = new DataSet(); 

            data.Fill(store_dataset, "lev");

            foreach (DataRow store_datarow in store_dataset.Tables[0].Rows)
            {
                store_name = store_datarow[0].ToString();
            }
            connection.Close();
            // STORE SELECTION *************************************


            // EMPTY TABLE ORDER INSERTION *************************
            if (GridView2.Rows.Count == 0)
            {
                new_order = TextBox2.Text;
                cmd = new SqlCommand("INSERT INTO [Order] values('" + order_id + "','" + store_name + "','" + DateTime.Now.ToLocalTime() + "','" + user_id + "','" + new_order + "')", connection);
                order_id++;
                data = new SqlDataAdapter(cmd);
                connection.Open();
                store_dataset = new DataSet();

                data.Fill(store_dataset, "lev");

                table = store_dataset.Tables["lev"]; 
                GridView2.DataSource = table;
                GridView2.DataBind();
                connection.Close();
                TextBox2.Text = "";
                Response.Write("<script>alert('Siparisiniz Eklenmiþtir!')</script>");
                // EMPTY TABLE ORDER INSERTION *************************

            }
            else
            {
                // EXISTIN' TABLE ORDER INSERTION ***********************
                new_order = TextBox2.Text;
                cmd = new SqlCommand("SELECT MAX(Order_id) FROM [Order]", connection);
                data = new SqlDataAdapter(cmd);
                connection.Open();
                store_dataset = new DataSet();
                data.Fill(store_dataset, "lev1");
                    foreach (DataRow store_datarow in store_dataset.Tables[0].Rows)
                    {
                        if (store_datarow[0].ToString() != "")
                        {
                            if (store_datarow[0] != null)
                            {
                                order_id = (int)store_datarow[0];
                            }
                            else
                            {
                                order_id = 0;
                            }
                        }
                    }
                
                connection.Close();
                order_id++;


                new_order = TextBox2.Text;
                cmd = new SqlCommand("INSERT INTO [Order] values('" + order_id + "','" + store_name + "','" + DateTime.Now.ToLocalTime() + "','" + user_id + "','" + new_order + "')", connection);

                data = new SqlDataAdapter(cmd);
                connection.Open();
                store_dataset = new DataSet();

                data.Fill(store_dataset, "lev");

                table = store_dataset.Tables["lev"]; 
                GridView2.DataSource = table;
                GridView2.DataBind();
                connection.Close();

                // EXISTIN' TABLE ORDER INSERTION ***********************

                a = "-1";
                Label2.Text = "";
                store_name = "";
                GridView1.SelectedIndex = -1;
                TextBox2.Text = "";
                Response.Write("<script>alert('Siparisiniz Eklenmiþtir!')</script>");

            }
        }

        max_siparis_secimi();
        siparis_sayisi_yenile();
        //siparis_zamani_disable();
        
    }

    //STORE ADINI LABEL'A YAZIYOR
    protected void get_store_name()
    {
        string a = GridView1.SelectedIndex.ToString();
        SqlCommand cmd = new SqlCommand("SELECT Stores FROM [Store] WHERE Store_id ='" + a + "' ", connection);
        SqlDataAdapter data = new SqlDataAdapter(cmd);
        connection.Open();
        DataSet store_dataset = new DataSet(); 
        data.Fill(store_dataset, "lev");
        foreach (DataRow store_datarow in store_dataset.Tables[0].Rows)
        {
            string store_name = store_datarow[0].ToString();
            Label2.Text = store_name;
        }
        connection.Close();
    }

    // ADMIN SIPARIS TARIHI GIRIYOR
    protected void set_order_time(string order_due_date)
    {
        string due_date = order_due_date;
        int duyuru_id = 0;


        SqlCommand cmd2 = new SqlCommand("SELECT COUNT(*) FROM [Duyuru]", connection);

        connection.Open();

        duyuru_id = Convert.ToInt16(cmd2.ExecuteScalar());
        connection.Close();


        // EMPTY TABLE ORDER INSERTION *************************
        if (duyuru_id == 0)
        {
            if (due_date == ""||due_date=="Tarih giriniz!" ||due_date=="Gun.Ay.Yýl Saat:Dakika:Saniye")
            {
                Response.Write("<script>alert('Lütfen Siparis Sonlandýrma Tarihini Yazýnýz!')</script>");
                TextBox3.Text = "Tarih giriniz!";
            }
            else
            {
                string date1 = due_date;
                cmd2 = new SqlCommand("INSERT INTO [Duyuru] values('" + duyuru_id + "','" + date1 + "')", connection);
                duyuru_id = 0;
                connection.Open();
                cmd2.ExecuteNonQuery();

                this.connection.Close();
                // EMPTY TABLE ORDER INSERTION *************************
            }
        }
        else
        {

            // EXISTIN' TABLE ORDER INSERTION ***********************
            string date1 = due_date;
            cmd2 = new SqlCommand("INSERT INTO [Duyuru] values('" + duyuru_id + "','" + date1.ToString() + "')", connection);
            duyuru_id = 0;
            connection.Open();


            cmd2.ExecuteNonQuery();



            this.connection.Close();

            // EXISTIN' TABLE ORDER INSERTION ***********************
        }




    }


    protected void set_decision_time(string Siparis_Belirleme_Tarihi, string Siparis_Basla_Son_Bool)
    {

        string due_date = Siparis_Belirleme_Tarihi;
        int Siparis_Karar_id = 0;

        SqlCommand cmd2 = new SqlCommand("SELECT COUNT(*) FROM [Siparis_Kararlastirma]", connection);

        connection.Open();

        Siparis_Karar_id = Convert.ToInt16(cmd2.ExecuteScalar());
        connection.Close();


        // EMPTY TABLE ORDER INSERTION *************************
        if (Siparis_Karar_id == 0)
        {
                string date1 = due_date;
                cmd2 = new SqlCommand("INSERT INTO [Siparis_Kararlastirma] values('" + Siparis_Karar_id + "','" + Siparis_Belirleme_Tarihi + "','" + Siparis_Basla_Son_Bool + "')", connection);
                Siparis_Karar_id = 0;
                connection.Open();
                cmd2.ExecuteNonQuery();

                this.connection.Close();
                // EMPTY TABLE ORDER INSERTION *************************
         }
        else
        {

            // EXISTIN' TABLE ORDER INSERTION ***********************
            string date1 = due_date;
            Siparis_Karar_id++;
            cmd2 = new SqlCommand("INSERT INTO [Siparis_Kararlastirma] values('" + Siparis_Karar_id + "','" + Siparis_Basla_Son_Bool + "','" + Siparis_Belirleme_Tarihi + "')", connection);
            Siparis_Karar_id = 0;
            connection.Open();


            cmd2.ExecuteNonQuery();



            this.connection.Close();

            // EXISTIN' TABLE ORDER INSERTION ***********************
        }
    }

    // ADMIN SIPARIS TARIHI ONAYLIYOR
    protected void Button3_Click(object sender, EventArgs e)
    {

        date = TextBox3.Text.ToString();
        if (date == "" || date == "Tarih giriniz!" || date == "Gun.Ay.Yýl Saat:Dakika:Saniye")
        {
            Response.Write("<script>alert('Lütfen Siparis Sonlandýrma Tarihini Yazýnýz!')</script>");
            TextBox3.Text = "Tarih giriniz!";
        }
        else
        {
            set_order_time(date);
        }
        duyuru_gosterme();
        //siparis_zamani_disable();
    }
    protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
    {
            //max_siparis_secimi();
            duyuru_gosterme();
            siparis_sayisi_yenile();
            //siparis_zamani_disable();
    }

    /*protected void siparis_zamani_disable()
    {
        SqlCommand cmd3 = new SqlCommand("SELECT TOP 1 Siparis_duyurusu FROM [Duyuru] Order by duyuru_id DESC", connection);
        SqlDataAdapter data3 = new SqlDataAdapter(cmd3);
        connection.Open();
        DataSet user_dataset3 = new DataSet();
        data3.Fill(user_dataset3, "lev");
        DataRow order_datarow3 = user_dataset3.Tables[0].Rows[0];

        string due_date3 = Convert.ToString(order_datarow3[0]);

        DateTime due_date4 = Convert.ToDateTime(due_date3);

        connection.Close();
         
        if (System.DateTime.Now > due_date4)
        {
            GridView2.Visible = false;


        }
        else { GridView2.Visible = true; }

    }
    */

    protected void Button4_Click(object sender, EventArgs e)
    {

        decision = "sonlandir";
        DateTime order_term_date = System.DateTime.Now;
        string sonlandirma = Convert.ToString(order_term_date);
        set_decision_time(sonlandirma,decision);
        siparis_bitir_basla_kontrol();
    }


    protected void Button5_Click(object sender, EventArgs e)
    {
        decision = "baslat";
        DateTime order_term_date = System.DateTime.Now;
        string sonlandirma = Convert.ToString(order_term_date);
        set_decision_time(sonlandirma, decision);
        siparis_bitir_basla_kontrol();
    }


    protected void siparis_bitir_basla_kontrol()
    {
        DateTime login_date = System.DateTime.Now;

        SqlCommand cmd3 = new SqlCommand("SELECT TOP 1 Siparis_Belirleme_Tarihi,Siparis_Basla_Son_Bool FROM [Siparis_Kararlastirma] Order by Siparis_Karar_id DESC", connection);
        SqlDataAdapter data3 = new SqlDataAdapter(cmd3);
        connection.Open();
        DataSet user_dataset3 = new DataSet();
        data3.Fill(user_dataset3, "lev");
        DataRow order_datarow3 = null;
        if (user_dataset3.Tables[0].Rows.Count > 0)
        {
            order_datarow3 = user_dataset3.Tables[0].Rows[0];
            string due_date3 = Convert.ToString(order_datarow3[1]);
            string decision = Convert.ToString(order_datarow3[0]);
            DateTime due_date4 = Convert.ToDateTime(due_date3);

            DateTime karsilastirma = System.DateTime.Now;

            if (decision == "baslat")
            {
                if (karsilastirma >= due_date4)
                {
                    Button1.Visible = true;
                }
            }
            else if (decision == "sonlandir")
            {
                Button1.Visible = false;

            }
            else { }

        }
        else { }
        connection.Close();
    }

    protected void Button6_Click(object sender, EventArgs e)
    {
        SqlCommand cmd5 = new SqlCommand("DELETE FROM [Order]", connection);
        connection.Open();
        cmd5.ExecuteNonQuery();
        this.connection.Close();
        
        Response.Write("<script>alert('Tüm Sipariþler Silinmiþtir!')</script>");
        GridView2.PageIndex = 1;
        
        siparis_sayisi_yenile();
        max_siparis_secimi();
        duyuru_gosterme();
        
    }


    protected void GridView2_RowDeleted(object sender, GridViewDeletedEventArgs e)
    {
        Response.Redirect("main.aspx");
    }
}
