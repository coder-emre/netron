<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:BulletedList ID="BulletedList1" runat="server" DisplayMode="HyperLink" 
            onclick="BulletedList1_Click">
        </asp:BulletedList>
    
    </div>
    <p>
        <asp:Button ID="Button1" runat="server" Text="gönder" />
    </p>
    </form>
</body>
</html>
