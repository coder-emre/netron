<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server" defaultbutton="btnGonder">
    <div>
    <table border="1"> 
    <tr>
    <td><asp:Label id="lblAd" runat=server Text=" Adınız"></asp:Label></td>
    <td style="width: 160px"><asp:TextBox id="txtAD" runat="server" AccessKey="K"  OnTextChanged="txtAD_TextChanged" TabIndex="1" AutoPostBack="True">1</asp:TextBox></td>
    </tr>
    <tr><td colspan="2" align="center"><asp:Button ID="btnGonder" runat="server" Text="GONDER" OnClick="btnGonder_Click" />  </td>
    </tr>
        <tr>
            <td align="center" colspan="2">
                <asp:Panel ID="pnlPanel" runat="server" Height="50px" Width="125px" BorderStyle="Dashed" BackColor="DeepPink">
                </asp:Panel>
            </td>
        </tr>
        <tr>
            <td colspan="2" style="height: 97px">
 <asp:CheckBoxList ID="chklCheckDeneme" runat="server" AutoPostBack="True" OnSelectedIndexChanged="chklCheckDeneme_SelectedIndexChanged">
<asp:ListItem>MErhaba</asp:ListItem>
<asp:ListItem>nasılsın</asp:ListItem>
<asp:ListItem>g&#252;naydın</asp:ListItem>
                </asp:CheckBoxList></td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                    <asp:ListItem>g&#252;naydın</asp:ListItem>
                    <asp:ListItem Selected="True">iyi g&#252;nler</asp:ListItem>
                    <asp:ListItem>g&#252;le g&#252;le </asp:ListItem>
                </asp:RadioButtonList></td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:BulletedList ID="BulletedList1" runat="server" BulletStyle="CustomImage">
                    <asp:ListItem>dasdasd</asp:ListItem>
                    <asp:ListItem>asdasd</asp:ListItem>
                    <asp:ListItem>asdasda</asp:ListItem>
                </asp:BulletedList>
            </td>
        </tr>
        <tr>
            <td colspan="2">
            <asp:Table ID="tbl" runat="server"></asp:Table> 
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="TextBox1"
                    Display="None" ErrorMessage="0-100 arası değer" MaximumValue="100" MinimumValue="0"
                    Type="Integer"></asp:RangeValidator>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="RadioButtonList1"
                    Display="None" ErrorMessage="Boş geçme ">*</asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
            </td>
        </tr>
        <tr>
            <td colspan="2">
            </td>
        </tr>
        <tr>
            <td colspan="2">
            </td>
        </tr>
        <tr>
            <td colspan="2">
            </td>
        </tr>
        <tr>
            <td colspan="2">
            </td>
        </tr>
        <tr>
            <td colspan="2">
            </td>
        </tr>
        <tr>
            <td colspan="2">
            </td>
        </tr>
        <tr>
            <td colspan="2">
            </td>
        </tr>
        <tr>
            <td colspan="2">
            </td>
        </tr>
        <tr>
            <td colspan="2">
            </td>
        </tr>
    </table>

    </div>
    </form>
</body>
</html>