<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>



<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table> 
    <tr> <td style="height: 26px"> <asp:Button ID="btnNesne" Text="Nesne Oluştur" runat="server" OnClick="btnNesne_Click" /></td></tr>
    <tr><td><asp:Label ID="lblStatus" runat="server" ></asp:Label></td></tr>
    </table>
       </div>
    </form>
</body>
</html>
