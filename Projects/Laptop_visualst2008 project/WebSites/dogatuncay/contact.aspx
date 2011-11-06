<%@ Page Language="C#" AutoEventWireup="true" CodeFile="contact.aspx.cs" Inherits="contact" %>

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
            width: 78px;
        }
        .style3
        {
            width: 207px;
        }
    </style>
</head>
<body bgcolor="#000000">
    <form id="form1" runat="server">
        <table class="style1">
            <tr>
                <td class="style3">
                      
                <asp:ImageButton ID="btn_menu" runat="server" ImageUrl="~/images/btn_menu.bmp" onclick="btn_menu_Click" />
                  <br /> 
                <asp:ImageButton ID="btn_information" runat="server" 
                    ImageUrl="~/images/btn_information.bmp" onclick="btn_information_Click" />
                  <br />  
                <asp:ImageButton ID="btn_portfolio" runat="server" 
                    ImageUrl="~/images/btn_portfolio.bmp" onclick="btn_portfolio_Click" />
                  <br /> 
                <asp:ImageButton ID="btn_archives" runat="server" 
                    ImageUrl="~/images/btn_archives.bmp" onclick="btn_archives_Click"  />
                  <br /> 
                <asp:ImageButton ID="btn_blog" runat="server" ImageUrl="~/images/btn_blog.bmp" 
                    onclick="btn_blog_Click" />
                    <br />
                <asp:ImageButton ID="btn_danger" runat="server" ImageUrl="~/images/dangerr.jpg" 
                        onclick="btn_danger_Click" />
             
                <td bgcolor="Black" class="style2">
                  
            <br />
            <asp:Label ID="lbl_from" runat="server" Text="E-MAIL:" ForeColor="White"></asp:Label>
            <asp:TextBox ID="txt_subject" runat="server" BorderColor="Black" Height="22px"></asp:TextBox>
            
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                        ControlToValidate="txt_subject" ErrorMessage="*" 
                        ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            
            <br />
            <asp:Label ID="lbl_message" runat="server" Text="MESSAGE: " ForeColor="White"></asp:Label>
            <br />
            <asp:TextBox ID="txt_message" runat="server" BorderColor="Black" Height="71px" 
                TextMode="MultiLine" Width="179px" MaxLength="50"></asp:TextBox>
                    <br />
            <br />
            <asp:Button ID="btn_send" runat="server" onclick="btn_send_Click" Text="SEND" 
                        BackColor="Black" ForeColor="White" />
    
             
            </tr>
            <tr>
                <td class="style3">
                    &nbsp;</td>
                <td class="style2">
                    &nbsp;</td>
            </tr>
        </table>
  
    </form>
</body>
</html>
