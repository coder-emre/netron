<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style4
        {
            height: 333px;
            width: 359px;
        }
        #form1
        {
            height: 416px;
        }
        .style5
        {
            width: 674px;
        }
    </style>
</head>
<body bgcolor="Black">
    <form id="form1" runat="server">
    <div>
    
        <table>
            <tr>
                <td class="style5">
                    &nbsp;</td>
                <td>
                  <img alt="" src="images/dangerl.jpg" style="width: 250px; height: 286px" /><br /><br />
                    <asp:Panel ID="Panel1" runat="server" BackColor="Black" Height="144px" 
                        Width="343px">
                    <asp:LoginView 
                            ID="LoginView1" runat="server">
                            <LoggedInTemplate>
                                Welcome
                                <asp:LoginName ID="LoginName1" runat="server" />
                                <br />
                                <asp:LoginStatus ID="LoginStatus3" runat="server" />
                            </LoggedInTemplate>
                            <AnonymousTemplate>
                                <b style="color: #FFFFFF">Welcome to my Personal Page.. To login..</b>.<br />
                                <asp:LoginStatus ID="LoginStatus2" runat="server" Font-Bold="True" />
                            </AnonymousTemplate>
                        </asp:LoginView>
                    </asp:Panel>
                </td>
                <td class="style4">
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
