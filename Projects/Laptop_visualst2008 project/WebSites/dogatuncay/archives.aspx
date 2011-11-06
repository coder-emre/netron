<%@ Page Language="C#" AutoEventWireup="true" CodeFile="archives.aspx.cs" Inherits="archives" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style2
        {
            width: 247px;
        }
    </style>
</head>
<body bgcolor="#000000">
    <form id="form1" runat="server">
    <div>
     <table class="style1">
                      <tr>
                       <td class="style2">
                <asp:ImageButton ID="btn_menu" runat="server" ImageUrl="~/images/btn_menu.bmp" onclick="btn_menu_Click" />
                  <br /> 
                <asp:ImageButton ID="btn_information" runat="server" 
                    ImageUrl="~/images/btn_information.bmp" onclick="btn_information_Click" />              
                  <br />  
                <asp:ImageButton ID="btn_portfolio" runat="server" 
                    ImageUrl="~/images/btn_portfolio.bmp" onclick="btn_portfolio_Click" />
                  <br /> 
               <asp:ImageButton ID="btn_blog" runat="server" ImageUrl="~/images/btn_blog.bmp" 
                    onclick="btn_blog_Click" />
                  <br /> 
                <asp:ImageButton ID="btn_contact" runat="server" 
                    ImageUrl="~/images/btn_contact.bmp" onclick="btn_contact_Click" />
                    <br />
                    <asp:ImageButton ID="btn_danger" runat="server" ImageUrl="~/images/dangerr.jpg" 
                    onclick="btn_danger_Click" />
         </td>
         &nbsp; 
         <td bgcolor="Black">
             <asp:Label ID="Label1" runat="server" Font-Bold="True" ForeColor="White" 
                 Text="Choose a lesson to download notes"></asp:Label>
             <br />
             <asp:DropDownList ID="ddl_lessons" runat="server" DataSourceID="SqlDataSource1" 
                 DataTextField="ders_adi" DataValueField="ders_id" style="height: 22px">
             </asp:DropDownList>
             <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                 ConnectionString="<%$ ConnectionStrings:dogatuncayConnectionString2 %>" 
                 SelectCommand="SELECT [ders_id], [ders_adi] FROM [DERS]">
             </asp:SqlDataSource>
             <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/images/arrow.jpg" 
                 onclick="ImageButton1_Click" />
         </td>
       </tr>
       </table>
              
    </div>
    </form>
</body>
</html>
