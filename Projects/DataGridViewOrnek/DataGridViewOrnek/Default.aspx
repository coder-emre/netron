<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DataGridViewOrnek._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>GridView</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
    <asp:GridView ID="GridView1" runat="server" BackColor="White" 
        BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" 
        GridLines="Vertical" AutoGenerateColumns="False" DataKeyNames="KITAPID" 
        DataSourceID="Verikaynagi" Font-Names="Verdana" Font-Size="13px" 
        onrowupdating="GridView1_RowUpdating">
        <FooterStyle BackColor="#CCCCCC"  ForeColor="Black" />
        <RowStyle BackColor="#93bee2" ForeColor="Black" />
        <Columns>
            <asp:CommandField ShowEditButton="True" />
            <asp:BoundField DataField="KITAPID" HeaderText="KITAPID" ReadOnly="True" 
                SortExpression="KITAPID" />
            <asp:TemplateField HeaderText="KITAP" SortExpression="KITAP">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("KITAP") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%# Bind("KITAP") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="RESIM" SortExpression="RESIM">
                <EditItemTemplate>
                    <asp:FileUpload ID="FileUpload1" runat="server" />
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Image ID="Image1" runat="server" Height="50px" 
                        ImageUrl='<%# Eval("RESIM") %>' Width="50px" />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
        <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
        <AlternatingRowStyle BackColor="#ffffff" ForeColor="Maroon" />
    </asp:GridView>
    <asp:SqlDataSource ID="Verikaynagi" runat="server" 
        ConnectionString="<%$ ConnectionStrings:YazilimWorksConnectionString2 %>" 
        DeleteCommand="DELETE FROM [KITAPLAR] WHERE [KITAPID] = @KITAPID" 
        InsertCommand="INSERT INTO [KITAPLAR] ([KITAPID], [KITAP], [RESIM]) VALUES (@KITAPID, @KITAP, @RESIM)" 
        SelectCommand="SELECT * FROM [KITAPLAR]" 
        UpdateCommand="UPDATE [KITAPLAR] SET [KITAP] = @KITAP, [RESIM] = @RESIM WHERE [KITAPID] = @KITAPID">
        <DeleteParameters>
            <asp:Parameter Name="KITAPID" Type="Int32" />
        </DeleteParameters>
        <UpdateParameters>
            <asp:Parameter Name="KITAP" Type="String" />
            <asp:SessionParameter Name="RESIM" SessionField="ResimAdresi" Type="String" />
            <asp:Parameter Name="KITAPID" Type="Int32" />
        </UpdateParameters>
        <InsertParameters>
            <asp:Parameter Name="KITAPID" Type="Int32" />
            <asp:Parameter Name="KITAP" Type="String" />
            <asp:Parameter Name="RESIM" Type="String" />
        </InsertParameters>
    </asp:SqlDataSource>
    </form>
</body>
</html>
