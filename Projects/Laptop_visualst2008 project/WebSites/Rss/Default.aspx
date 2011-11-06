<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<%@ Register assembly="RssToolkit" namespace="RssToolkit.Web.WebControls" tagprefix="cc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 100%;
            border: 1px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="style1">
            <tr>
                <td>
                    <asp:DataList ID="DataList1" runat="server" DataSourceID="RssDataSource1">
                        <ItemTemplate>
                            description:
                            <asp:Label ID="descriptionLabel" runat="server" 
                                Text='<%# Eval("description") %>' />
                            <br />
                            guid:
                            <asp:Label ID="guidLabel" runat="server" Text='<%# Eval("guid") %>' />
                            <br />
                            link:
                            <asp:Label ID="linkLabel" runat="server" Text='<%# Eval("link") %>' />
                            <br />
                            pubDate:
                            <asp:Label ID="pubDateLabel" runat="server" Text='<%# Eval("pubDate") %>' />
                            <br />
                            pubDateParsed:
                            <asp:Label ID="pubDateParsedLabel" runat="server" 
                                Text='<%# Eval("pubDateParsed") %>' />
                            <br />
                            title:
                            <asp:Label ID="titleLabel" runat="server" Text='<%# Eval("title") %>' />
                            <br />
                            <br />
                        </ItemTemplate>
                    </asp:DataList>
                </td>
            </tr>
            <tr>
                <td>
                    <cc1:RssDataSource ID="RssDataSource1" runat="server" MaxItems="0" 
                        Url="http://www.cnnturk.com/servisler/rss/anasayfa.rss">
                    </cc1:RssDataSource>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
