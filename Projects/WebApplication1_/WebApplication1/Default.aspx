<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
    <link href="Stylesheet1.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <div>
                <asp:Label ID="Label1" runat="server" Font-Names="Verdana" Font-Size="11px" Text="ARAMA"></asp:Label>
                <asp:TextBox ID="TextBox1" runat="server" Height="22px" Width="306px"></asp:TextBox>
                <cc1:TextBoxWatermarkExtender ID="TextBox1_TextBoxWatermarkExtender" runat="server"
                    Enabled="True" WatermarkCssClass="aramaTXT" WatermarkText="Lütfen Sadece Kullanıcı adını giriniz..."
                    TargetControlID="TextBox1">
                </cc1:TextBoxWatermarkExtender>
                <asp:Button ID="Button1" runat="server" Height="26px" Text="BUL" Width="79px" OnClick="Button1_Click" />
            </div>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4"
                DataKeyNames="UrunId" DataSourceID="UrunlerVeriKaynagi" Font-Names="Verdana"
                Font-Size="11px" ForeColor="#333333" GridLines="Horizontal" Width="430px">
                <RowStyle BackColor="#EFF3FB" />
                <Columns>
                    <asp:BoundField DataField="UrunId" HeaderText="UrunId" InsertVisible="False" ReadOnly="True"
                        SortExpression="UrunId" />
                    <asp:BoundField DataField="UrunAdi" HeaderText="UrunAdi" SortExpression="UrunAdi" />
                </Columns>
                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <EditRowStyle BackColor="#2461BF" />
                <AlternatingRowStyle BackColor="White" />
            </asp:GridView>
            <asp:SqlDataSource ID="UrunlerVeriKaynagi" runat="server" ConnectionString="<%$ ConnectionStrings:YazilimWorksConnectionString %>"
                SelectCommand="SELECT [UrunId], [UrunAdi] FROM [Urun] ORDER BY [UrunAdi]"></asp:SqlDataSource>
        </ContentTemplate>
    </asp:UpdatePanel>
    </form>
</body>
</html>
