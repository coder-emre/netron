<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DersKontroller2._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
    <style type="text/css">
        .style1
        {
            width: 100%;
            height: 399px;
        }
        .style2
        {
            height: 319px;
        }
        .style3
        {
            height: 319px;
            width: 244px;
        }
        .style4
        {
            height: 24px;
        }
        .style5
        {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <input type="hidden" runat="server" id="kitapID" value="123" />
        <asp:HiddenField ID="hd_UrunID" runat="server" Value="-1" />
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
            Text="Kontrol Et" />
            <marquee>Hava Durumları : istanbulda hava 24 derece olacak.Ankarada hava 26 derece olacak</marquee>
    </div>
    
    <table border="1" class="style1">
        <tr>
            <td class="style4" colspan="2">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style3" valign="top">
                <asp:MultiView ID="MultiView1" runat="server">
                    <table class="style5">
                        <tr>
                            <td>
                                <asp:View ID="vw_KullaniciGiris" runat="server">
                                    <table class="style5">
                                        <tr>
                                            <td>
                                                <asp:Label ID="Label1" runat="server" Font-Names="Verdana" Font-Size="11px" 
                                                    Text="KULLANICI ADI"></asp:Label>
                                            </td>
                                            <td>
                                                :</td>
                                            <td>
                                                <asp:TextBox ID="TextBox1" runat="server" Width="120px"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <asp:Label ID="Label2" runat="server" Font-Names="Verdana" Font-Size="11px" 
                                                    Text="ŞİFRE"></asp:Label>
                                            </td>
                                            <td>
                                                :</td>
                                            <td>
                                                <asp:TextBox ID="TextBox2" runat="server" Width="120px"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                &nbsp;</td>
                                            <td>
                                                &nbsp;</td>
                                            <td>
                                                <asp:Button ID="Button2" runat="server" Font-Names="Verdana" Font-Size="11px" 
                                                    onclick="Button2_Click" Text="GİRİŞ" />
                                            </td>
                                        </tr>
                                    </table>
                                </asp:View>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:View ID="vw_KayitliKullanici" runat="server">
                                    <table class="style5">
                                        <tr>
                                            <td>
                                                <asp:Label ID="lbl_kullanici" runat="server" Font-Names="Verdana" 
                                                    Font-Size="11px" Text="Hoşgeldiniz ..."></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td align="center">
                                                <asp:LinkButton ID="LinkButton1" runat="server" Font-Names="Verdana" 
                                                    Font-Size="11px" onclick="LinkButton1_Click">Güvenli Çıkış</asp:LinkButton>
                                            </td>
                                        </tr>
                                    </table>
                                </asp:View>
                            </td>
                        </tr>
                    </table>
                </asp:MultiView>
            </td>
            <td class="style2" valign="bottom" align="right">
                <asp:Panel Width="150px" ID="Panel1" runat="server">
                </asp:Panel>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                &nbsp;</td>
        </tr>
    </table>
    
    </form>
</body>
</html>
