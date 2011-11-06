<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="txtKur" runat="server"></asp:TextBox>
        <asp:DropDownList ID="ddlKurlar" runat="server">
         <%--   <asp:ListItem Value="1,45">Dolar</asp:ListItem>
            <asp:ListItem Value="2,1">Avro</asp:ListItem>
            <asp:ListItem Value="2,3">Sterlin</asp:ListItem>--%>
        </asp:DropDownList>
        <asp:Button ID="btnGonder" runat="server" Text="Button" 
            onclick="btnGonder_Click" />
        <asp:Label ID="lblSonuc" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
