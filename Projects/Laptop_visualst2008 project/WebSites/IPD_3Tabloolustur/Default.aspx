<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="sutun"></asp:Label>
        <asp:TextBox ID="txt_sutun" runat="server"></asp:TextBox>
        <asp:Label ID="Label2" runat="server" Text="satır"></asp:Label>
        <asp:TextBox ID="txt_satir" runat="server"></asp:TextBox>
        <asp:Button ID="btn_tabloolustur" runat="server" Text="olustur" 
            onclick="btn_tabloolustur_Click" />
    <asp:Table runat=server ID="tbl"></asp:Table>
    </div>
    </form>
</body>
</html>
