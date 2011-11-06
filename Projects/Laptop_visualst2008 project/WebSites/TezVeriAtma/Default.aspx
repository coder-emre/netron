<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    
    <style type="text/css">
        .style1
        {
            height: 143px;
        }
        .style2
        {
            width: 54px;
        }
        .style3
        {
            height: 143px;
            width: 54px;
        }
        .style4
        {
            width: 115px;
        }
        .style5
        {
            height: 143px;
            width: 115px;
        }
        .style6
        {
            width: 151px;
        }
        .style7
        {
            height: 143px;
            width: 151px;
        }
        .style8
        {
            width: 138px;
        }
        .style9
        {
            height: 143px;
            width: 138px;
        }
        .style10
        {
            width: 92px;
        }
        .style11
        {
            height: 143px;
            width: 92px;
        }
        .style12
        {
            width: 161px;
        }
        .style13
        {
            height: 143px;
            width: 161px;
        }
        .style14
        {
            width: 69px;
        }
        .style15
        {
            height: 143px;
            width: 69px;
        }
    </style>
    
</head>
<body>
    <form id="form1" runat="server">
    <div>

        <table style="width: 875px">
        <tr>
            <td class="style6" >
                  <asp:Label ID="Label4" runat="server" Text="Fakülte"></asp:Label>
        <asp:DropDownList ID="ddl_fakultedoldur" runat="server"  
                      DataTextField="fakulte" DataValueField="fakulte" DataSourceID="sql">
        </asp:DropDownList>
                                    <asp:SqlDataSource ID="sql" runat="server" 
                      ConnectionString="<%$ ConnectionStrings:dersgirConnectionString %>" 
                      SelectCommand="SELECT [fakulte] FROM [fakulte]"></asp:SqlDataSource>
                                    <br />
        <asp:Label ID="Label5" runat="server" Text="Bölüm"></asp:Label>
        <asp:DropDownList ID="ddl_bolumdoldur" runat="server" 
                      DataTextField="bolum" DataValueField="bolum" DataSourceID="sql2">
        </asp:DropDownList>
                  <asp:SqlDataSource ID="sql2" runat="server" 
                      ConnectionString="<%$ ConnectionStrings:dersgirConnectionString %>" 
                      SelectCommand="SELECT [bolum] FROM [bolum]"></asp:SqlDataSource>
                  <br />
        <asp:Label ID="Label6" runat="server" Text="Ders"></asp:Label>
        <asp:DropDownList ID="ddl_dersdoldur" runat="server" 
                      DataTextField="ders" DataValueField="ders" Height="16px" 
                      DataSourceID="sql3" >
        </asp:DropDownList>
                  <asp:SqlDataSource ID="sql3" runat="server" 
                      ConnectionString="<%$ ConnectionStrings:dersgirConnectionString %>" 
                      SelectCommand="SELECT [ders] FROM [dersmoda]"></asp:SqlDataSource>
            </td>
            <td class="style8">
                <asp:RadioButtonList ID="rbl_sene" runat="server" 
                    style="margin-left: 0px">
                    <asp:ListItem>2006-2007</asp:ListItem>
                    <asp:ListItem>2007-2008</asp:ListItem>
                    <asp:ListItem>2008-2009</asp:ListItem>
                    <asp:ListItem>2009-2010</asp:ListItem>
                </asp:RadioButtonList>
            </td>
            <td class="style10">
                <asp:RadioButtonList ID="rbl_donem" runat="server">
                    <asp:ListItem>Spring</asp:ListItem>
                    <asp:ListItem>Fall</asp:ListItem>
                </asp:RadioButtonList>
            </td>
            <td class="style2" >
                <asp:Label ID="Label10" runat="server" Text="Sinif"></asp:Label>
                <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                    <asp:ListItem>1</asp:ListItem>
                    <asp:ListItem>2</asp:ListItem>
                    <asp:ListItem>3</asp:ListItem>
                    <asp:ListItem>4</asp:ListItem>
                </asp:RadioButtonList>
            </td>
            <td class="style14" >
                <asp:RadioButtonList ID="RadioButtonList2" runat="server" Height="66px">
                    <asp:ListItem Value="A">A</asp:ListItem>
                    <asp:ListItem>B</asp:ListItem>
                    <asp:ListItem>Grup Yok</asp:ListItem>
                </asp:RadioButtonList>
            </td>
            <td class="style12" >
                
               <asp:RadioButtonList ID="rbl_gun" runat="server">
                   <asp:ListItem>Monday</asp:ListItem>
                   <asp:ListItem>Tuesday</asp:ListItem>
                   <asp:ListItem>Wednesday</asp:ListItem>
                   <asp:ListItem>Thursday</asp:ListItem>
                   <asp:ListItem>Friday</asp:ListItem>
                   <asp:ListItem>Saturday</asp:ListItem>
        </asp:RadioButtonList>  
        </td>
            <td class="style4">
                
        <asp:RadioButtonList ID="rbl_saat" runat="server">
            <asp:ListItem>9000</asp:ListItem>
            <asp:ListItem>1000</asp:ListItem>
            <asp:ListItem>1100</asp:ListItem>
            <asp:ListItem>1200</asp:ListItem>
            <asp:ListItem>1300</asp:ListItem>
            <asp:ListItem>1400</asp:ListItem>
            <asp:ListItem>1500</asp:ListItem>
            <asp:ListItem>1600</asp:ListItem>
            <asp:ListItem>1700</asp:ListItem>
        </asp:RadioButtonList>
        </td>
            <td>
                
                <asp:Label ID="Label11" runat="server" Text="Ders Suresi"></asp:Label>
                <asp:RadioButtonList ID="rbl_derssuresi" runat="server">
                    <asp:ListItem>1</asp:ListItem>
                    <asp:ListItem>2</asp:ListItem>
                    <asp:ListItem>3</asp:ListItem>
                    <asp:ListItem>4</asp:ListItem>
                </asp:RadioButtonList>
        </td>
        </tr>
        <tr>
            <td class="style6">
                &nbsp;</td>
            <td class="style8">
                &nbsp;</td>
            <td class="style10">
                &nbsp;</td>
            <td class="style2">
                </td>
            <td class="style14">
                &nbsp;</td>
            <td class="style12">
                
            </td>
            <td class="style4" >
                <asp:Button ID="Button1" runat="server" Text="Gir" onclick="Button1_Click" />
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:dersgirConnectionString %>" 
                    InsertCommand="INSERT INTO aggre(sinif, bolum, fakulte, ders, donem, sene, saat, gun, grup, derssure) VALUES (@sinifgiris, @bolumdoldur, @fakultedoldur, @dersgiris, @donemgiris, @senegiris, @saatgiris, @gungiris, @grupgir, @derssuresi)" 
                    SelectCommand="SELECT * FROM [aggre]">
                    <InsertParameters>
                        <asp:ControlParameter ControlID="RadioButtonList1" Name="sinifgiris" 
                            PropertyName="SelectedValue" />
                        <asp:ControlParameter ControlID="ddl_bolumdoldur" Name="bolumdoldur" 
                            PropertyName="SelectedValue" />
                        <asp:ControlParameter ControlID="ddl_fakultedoldur" Name="fakultedoldur" 
                            PropertyName="SelectedValue" />
                        <asp:ControlParameter ControlID="ddl_dersdoldur" Name="dersgiris" 
                            PropertyName="SelectedValue" />
                        <asp:ControlParameter ControlID="rbl_donem" Name="donemgiris" 
                            PropertyName="SelectedValue" />
                        <asp:ControlParameter ControlID="rbl_sene" Name="senegiris" 
                            PropertyName="SelectedValue" />
                        <asp:ControlParameter ControlID="rbl_saat" Name="saatgiris" 
                            PropertyName="SelectedValue" />
                        <asp:ControlParameter ControlID="rbl_gun" Name="gungiris" 
                            PropertyName="SelectedValue" />
                        <asp:ControlParameter ControlID="RadioButtonList2" Name="grupgir" 
                            PropertyName="SelectedValue" />
                        <asp:ControlParameter ControlID="rbl_derssuresi" Name="derssuresi" 
                            PropertyName="SelectedValue" />
                    </InsertParameters>
                </asp:SqlDataSource>
            </td>
            <td >
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style7">
                &nbsp;</td>
            <td class="style9" >
                &nbsp;</td>
            <td class="style11" >
                &nbsp;</td>
            <td class="style3" >
                &nbsp;</td>
            <td class="style15" >
                &nbsp;</td>
            <td class="style13" >
                &nbsp;</td>
            <td class="style5" >
                </td>
            <td class="style1" >
                &nbsp;</td>
        </tr>

    </table>   
        
        </div>
    </form>

</body>
</html>
