﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default3.aspx.cs" Inherits="Default3" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label><br /><br />
        <asp:Label ID="Label4" runat="server" Text="1. sayfada seçtiğiniz kategorinin haber linkleri aşağıdadır..."></asp:Label>
        <asp:BulletedList ID="BulletedList1" runat="server" DisplayMode="HyperLink">
        </asp:BulletedList>
    
    </div>
    </form>
</body>
</html>
