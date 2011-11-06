<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 110px">
    
        <asp:Label ID="Label2" runat="server" Text="Science Fiction Haberlerine Hoşgeldiniz..."></asp:Label> 
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Kategoriler:   "></asp:Label>
        <asp:DropDownList ID="ddl_kategorixml" runat="server">
            <asp:ListItem>News</asp:ListItem>
            <asp:ListItem>Articles</asp:ListItem>
            <asp:ListItem>Short Stories</asp:ListItem>
        </asp:DropDownList>
        <asp:Button ID="btn" runat="server" onclick="btn_Click1" 
            Text="Bir dahaki sayfa--&gt;" />
    
        <br />
    
    </div>
    </form>
</body>
</html>
