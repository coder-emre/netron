<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
   <asp:DataList ID="DataList1" runat="server" CellPadding="4" ForeColor="#333333" BorderColor="#336699" BorderStyle="Solid" BorderWidth="1px">

   <AlternatingItemStyle BackColor="#CCCCFF" />
   <HeaderStyle BackColor="#336699" Font-Bold="True" ForeColor="White" />

   <HeaderTemplate>
      Latest Tutorials
   </HeaderTemplate>

   <ItemTemplate>
      <asp:HyperLink ID="link" runat="server" Text='<%# Eval("title") %>' NavigateUrl='<%# Eval("http://www.ntvmsnbc.com/id/24928011/device/rss/rss.xml") %>' />                
   </ItemTemplate>
           
</asp:DataList>
    <asp:Button ID="Button1" runat="server" Text="Button" />
    </form>
</body>
</html>
