<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Login.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <title>Log In Page</title>
</head>
<body style="background-image: url('master03_background.png');" onload=window.resizeTo(1000,800); >
    <form id="form1" runat="server">
    <div style="text-align: center">
        <asp:TextBox ID="Username" runat="server" style="left: 512px; position: absolute; top: 285px; z-index: 100;" ToolTip="ID Giriniz"></asp:TextBox>
        <asp:TextBox ID="Password" runat="server" Style="left: 513px;
            position: absolute; top: 315px; z-index: 101;" TextMode="Password" Width="147px" ToolTip="Şifrenizi Giriniz"></asp:TextBox>
        <asp:Button ID="LogIn" runat="server" OnClick="Button1_Click" Style="left: 511px;
            position: absolute; top: 344px; z-index: 102;" Text="Log In" />
        <asp:Label ID="Label1" runat="server" Height="39px" Style="left: 434px; position: absolute;
            top: 233px; font-size: 10pt; vertical-align: baseline; line-height: normal; letter-spacing: normal; background-color: activeborder; text-align: center; z-index: 103;" Text="Lütfen Kullanıcı ID & Şifre Giriniz" Width="230px" BorderStyle="Dashed" BorderWidth="1px"></asp:Label>
        &nbsp;
        <asp:Label ID="Label3" runat="server" Height="22px" Style="left: 434px; position: absolute;
            top: 285px; background-color: buttonface; z-index: 104;" Text="Kullanıcı ID" Width="72px"></asp:Label>
        <asp:Label ID="Label2" runat="server" Height="22px" Style="left: 434px; position: absolute;
            top: 315px; background-color: buttonface; z-index: 105;" Text="Şifre" Width="72px"></asp:Label>
        &nbsp; &nbsp;
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ></asp:SqlDataSource>
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;<br />
        <strong><span style="font-size: 16pt; font-family: Times New Roman TUR">ONLINE
        SİPARİŞ SİSTEMİ</span></strong><br />
        <asp:Button ID="Clear" runat="server" OnClick="Button1_Click1" Style="left: 574px;
            position: absolute; top: 344px; z-index: 106;" Text="Clear" Width="54px" />
        <asp:Label ID="Label4" runat="server" Style="left: 445px; vertical-align: middle;
            position: absolute; top: 464px; text-align: center" Text="2008 August Interns - Istanbul"
            Width="232px"></asp:Label>
        &nbsp; &nbsp; &nbsp; &nbsp;
        &nbsp;&nbsp;
        <asp:Image ID="Image1" runat="server" Height="117px" ImageAlign="Middle" Style="left: 427px;
            position: absolute; top: 106px; z-index: 108;" Width="262px" />
    </div>
    </form>
</body>
</html>
