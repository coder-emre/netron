<%@ Page Language="C#" AutoEventWireup="true" CodeFile="main.aspx.cs" Inherits="main" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Main Page</title>
</head>
<body style="background-image: url('master03_background.png');">
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False"
            CellPadding="4" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None"
            OnSelectedIndexChanged="GridView1_SelectedIndexChanged" Style="left: 88px; position: absolute;
            top: 160px; z-index: 100;">
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <Columns>
                <asp:CommandField ShowSelectButton="True" />
                <asp:BoundField DataField="Stores" HeaderText="Stores" SortExpression="Stores" />
                <asp:BoundField DataField="Store_adress" HeaderText="Store_adress" SortExpression="Store_adress" />
                <asp:BoundField DataField="Store_phone" HeaderText="Store_phone" SortExpression="Store_phone" />
            </Columns>
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <EditRowStyle BackColor="#999999" />
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        </asp:GridView>
        <asp:TextBox ID="TextBox1" runat="server" Style="left: 108px; position: absolute;
            top: -119px; z-index: 101;"></asp:TextBox>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:SiparisConnectionString %>"
            SelectCommand="SELECT [Stores] , [Store_adress], [Store_phone] FROM [Store]"></asp:SqlDataSource>
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        &nbsp;&nbsp;<span style="font-family: Agency FB"> <strong><span
            style="font-size: 16pt">&nbsp;&nbsp;
            <br />
            &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
            &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
            &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
            &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
            &nbsp; &nbsp; &nbsp; <span style="font-family: Times New Roman Tur">ONLINE SÝPARÝÞ SÝSTEMÝ</span></span></strong></span><asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:SiparisConnectionString %>"
            SelectCommand="SELECT COUNT(*) AS En_Cok_Siparis, Order_place FROM [Order] GROUP BY Order_place">
        </asp:SqlDataSource>
        &nbsp; &nbsp;&nbsp;&nbsp;
        <asp:SqlDataSource  ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:SiparisConnectionString %>"
            SelectCommand="SELECT [Order].Order_id, [Order].Order_place, [Order].Order_time, [Order].Order_details, [User].User_name, [User].User_Surname FROM [Order] INNER JOIN [User] ON [Order].User_id = [User].User_id" 
            UpdateCommand="UPDATE [Order] SET [Order_details] = @Order_details WHERE [Order].User_id = @User_id_Param AND[Order_id] = @original_Order_id AND [Order_place] = @original_Order_place AND [Order_time] = @original_Order_time AND [Order_details] = @original_Order_details" 
            ConflictDetection="CompareAllValues" 
            DeleteCommand="DELETE FROM [Order] FROM [Order] INNER JOIN [User] ON [Order].User_id = [User].User_id AND [Order].User_id = @User_id_Param WHERE ([Order].Order_id = @original_Order_id) AND ([Order].Order_place = @original_Order_place) AND ([Order].Order_time = @original_Order_time) AND ([Order].Order_details = @original_Order_details)" 
            InsertCommand="INSERT INTO [Order] ([Order_id], [Order_place], [Order_time], [Order_details]) VALUES (@Order_id, @Order_place, @Order_time, @Order_details)" OldValuesParameterFormatString="original_{0}">
            <DeleteParameters>
                <asp:SessionParameter SessionField="username" Name="User_id_Param" Type="string" />
                <asp:Parameter Name="original_Order_id" Type="Int32" />
                <asp:Parameter Name="original_Order_place" Type="String" />
                <asp:Parameter Name="original_Order_time" Type="String" />
                <asp:Parameter Name="original_Order_details" Type="String" />
            </DeleteParameters>
            <UpdateParameters>
                <asp:SessionParameter SessionField="username" Name="User_id_Param" Type="string" />
                <asp:Parameter Name="Order_place" Type="String" />
                <asp:Parameter Name="Order_time" Type="String" />
                <asp:Parameter Name="Order_details" Type="String" />
                <asp:Parameter Name="original_Order_id" Type="Int32" />
                <asp:Parameter Name="original_Order_place" Type="String" />
                <asp:Parameter Name="original_Order_time" Type="String" />
                <asp:Parameter Name="original_Order_details" Type="String" />
            </UpdateParameters>
            <InsertParameters>
                <asp:Parameter Name="Order_id" Type="Int32" />
                <asp:Parameter Name="Order_place" Type="String" />
                <asp:Parameter Name="Order_time" Type="String" />
                <asp:Parameter Name="Order_details" Type="String" /> 
            </InsertParameters>
        </asp:SqlDataSource>
        <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Style="z-index: 103;
            left: 463px; position: absolute; top: 360px" Text="Tüm Sipariþleri Sil" Visible="False"
            Width="142px" />
        <asp:Label ID="Label6" runat="server" Style="z-index: 104; left: 510px; position: absolute;
            top: 626px" Text="2008 August Interns - Istanbul" Width="206px"></asp:Label>
        &nbsp;
        &nbsp;&nbsp;
        <asp:TextBox ID="TextBox2" runat="server" BackColor="White" Height="128px" Style="left: 90px;
            position: absolute; top: 388px; z-index: 105;" TextMode="MultiLine" Width="319px" ToolTip="Sipariþinizi Buraya Yazýnýz">Please, write your order here</asp:TextBox>
        <asp:Label ID="Label1" runat="server" BackColor="#E0E0E0" Height="19px" Style="left: 92px;
            position: absolute; top: 362px; z-index: 106;" Text="Seçilen Restorant:" Width="111px"></asp:Label>
        <asp:Label ID="Label2" runat="server" BackColor="Silver" Height="20px" Style="left: 222px;
            position: absolute; top: 361px; z-index: 107;" Text="  " Width="130px"></asp:Label>
        <asp:Button ID="Button1" runat="server" Style="left: 317px; position: absolute; top: 534px; z-index: 108;"
            Text="Siparis Ver!" OnClick="Button1_Click" />
        &nbsp;
        <asp:GridView ID="GridView2" runat="server" DataSourceID="SqlDataSource2"
            Style="left: 461px; position: absolute; top: 160px; z-index: 109;"  Width="196px" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" AllowSorting="True" AllowPaging="True"  Height="100px" PageSize="3" OnSelectedIndexChanged="GridView2_SelectedIndexChanged" ToolTip="Soldaki seçeneklerden, verdiðiniz sipariþleri Silebilir veya Siparis Ayrýntýlarýný deðiþtirebilirsiniz" OnRowDeleted="GridView2_RowDeleted">
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <EditRowStyle BackColor="#999999" />
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:CommandField ButtonType="Button"  ShowDeleteButton="True"  ShowEditButton="True">
                    <ControlStyle BackColor="Gainsboro"/>
                </asp:CommandField>
                <asp:BoundField DataField="Order_id" HeaderText="Order_id" ReadOnly="True" SortExpression="Order_id" />
                <asp:BoundField DataField="Order_place" HeaderText="Order_place" SortExpression="Order_place" />
                <asp:BoundField DataField="Order_time" HeaderText="Order_time" SortExpression="Order_time" />
                <asp:BoundField DataField="Order_details" HeaderText="Order_details" SortExpression="Order_details" />
                <asp:BoundField DataField="User_name" HeaderText="User_name" SortExpression="User_name" />
                <asp:BoundField DataField="User_Surname" HeaderText="User_Surname" SortExpression="User_Surname" />
            </Columns>
        </asp:GridView>
        &nbsp;
        <asp:Label ID="Label3" runat="server" Height="21px" Text="Label" Width="227px" style="left: 13px; position: absolute; top: 91px; z-index: 110;" BackColor="#C0FFC0"></asp:Label>
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Style="left: 249px;
            position: absolute; top: 90px; z-index: 111;" Text="Çýkýþ" BackColor="#C0FFC0" ToolTip="Çýkýþ Yapabilirsiniz" />
    </div>
        &nbsp;&nbsp;
        <asp:Image ID="Image1" runat="server" Style="left: 466px; position: absolute; top: 114px; z-index: 112;" />
        &nbsp;
        <asp:GridView ID="GridView3" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Height="59px"
            PageSize="3" Style="left: 464px; position: absolute; top: 396px; z-index: 113;" Width="137px">
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <EditRowStyle BackColor="#999999" />
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        </asp:GridView>
        <asp:Label ID="Label4" runat="server" Style="left: 702px; position: absolute; top: 394px; z-index: 114;"
            Text="Label" Width="318px" BackColor="Control" Height="24px"></asp:Label>
        &nbsp;&nbsp;
        <asp:Label ID="Label5" runat="server" Height="94px" Style="z-index: 115; left: 703px;
            position: absolute; top: 435px" Text="Siparis Tarihi Duyurusu" Width="316px" BackColor="PaleTurquoise"></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server" Style="z-index: 116;
            left: 704px; position: absolute; top: 541px" Visible="False" Width="262px" ToolTip="Lütfen Tarihi Belirtilen Þekilde Giriniz!">Gun.Ay.Yýl Saat:Dakika:Saniye</asp:TextBox>
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Style="z-index: 117;
            left: 978px; position: absolute; top: 540px" Text="Ekle" Visible="False" Width="41px" />
        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Style="left: 703px;
            position: absolute; top: 570px; z-index: 118;" Text="Sipariþ Ýþlemlerini Sonlandýr" Visible="False"
            Width="166px" />
        <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Style="left: 869px;
            position: absolute; top: 570px; z-index: 119;" Text="Sipariþ Ýþlemlerini Baþlat" Visible="False"
            Width="151px" />
    </form>
</body>
</html>
