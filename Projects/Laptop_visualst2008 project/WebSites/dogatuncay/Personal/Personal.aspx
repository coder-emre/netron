<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Personal.aspx.cs" Inherits="Personal" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body bgcolor="#000000">
    <form id="form1" runat="server">
    <div>
    
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Font-Bold="True" ForeColor="White" 
            Text="Edit Weekly Class Schedule"></asp:Label>
        <asp:Label ID="lblQuery" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
       <asp:Label ID="lbl_lessonname" runat="server" Font-Bold="True" ForeColor="White" Text="Lesson Name :"></asp:Label>
       <asp:TextBox ID="txt_lessonname" runat="server"></asp:TextBox>
            <br />
        <asp:Label ID="lbl_teacher" runat="server" Font-Bold="True" ForeColor="White" Text="Teacher :"></asp:Label>
        <asp:TextBox ID="txt_teacher" runat="server"></asp:TextBox>
            <br />
       <asp:Label ID="lbl_lessonp" runat="server" Font-Bold="True" ForeColor="White" Text="About Lesson :"></asp:Label>
       <asp:TextBox ID="txt_lessonp" runat="server"></asp:TextBox>
            <br />
        <asp:Label ID="lbl_lessonday" runat="server"  Font-Bold="True" ForeColor="White" Text="Lesson Day :"></asp:Label>
        <asp:TextBox ID="txt_lessonday" runat="server"></asp:TextBox>
            <br />
        <asp:Label ID="lbl_lessontime" runat="server" Font-Bold="True" ForeColor="White"  Text="Lesson Time :"></asp:Label>
        <asp:TextBox ID="txt_lessontime" runat="server"></asp:TextBox>
            <br />
       <asp:Label ID="lbl_lessonclass" runat="server" Font-Bold="True" ForeColor="White" Text="Lesson Class :"></asp:Label>
       <asp:TextBox ID="txt_lessonclass" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btn_update" runat="server" Text="Submit" Font-Bold="True" onclick="btn_update_Click" 
            />
       <br />
       <br />
       <br />
        <asp:GridView ID="grd_schedule" runat="server" AutoGenerateColumns="False" 
            BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
            CellPadding="4" DataSourceID="SqlDataVeri" ForeColor="Black" 
            GridLines="Horizontal">
            <Columns>
                <asp:BoundField DataField="ders_adi" HeaderText="Lesson Name" 
                    SortExpression="ders_adi" />
                <asp:BoundField DataField="ders_hoca" HeaderText="Teacher" 
                    SortExpression="ders_hoca" />
                <asp:BoundField DataField="ders_tanimi" HeaderText="About Lesson" 
                    SortExpression="ders_tanimi" />
                <asp:BoundField DataField="ders_gün" HeaderText="Lesson Day" 
                    SortExpression="ders_gün" />
                <asp:BoundField DataField="ders_saat" HeaderText="Lesson Time" 
                    SortExpression="ders_saat" />
                <asp:BoundField DataField="ders_sınıf" HeaderText="Lesson Class" 
                    SortExpression="ders_sınıf" />
            </Columns>
            <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
            <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
            <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataVeri" runat="server" 
            ConnectionString="<%$ ConnectionStrings:dogatuncayConnectionString3 %>" 
            
            SelectCommand="SELECT [ders_adi], [ders_hoca], [ders_tanimi], [ders_gün], [ders_saat], [ders_sınıf] FROM [Lessons]" 
            InsertCommand="INSERT INTO Lessons(ders_adi, ders_hoca, ders_tanimi, ders_gün, ders_saat, ders_sınıf) VALUES (@ders_adi, @ders_hoca, @desr_tanimi, @ders_gun, @ders_saat, @ders_sinif)">
            <InsertParameters>
                <asp:ControlParameter ControlID="txt_lessonname" Name="ders_adi" 
                    PropertyName="Text" />
                <asp:ControlParameter ControlID="txt_teacher" Name="ders_hoca" 
                    PropertyName="Text" />
                <asp:ControlParameter ControlID="txt_lessonp" Name="desr_tanimi" 
                    PropertyName="Text" />
                <asp:ControlParameter ControlID="txt_lessonday" Name="ders_gun" 
                    PropertyName="Text" />
                <asp:ControlParameter ControlID="txt_lessontime" Name="ders_saat" 
                    PropertyName="Text" />
                <asp:ControlParameter ControlID="txt_lessonclass" Name="ders_sinif" 
                    PropertyName="Text" />
            </InsertParameters>
        </asp:SqlDataSource>
    </div>
    </form>
</body>
</html>
