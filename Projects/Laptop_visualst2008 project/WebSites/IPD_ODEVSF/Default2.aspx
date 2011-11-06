<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 267px">
     
     <br /> 
        
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" 
            Text="Aşağıdaki listeden görüntülemek istediğiniz haberi tıklayınız..."></asp:Label>
            <br />
            <br />
        <asp:DropDownList ID="DropDownList1" runat="server" 
            onselectedindexchanged="DropDownList1_SelectedIndexChanged" >
        </asp:DropDownList>
    
    <br />
        <br />
      <asp:Label ID="Label4" runat="server" Text="Kisisel Notunuz:"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
            Text="Bir sonraki sayfa--&gt;" />
    </div>
    </form>
</body>
</html>
