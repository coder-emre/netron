<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 100%;
            height: 303px;
        }
        .style2
        {
            width: 145px;
        }
        .style3
        {
            width: 61px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="style1">
            <tr>
                <td class="style2">
                    &nbsp;</td>
                <td class="style3">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style2">
                    <asp:Label ID="lblArizaBarkod" runat="server" Text="Barkod No:"></asp:Label>
                </td>
                <td class="style3">
                    <asp:TextBox ID="txtArizaBarkod" runat="server"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style2">
                    <asp:Label ID="lblArizaTarihi" runat="server" Text="Arıza Tarihi:"></asp:Label>
                </td>
                <td class="style3">
                    <asp:TextBox ID="txtArizaTarihi" runat="server"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style2">
                    <asp:Label ID="lblGönderilmeTarihi" runat="server" Text="Gönderilme Tarihi:"></asp:Label>
                </td>
                <td class="style3">
                    <asp:TextBox ID="txtGonderilmeTarihi" runat="server"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style2">
                    <asp:Label ID="lblArizaAciklama" runat="server" Text="Arıza Açıklaması:"></asp:Label>
                </td>
                <td class="style3" rowspan="2">
                    <asp:TextBox ID="txtArizaAciklama" runat="server" Height="47px" 
                        TextMode="MultiLine"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style2">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style2">
                    <asp:Label ID="lblServis" runat="server" Text="Servis:"></asp:Label>
                </td>
                <td class="style3">
                    <asp:DropDownList ID="ddlServis" runat="server" Height="16px" Width="168px">
                    </asp:DropDownList>
                </td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style2">
                    &nbsp;</td>
                <td class="style3">
                    <asp:Button ID="btnArizaKaydet" runat="server" onclick="Button2_Click" 
                        Text="KAYDET" />
                </td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
