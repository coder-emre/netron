<%@ Page Language="C#" AutoEventWireup="true" CodeFile="IPD.aspx.cs" Inherits="IPD" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body bgcolor="#000000">
    <form id="form1" runat="server">
    <div>
        <asp:ImageButton ID="ImageButton1" runat="server" 
            ImageUrl="~/images/back-arrow.jpg" onclick="ImageButton1_Click" />
        <br />
    <asp:Label ID="lbl_IPD1" runat="server" Font-Bold="True" ForeColor="White"></asp:Label><br />
    <a href="../IPD/hafta1.ppt"><b>hafta1.ppt</b></a><br />
    <a href="../IPD/Beginning ASP.NET 2.0 in C# 2005 From Novice to Professional.pdf"><b>Beginning ASP.NET 2.0 in C# 2005 From Novice to Professional.pdf</b></a><br />
    <a href="../IPD/İnternet+prog.part1.rar"><b>İnternet+prog.part1.rar</b></a><br />
    </div>
    </form>
</body>
</html>
