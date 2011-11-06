<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1"
            ErrorMessage="RequiredFieldValidator">*</asp:RequiredFieldValidator><br />
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="TextBox2"
            ErrorMessage="RangeValidator"></asp:RangeValidator><br />
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br />
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <br />
        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox><br />
        &nbsp;<asp:Button ID="btn" runat="server"  text="gönder" OnClick="btn_Click" />
        &nbsp;
        <asp:LinkButton ID="LinkButton1" runat="server">LinkButton</asp:LinkButton>
        <asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/XMLFile.xml" OnTransforming="XmlDataSource1_Transforming">
        </asp:XmlDataSource>
        <asp:MultiView ID="MultiView1" runat="server">
            <asp:View ID="View1" runat="server">
            </asp:View>
            <asp:View ID="View2" runat="server">
            </asp:View>
            <asp:View ID="View3" runat="server">
            </asp:View>
            <asp:View ID="View4" runat="server">
            </asp:View>
        </asp:MultiView></div>
    </form>
</body>
</html>
