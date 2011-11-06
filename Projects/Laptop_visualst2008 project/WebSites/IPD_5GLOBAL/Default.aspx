<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Button ID="btn_verigetir" runat="server" Text="Personel Listesi" 
            onclick="btn_verigetir_Click" />
    
        <asp:Table ID="tbl_personel" runat="server"></asp:Table>
    
    </div>
    </form>
</body>
</html>
