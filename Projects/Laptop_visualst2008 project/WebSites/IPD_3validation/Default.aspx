<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style2
        {
            width: 170px;
        }
        .style3
        {
            width: 133px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 90px">
    
        <table class="style1">
            <tr>
                <td class="style3">
                    <asp:Label ID="Label1" runat="server" Text="AD"></asp:Label>
                </td>
                <td class="style2">
                    <asp:TextBox ID="txt_ad" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                        ControlToValidate="txt_ad" ErrorMessage="boş geçilemez">*</asp:RequiredFieldValidator>
                    <asp:RangeValidator ID="RangeValidator1" runat="server" 
                        ControlToValidate="txt_ad" ErrorMessage="ÇOK UZUN" MaximumValue="10" 
                        MinimumValue="4" Type="Integer">*</asp:RangeValidator>
                </td>
            </tr>
            <tr>
                <td class="style3">
                    <asp:Label ID="Label2" runat="server" Text="PAROLA"></asp:Label>
                </td>
                <td class="style2">
                    <asp:TextBox ID="txt_sifre" runat="server" TextMode="Password"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                        ControlToValidate="txt_sifre" ErrorMessage="boş geçilemez">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style3">
                    <asp:Label ID="Label3" runat="server" Text="PAROLA TEKRAR"></asp:Label>
                </td>
                <td class="style2">
                    <asp:TextBox ID="txt_sifretekrar" runat="server" TextMode="Password"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                        ControlToValidate="txt_sifretekrar" ErrorMessage="boş geçilemez">*</asp:RequiredFieldValidator>
                    <asp:CompareValidator ID="CompareValidator1" runat="server" 
                        ControlToCompare="txt_sifre" ControlToValidate="txt_sifretekrar" 
                        ErrorMessage="Parola aynı olmalı">*</asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td class="style3">
                    <asp:Label ID="Label4" runat="server" Text="EMAIL"></asp:Label>
                </td>
                <td class="style2">
                    <asp:TextBox ID="txt_email" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                        ControlToValidate="txt_email" ErrorMessage="yanlış tip girdiniz" 
                        ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="style3">
                    &nbsp;</td>
                <td class="style2">
                    <asp:Button ID="btn_gonder" runat="server" Height="26px" Text="GONDER" />
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style3">
                    &nbsp;</td>
                <td class="style2">
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" Width="208px" />
                </td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
