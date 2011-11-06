<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>e-Card</title>
</head>
<body>
    <form method="post" id="form1" runat="server">
    <div>
        Choose a background color:
        <br />
        <asp:DropDownList ID="lstBackColor" runat="server" Width="194px" Height="22px" />
        <br />
        <br />
        Choose a font:
        <br />
        <asp:DropDownList ID="lstFontName" runat="server" Width="194px" Height="22px" />
        <br />
        <br />
        Specify a numeric font size:
        <br />
        <asp:TextBox ID="txtFontSize" runat="server" /><br />
        <br />
        Choose a border style:
        <br />
        <asp:RadioButtonList ID="lstBorder" runat="server" Width="177px" Height="59px" />
        <br />
        <br />
        <asp:CheckBox ID="chkPicture" runat="server" Text="Add the default Picture"></asp:CheckBox><br />
        <br />
        Enter the greeting text below:
        <br />
        <asp:TextBox ID="txtGreeting" runat="server" Width="240px" Height="85px" TextMode="MultiLine" /><br />
        <br />
        <asp:Button ID="cmdUpdate" OnClick="cmdUpdate_Click" runat="server" Width="71px"
            Height="24px" Text="Update" />
    </div>
    <asp:Panel ID="pnlcard" Style="z-index: 101; left: 313px; position: absolute; top: 16px"
        runat="server" Width="339px" Height="481px" HorizontalAlign="Center">
        <br />
        &nbsp;
        <asp:Label ID="lblGreeting" runat="server" Width="256px" Height="150px" /><br />
        <br />
        <br />
        <asp:Image ID="imgDefault" runat="server" Width="212px" Height="160px" />
    </asp:Panel>
    </form>
</body>
</html>
