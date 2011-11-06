<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Untitled Page</title>
    <link type="text/css" href="_assets/css/round.css" rel="stylesheet" />    
    <link type="text/css" href="_assets/css/grid.css" rel="stylesheet" />    
    <script type='text/javascript'>_spOriginalFormAction = document.forms[0].action; _spSuppressFormOnSubmitWrapper=true;</script>
</head>
<body>    
    <form id="form1" runat="server">
        <asp:ScriptManager ID="scriptManager" runat="server" />            
        <div class="grid">            
            <div class="rounded">
                <div class="top-outer"><div class="top-inner"><div class="top">
                </div></div></div>
                <div class="mid-outer"><div class="mid-inner"><div class="mid">   
                    <asp:UpdatePanel ID="updatePanel" runat="server" UpdateMode="Conditional">
                        <ContentTemplate>
                            <asp:ListView ID="lvUrunler" runat="server" 
                                DataSourceID="dsGridview" onitemdatabound="lvUrunler_ItemDataBound">
                            <EmptyDataTemplate>Seçilen kriterlere uygun ürün yok.<br />
                                <asp:Button ID="btnRestartListview" OnClick="btnRestartListview_Click" runat="server" Text="Geri Dön" />
                            </EmptyDataTemplate>
                                <LayoutTemplate>
                                    <table class="gridview" cellpadding="0" cellspacing="0">
                                        <tr class="header">
                                            <th></th>                                            
                                            <th>Barkod No</th>
                                            <th>
                         <asp:DropDownList ID="ddlKategoriler" DataSourceID="dsKategoriDoldur" AutoPostBack="true"
                            DataValueField="Id" DataTextField="KategoriAdi" runat="server" Width="80px" Font-Size="11px" AppendDataBoundItems="true">
                            <asp:ListItem Text="-Kategoriler-" Value="-1"></asp:ListItem>
                        </asp:DropDownList>
                                            </th>
                                            <th>
                        <asp:DropDownList ID="ddlMarkalar" DataSourceID="dsMarkaDoldur" AutoPostBack="true"
                            DataValueField="Id" DataTextField="MarkaAdi" runat="server" Width="80px" Font-Size="11px" AppendDataBoundItems="true">
                            <asp:ListItem Text="-Markalar-" Value="-1"></asp:ListItem>
                        </asp:DropDownList>
                                            </th>
                                            <th>Model</th>                                            
                                            <th>Birim</th>
                                            <th>    
                        <asp:DropDownList ID="ddlOdalar" DataSourceID="dsOdaDoldur" AutoPostBack="true"
                            DataValueField="Id" DataTextField="OdaAdi" runat="server" Width="80px" Font-Size="11px" AppendDataBoundItems="true">
                            <asp:ListItem Text="-Odalar-" Value="-1"></asp:ListItem>
                        </asp:DropDownList></th>
                                            <th>
                        <asp:DropDownList ID="ddlFakulteler" DataSourceID="dsFakulteDoldur" AutoPostBack="true"
                            DataValueField="Id" DataTextField="FakulteAdi" runat="server" Width="80px" Font-Size="11px" AppendDataBoundItems="true">
                            <asp:ListItem Text="-Fakulteler-" Value="-1"></asp:ListItem>
                        </asp:DropDownList>
                                            </th>
                                            <th>
                        <asp:DropDownList ID="ddlKampusler" DataTextField="KampusAdi" DataSourceID="dsKampusDoldur" AutoPostBack="true"
                            DataValueField="Id" runat="server" Width="80px" Font-Size="11px" AppendDataBoundItems="true">
                            <asp:ListItem Text="-Kampusler-" Value="-1"></asp:ListItem>
                        </asp:DropDownList>
                                            </th>    
                                            <th>Aciklama</th>                                                                                      
                                        </tr>
                                        <tr id="itemPlaceholder" runat="server" />
                                    </table>
                                </LayoutTemplate>
                                <ItemTemplate>
                                    <tr class='<%# Container.DataItemIndex % 2 == 0 ? "row" : "altrow" %>'>                                        
                                        <td class="command"><asp:LinkButton ID="btnEdit" runat="server" Text="Düzenle" CommandName="Edit" /></td>                                                                              
                                        <td><%# Eval("BarkodNo") %></td>                                        
                                        <td><%# Eval("KategoriAdi") ?? "&nbsp;" %></td>
                                        <td><%# Eval("MarkaAdi") ?? "&nbsp;"%></td>
                                        <td><%# Eval("Model") ?? "&nbsp;"%></td>
                                        <td><%# Eval("Birim") ?? "&nbsp;"%></td>                                       
                                        <td><%# Eval("OdaAdi") ?? "&nbsp;"%></td>
                                        <td><%# Eval("FakulteAdi") ?? "&nbsp;"%></td>                                        
                                        <td><%# Eval("KampusAdi") ?? "&nbsp;"%></td> 
                                        <td><%# Eval("Aciklama") ?? "&nbsp;"%></td>                                                                               
                                    </tr>
                                </ItemTemplate>
                                <EditItemTemplate>
                                    <tr class='edit-info <%# Container.DataItemIndex == 0 ? "first" : string.Empty %>'>
                                        <td class="command"><asp:LinkButton ID="btnEdite" runat="server" Text="Düzenle" CommandName="Edit" /></td>
                                        <td><%# Eval("BarkodNo") %></td>
                                        <td><%# Eval("KategoriAdi") ?? "&nbsp;" %></td>
                                        <td><%# Eval("MarkaAdi") ?? "&nbsp;"%></td>
                                        <td><%# Eval("Model") ?? "&nbsp;"%></td>
                                        <td><%# Eval("Birim") ?? "&nbsp;"%></td>                                        
                                        <td><%# Eval("OdaAdi") ?? "&nbsp;"%></td>
                                        <td><%# Eval("FakulteAdi") ?? "&nbsp;"%></td>                                        
                                        <td><%# Eval("KampusAdi") ?? "&nbsp;"%></td> 
                                        <td><%# Eval("Aciklama") ?? "&nbsp;"%></td> 
                                    </tr>            
                                    <tr>
                                        <td class="edit" colspan="10">
                                            <div class="details">
                                                <div class="header">Edit details for '<%# Eval("BarkodNo")%>'</div>
                                                <table class="detailview" cellpadding="0" cellspacing="0">
                                                    <tr>
                                                        <th>Barkod No</th>
                                                        <td><asp:TextBox ID="txtBarkodNo" Width="120px" runat="server" Text='<%# Bind("BarkodNo") %>' />
                                                        
                                                        <asp:TextBox Visible="false" ID="txtId" runat="server" Text='<%# Bind("ID") %>' /></td>  
                                                                                                                                   
                                                        <th>Kategori</th>
                                                        <td><asp:TextBox Visible="false" ID="txtKategori" runat="server" Text='<%# Bind("KategoriAdi") %>' />
                                                        <asp:DropDownList ID="ddlKategorilerEdit" DataSourceID="dsKategoriDoldur" AutoPostBack="true"
                                                             DataValueField="Id" DataTextField="KategoriAdi" runat="server" Width="120px" Font-Size="11px" AppendDataBoundItems="true">                            
                                                        </asp:DropDownList>
                                                        </td>
                                                                                                            
                                                        <th>Birim</th>
                                                        <td><asp:TextBox ID="txtDeger" Width="120px" runat="server" Text='<%# Bind("BirimDeger") %>' /></td>    
                                                                                                           
                                                        <th>Birim</th>
                                                        <td><asp:TextBox Visible="false" ID="txtBirim" Width="120px" runat="server" Text='<%# Bind("BirimAdi") %>' />
                                                        <asp:DropDownList ID="ddlBirimAdiEdit" DataSourceID="dsBirimDoldur" AutoPostBack="true"
                                                            DataValueField="BirimId" DataTextField="BirimAdi" runat="server" Width="120px" Font-Size="11px" AppendDataBoundItems="true">                                                            
                                                        </asp:DropDownList></td>
                                                    </tr>
                                                    <tr>
                                                        <th>Oda No</th>
                                                        <td><asp:TextBox Visible="false" ID="txtOdaNo" runat="server" Text='<%# Bind("OdaAdi") %>' />
                                                        <asp:DropDownList ID="ddlOdalarEdit" DataSourceID="dsOdaDoldur" AutoPostBack="true"
                                                            DataValueField="Id" DataTextField="OdaAdi" runat="server" Width="120px" Font-Size="11px" AppendDataBoundItems="true">                                                            
                                                        </asp:DropDownList></td>                                                                                
                                                    
                                                        <th>Fakulte</th>
                                                        <td><asp:TextBox Visible="false" Width="120px" ID="txtFakulte" runat="server" Text='<%# Bind("FakulteAdi") %>' />
                                                        <asp:DropDownList ID="ddlFakultelerEdit" DataSourceID="dsFakulteDoldur" AutoPostBack="true"
                                                            DataValueField="FakulteAdi" runat="server" Width="120px" Font-Size="11px" AppendDataBoundItems="true">                                                            
                                                        </asp:DropDownList></td>
                                                        
                                                        <th>Kampus</th>
                                                        <td><asp:TextBox Visible="false" ID="txtKampus" runat="server" Text='<%# Bind("KampusAdi") %>' />
                                                        <asp:DropDownList ID="ddlKampuslerEdit" DataSourceID="dsKampusDoldur" AutoPostBack="true"
                                                            DataValueField="KampusAdi" runat="server" Width="120px" Font-Size="11px" AppendDataBoundItems="true">                                                            
                                                        </asp:DropDownList>
                                                        </td>
                                                         <th>Model</th>
                                                        <td><asp:TextBox Width="120px" ID="txtModel" runat="server" Text='<%# Bind("Model") %>' />  
                                                    </tr>      
                                                                                                    
                                                </table><table class="detailview" cellpadding="0" cellspacing="0">
                                                <tr>
                                                    <th>Açıklama  </th>
                                                        <td><asp:TextBox Width="620px" ID="txtAciklama" runat="server" Text='<%# Bind("Aciklama") %>' /> </td>
                                                        
                                                        <th>Marka</th>
                                                        <td><asp:TextBox Visible="false" ID="txtMarka" runat="server" Text='<%# Bind("MarkaAdi") %>' /> 
                                                        <asp:DropDownList ID="ddlMarkalarEdit" DataSourceID="dsMarkaDoldur" AutoPostBack="true"
                                                            DataValueField="Id" DataTextField="MarkaAdi" runat="server" Width="120px" Font-Size="11px" AppendDataBoundItems="true">                                                            
                                                        </asp:DropDownList>                                                       
                                                        </td> 
                                                    </tr> </table>
                                                <div class="footer command">
                                                    <asp:LinkButton ID="btnDelete" OnClick="btnDelete_Click" CommandName="Delete" runat="server" Text="Sil" />
                                                    <asp:LinkButton ID="btnGuncelle" OnClick="btnGuncel_Click" runat="server" Text="Güncelle" />
                                                    <asp:LinkButton ID="btnIptalEt" runat="server" Text="İptal Et" CommandName="Cancel" />
                                                </div>
                                            </div>
                                        </td>
                                    </tr>
                                    
                                </EditItemTemplate>
                            </asp:ListView>                                
                                
            <asp:SqlDataSource ID="dsGridview" runat="server" ConnectionString="<%$ ConnectionStrings:ConnString %>"
                SelectCommand="SELECT dbo.Urunler.ID, dbo.Urunler.KategoriId, dbo.Urunler.MarkaId, dbo.Urunler.OdaId, 
                      dbo.Urunler.FakulteId, dbo.Urunler.KampusId, dbo.Urunler.BarkodNo, dbo.Kategori.KategoriAdi, 
                      dbo.Marka.MarkaAdi,dbo.Urunler.BirimDeger, dbo.Birimler.BirimAdi, dbo.Urunler.Model, (Urunler.BirimDeger +' ' +Birimler.BirimAdi) as Birim, 
                      dbo.Kampus.KampusAdi, dbo.Fakulte.FakulteAdi, dbo.Oda.OdaAdi, dbo.Urunler.Aciklama
                      FROM dbo.Urunler INNER JOIN
                      dbo.Birimler ON dbo.Urunler.BirimId = dbo.Birimler.BirimId INNER JOIN
                      dbo.Fakulte ON dbo.Urunler.FakulteId = dbo.Fakulte.Id INNER JOIN
                      dbo.Kampus ON dbo.Urunler.KampusId = dbo.Kampus.Id AND dbo.Fakulte.KampusId = dbo.Kampus.Id INNER JOIN
                      dbo.Kategori ON dbo.Urunler.KategoriId = dbo.Kategori.Id AND dbo.Birimler.KategoriId = dbo.Kategori.Id INNER JOIN
                      dbo.Marka ON dbo.Urunler.MarkaId = dbo.Marka.Id INNER JOIN
                      dbo.Oda ON dbo.Urunler.OdaId = dbo.Oda.Id AND dbo.Fakulte.Id = dbo.Oda.FakulteId AND dbo.Kampus.Id = dbo.Oda.KampusId"
                       
                                    FilterExpression="(KategoriId = '{0}' or '{0}' = '-1') and (MarkaId = '{1}' or '{1}' = '-1') and (OdaId = '{2}' or '{2}' = '-1') and (FakulteId = '{3}' or '{3}' = '-1') and (KampusId = '{4}' or '{4}' = '-1')" 
                                    onselecting="dsGridview_Selecting">
                <FilterParameters>
                    <asp:ControlParameter Type="Int32" Name="KategoriId" ControlID="lvUrunler$ddlKategoriler" PropertyName="SelectedValue" />
                    <asp:ControlParameter Type="Int32" Name="MarkaId" ControlID="lvUrunler$ddlMarkalar" PropertyName="SelectedValue" /> 
                    <asp:ControlParameter Type="Int32" Name="OdaId" ControlID="lvUrunler$ddlOdalar" PropertyName="SelectedValue" />                   
                    <asp:ControlParameter Type="Int32" Name="FakulteId" ControlID="lvUrunler$ddlFakulteler" PropertyName="SelectedValue" />
                    <asp:ControlParameter Type="Int32" Name="KampusId" ControlID="lvUrunler$ddlKampusler" PropertyName="SelectedValue" />
                </FilterParameters>
            </asp:SqlDataSource>
                <asp:SqlDataSource ID="dsKategoriDoldur" runat="server" ConnectionString="<%$ ConnectionStrings:ConnString %>"
                    SelectCommand="SELECT DISTINCT Id,KategoriAdi from [Kategori]"></asp:SqlDataSource>
                <asp:SqlDataSource ID="dsMarkaDoldur" runat="server" ConnectionString="<%$ ConnectionStrings:ConnString %>"
                    SelectCommand="SELECT DISTINCT Id,MarkaAdi FROM [Marka]"></asp:SqlDataSource>
                <asp:SqlDataSource ID="dsFakulteDoldur" runat="server" ConnectionString="<%$ ConnectionStrings:ConnString %>"
                    SelectCommand="SELECT DISTINCT Id,FakulteAdi from [Fakulte]"></asp:SqlDataSource>
                <asp:SqlDataSource ID="dsKampusDoldur" runat="server" ConnectionString="<%$ ConnectionStrings:ConnString %>"
                    SelectCommand="SELECT DISTINCT Id,KampusAdi from [Kampus]"></asp:SqlDataSource>
                <asp:SqlDataSource ID="dsOdaDoldur" runat="server" ConnectionString="<%$ ConnectionStrings:ConnString %>"
                    SelectCommand="SELECT DISTINCT Id,OdaAdi from [Oda]"></asp:SqlDataSource>
                <asp:SqlDataSource ID="dsBirimDoldur" runat="server" ConnectionString="<%$ ConnectionStrings:ConnString %>"
                    SelectCommand="SELECT DISTINCT BirimId,BirimAdi from [Birimler]"></asp:SqlDataSource>
                                
                        </ContentTemplate>
                    </asp:UpdatePanel>                    
                </div></div></div>
            <div class="bottom-outer"><div class="bottom-inner"><div class="bottom"></div></div></div>     
        </div>
        </div>
        
    </form>    
</body>
</html>

