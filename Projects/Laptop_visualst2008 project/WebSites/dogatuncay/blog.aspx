<%@ Page Language="C#" AutoEventWireup="true" CodeFile="blog.aspx.cs" Inherits="blog" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body bgcolor="#000000">
    <form id="form1" runat="server">
    <div>
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
                <asp:ImageButton ID="btn_contact" runat="server" 
                    ImageUrl="~/images/btn_contact.bmp" onclick="btn_contact_Click" />
                    <br />
                    <asp:ImageButton ID="btn_danger" runat="server" ImageUrl="~/images/dangerr.jpg" 
                    onclick="btn_danger_Click" BackColor="Black" />
    </div>
    </form>
</body>
</html>
