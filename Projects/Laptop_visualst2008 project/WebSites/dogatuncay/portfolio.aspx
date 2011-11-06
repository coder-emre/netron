<%@ Page Language="C#" AutoEventWireup="true" CodeFile="portfolio.aspx.cs" Inherits="portfolio" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style2
        {
            width: 235px;
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
            
            new AjaxControlToolkit.Slide("slides/2.jpg", "Dimcayi Alanya, Antalya", "Dimcayi Alanya, Antalya"),
            new AjaxControlToolkit.Slide("slides/4", "Dimcayi Alanya, Antalya", "Dimcayi Alanya, Antalya"),
            new AjaxControlToolkit.Slide("slides/5.jpg", "Canakkale", "Canakkale"),
            new AjaxControlToolkit.Slide("slides/7.jpg", "Canakkale", "Canakkale"),
            new AjaxControlToolkit.Slide("slides/8.jpg", "Canakkale", "Canakkale"),
            new AjaxControlToolkit.Slide("slides/10.jpg", "Canakkale", "Canakkale"),
            new AjaxControlToolkit.Slide("slides/12.jpg", "Canakkale", "Canakkale")
           
        };
        
        }
    </script>
    <div>
     <table>
        <tr>
            <td class="style2">
                
<asp:ImageButton ID="btn_menu" runat="server" ImageUrl="~/images/btn_menu.bmp" 
            onclick="btn_menu_Click" />
                  <br /> 
                <asp:ImageButton ID="btn_information" runat="server" 
                    ImageUrl="~/images/btn_information.bmp" onclick="btn_information_Click" />
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
                    <asp:ImageButton ID="btn_danger" runat="server" ImageUrl="~/images/dangerr.jpg" 
                    onclick="btn_danger_Click" />
              </td>
            <td>
                    

                <br />
                <br />
                <br />
                <br />
               
                <asp:Label ID="Label2" runat="server" Text="My Photos"></asp:Label>
                <asp:Image ID="Image1" runat="server" Height="300px" Width="400px" />
                <cc1:SlideShowExtender ID="Image1_SlideShowExtender" runat="server" 
                    AutoPlay="True" Enabled="True" ImageDescriptionLabelID="Label1" Loop="True" 
                    NextButtonID="Button3" PlayButtonID="Button2" PlayButtonText="Play" 
                    PreviousButtonID="Button1" StopButtonText="Stop" TargetControlID="Image1" 
                    UseContextKey="True" SlideShowServiceMethod="GetSlides">
                </cc1:SlideShowExtender>
                <br /><br />
                <asp:Label ID="Label1" runat="server" Text="Label" ForeColor="White"></asp:Label>
                <br />
                <br />
                <asp:Button ID="Button1" runat="server" Text="Previous" BackColor="Black" 
                    BorderColor="#CC0000" Font-Bold="True" ForeColor="White" /> 
                <asp:Button ID="Button2" runat="server" Text="Play" BackColor="Black" 
                    BorderColor="#CC0000" Font-Bold="True" ForeColor="White" />
                <asp:Button ID="Button3" runat="server" Text="Next" BackColor="Black" 
                    BorderColor="#CC0000" Font-Bold="True" ForeColor="White" />
                <asp:ScriptManager ID="ScriptManager1" runat="server">
                </asp:ScriptManager>
                <br />
                <asp:Label ID="Label3" runat="server" Text="Do you want to see more? Here is a link to my photos..." ForeColor="White"></asp:Label><br />
                <asp:LinkButton ID="LinkButton1" runat="server">http://demonic-jester.deviantart.com/</asp:LinkButton>
                
              </td>
           
        </tr>
            <tr>
              <td>
                
              </td>
         <td>
                 <br />
                <object width="400" height="300">
                <param name="allowfullscreen" value="true" />
                <param name="allowscriptaccess" value="always" />
                <param name="movie" value="http://vimeo.com/moogaloop.swf?clip_id=5784875&amp;server=vimeo.com&amp;show_title=1&amp;show_byline=1&amp;show_portrait=0&amp;color=&amp;fullscreen=1" />
                <embed src="http://vimeo.com/moogaloop.swf?clip_id=5784875&amp;server=vimeo.com&amp;show_title=1&amp;show_byline=1&amp;show_portrait=0&amp;color=&amp;fullscreen=1" type="application/x-shockwave-flash" allowfullscreen="true" 
                allowscriptaccess="always" width="400" height="300">
                </embed>
                </object>
                <p><a href="http://vimeo.com/5784875">Membership Provider - 3</a> from <a href="http://vimeo.com/user2067988">Fatih Durgut</a> on
                 <a href="http://vimeo.com">Vimeo</a>.</p>
    
</td>
           
        </tr>
        <tr>
            <td>
                
            </td>
            <td>
               <object width="400" height="300">
               <param name="allowfullscreen" value="true" />
               <param name="allowscriptaccess" value="always" />
               <param name="movie" value="http://vimeo.com/moogaloop.swf?clip_id=5784302&amp;server=vimeo.com&amp;show_title=1&amp;show_byline=1&amp;show_portrait=0&amp;color=&amp;fullscreen=1" />
               <embed src="http://vimeo.com/moogaloop.swf?clip_id=5784302&amp;server=vimeo.com&amp;show_title=1&amp;show_byline=1&amp;show_portrait=0&amp;color=&amp;fullscreen=1" type="application/x-shockwave-flash" allowfullscreen="true" allowscriptaccess="always" width="400" height="300">
               </embed>
               </object>
               <p><a href="http://vimeo.com/5784302">Membership Provider - 2</a> from <a href="http://vimeo.com/user2067988">Fatih Durgut</a> on <a href="http://vimeo.com">Vimeo</a>.</p>
               
            </td>
           
        </tr>
        <tr>
            <td>
                
                &nbsp;</td>
            <td>
                
           
        </tr>
    </table>
    </div>
    </form>
</body>
</html>
