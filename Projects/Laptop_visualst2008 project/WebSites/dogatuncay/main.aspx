<%@ Page Language="C#" AutoEventWireup="true" CodeFile="main.aspx.cs" Inherits="main" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 100%;
            height: 509px;
        }
        .style2
        {
            width: 258px;
        }
        .style3
        {
            width: 247px;
        }
        .style8
        {
            height: 29px;
        }
        .style9
        {
            height: 30px;
        }
    </style>
</head>
<body bgcolor="#000000">
    <form id="form1" runat="server">
    <script runat="Server" type="text/C#">

        [System.Web.Services.WebMethod]
        [System.Web.Script.Services.ScriptMethod]
        public static AjaxControlToolkit.Slide[] GetSlides()
        {
            return new AjaxControlToolkit.Slide[] { 
            
            new AjaxControlToolkit.Slide("my slides/1.jpg", "", ""),
            new AjaxControlToolkit.Slide("my slides/2", "", ""),
            new AjaxControlToolkit.Slide("my slides/3.jpg", "", ""),
            new AjaxControlToolkit.Slide("my slides/4.jpg", "", "")
           
        };
        
        }
    </script>
    <div id="btn_danger">
                <table class="style1">
                    <tr>
                        <td class="style2">
                <asp:ImageButton ID="btn_menu" runat="server" ImageUrl="~/images/btn_menu.bmp" />
                  <br /> 
                <asp:ImageButton ID="btn_information" runat="server" 
                    ImageUrl="~/images/btn_information.bmp" onclick="btn_information_Click" />
                  <br />  
                <asp:ImageButton ID="btn_portfolio" runat="server" 
                    ImageUrl="~/images/btn_portfolio.bmp" onclick="btn_portfolio_Click" />
                  <br /> 
                <asp:ImageButton ID="btn_archives" runat="server" 
                    ImageUrl="~/images/btn_archives.bmp" onclick="btn_archives_Click"  />
                  <br /> 
                <asp:ImageButton ID="btn_blog" runat="server" ImageUrl="~/images/btn_blog.bmp" 
                    onclick="btn_blog_Click" />
                  <br /> 
                <asp:ImageButton ID="btn_contact" runat="server" 
                    ImageUrl="~/images/btn_contact.bmp" onclick="btn_contact_Click" />
                            <br />
                            <asp:ImageButton ID="btn_danger0" runat="server" 
                                ImageUrl="~/images/dangerr.jpg" onclick="btn_danger_Click" />
                        </td>
                        <td class="style3">
                            <asp:Image ID="Image1" runat="server" Height="344px" Width="238px" 
                                ImageAlign="AbsMiddle" ImageUrl="~/myslides/1.JPG" />
                            <br />
                            <asp:Label ID="Label1" runat="server" Font-Bold="True" ForeColor="White" 
                                Text="              Welcome to my website..."></asp:Label>
                            <br />
                            <br />
                            
 <script type="text/javascript" src="media/swfobject.js"></script>
		
<div id="flashPlayer">
  This text will be replaced by the flash music player.
</div>

<script type="text/javascript">
   var so = new SWFObject("media/playerMini.swf", "mymovie", "75", "30", "7", "#CC0000");
   so.addVariable("autoPlay", "no");
   so.addVariable("soundPath", "media/somersault.mp3");
   so.write("flashPlayer");
</script>
                        </td>
                        <td>
                            &nbsp;</td>
                    </tr>
                </table>
    </div>
    </form>
</body>
</html>
