<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="gvUrunler" runat="server" AutoGenerateColumns="False" 
            DataKeyNames="ID" DataSourceID="SqlDataSource1" 
           >
            <Columns>
                <asp:BoundField DataField="ID" HeaderText="ID" InsertVisible="False" 
                    ReadOnly="True" SortExpression="ID" />
                <asp:BoundField DataField="BarkodNo" HeaderText="BarkodNo" 
                    SortExpression="BarkodNo" />
                <asp:BoundField DataField="MarkaId" HeaderText="MarkaId" 
                    SortExpression="MarkaId" />
                <asp:BoundField DataField="KategoriId" HeaderText="KategoriId" 
                    SortExpression="KategoriId" />
                <asp:BoundField DataField="Model" HeaderText="Model" SortExpression="Model" />
                <asp:BoundField DataField="Aciklama" HeaderText="Aciklama" 
                    SortExpression="Aciklama" />
                <asp:BoundField DataField="BirimId" HeaderText="BirimId" 
                    SortExpression="BirimId" />
                <asp:BoundField DataField="BirimDeger" HeaderText="BirimDeger" 
                    SortExpression="BirimDeger" />
                <asp:BoundField DataField="OdaId" HeaderText="OdaId" SortExpression="OdaId" />
                <asp:BoundField DataField="FakulteId" HeaderText="FakulteId" 
                    SortExpression="FakulteId" />
                <asp:BoundField DataField="KampusId" HeaderText="KampusId" 
                    SortExpression="KampusId" />
            </Columns>
        </asp:GridView>
    
    </div>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:BimDemirbasTakipConnectionString %>" 
        DeleteCommand="DELETE FROM [Urunler] WHERE [ID] = @ID" 
        InsertCommand="INSERT INTO [Urunler] ([BarkodNo], [MarkaId], [KategoriId], [Model], [Aciklama], [BirimId], [BirimDeger], [OdaId], [FakulteId], [KampusId]) VALUES (@BarkodNo, @MarkaId, @KategoriId, @Model, @Aciklama, @BirimId, @BirimDeger, @OdaId, @FakulteId, @KampusId)" 
        SelectCommand="SELECT * FROM [Urunler]" 
        UpdateCommand="UPDATE [Urunler] SET [BarkodNo] = @BarkodNo, [MarkaId] = @MarkaId, [KategoriId] = @KategoriId, [Model] = @Model, [Aciklama] = @Aciklama, [BirimId] = @BirimId, [BirimDeger] = @BirimDeger, [OdaId] = @OdaId, [FakulteId] = @FakulteId, [KampusId] = @KampusId WHERE [ID] = @ID">
        <DeleteParameters>
            <asp:Parameter Name="ID" Type="Int32" />
        </DeleteParameters>
        <UpdateParameters>
            <asp:Parameter Name="BarkodNo" Type="Int32" />
            <asp:Parameter Name="MarkaId" Type="Int32" />
            <asp:Parameter Name="KategoriId" Type="Int32" />
            <asp:Parameter Name="Model" Type="String" />
            <asp:Parameter Name="Aciklama" Type="String" />
            <asp:Parameter Name="BirimId" Type="Int32" />
            <asp:Parameter Name="BirimDeger" Type="String" />
            <asp:Parameter Name="OdaId" Type="Int32" />
            <asp:Parameter Name="FakulteId" Type="Int32" />
            <asp:Parameter Name="KampusId" Type="Int32" />
            <asp:Parameter Name="ID" Type="Int32" />
        </UpdateParameters>
        <InsertParameters>
            <asp:Parameter Name="BarkodNo" Type="Int32" />
            <asp:Parameter Name="MarkaId" Type="Int32" />
            <asp:Parameter Name="KategoriId" Type="Int32" />
            <asp:Parameter Name="Model" Type="String" />
            <asp:Parameter Name="Aciklama" Type="String" />
            <asp:Parameter Name="BirimId" Type="Int32" />
            <asp:Parameter Name="BirimDeger" Type="String" />
            <asp:Parameter Name="OdaId" Type="Int32" />
            <asp:Parameter Name="FakulteId" Type="Int32" />
            <asp:Parameter Name="KampusId" Type="Int32" />
        </InsertParameters>
    </asp:SqlDataSource>
    <asp:RadioButtonList ID="rbl" runat="server">
        <asp:ListItem>görüntülenen</asp:ListItem>
        <asp:ListItem>ilk 50</asp:ListItem>
        <asp:ListItem>hepsi</asp:ListItem>
    </asp:RadioButtonList>
    <br />
    <br />
    <asp:Button ID="Button1" runat="server" Text="Button" 
        onclick="Button1_Click1" />
    
    </form>
</body>
</html>
