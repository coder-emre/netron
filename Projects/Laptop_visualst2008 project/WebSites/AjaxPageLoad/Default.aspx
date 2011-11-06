<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    
<script runat="Server" type="text/C#">

        [System.Web.Services.WebMethod]
        [System.Web.Script.Services.ScriptMethod]
        public static AjaxControlToolkit.Slide[] GetSlides()
        {
            return new AjaxControlToolkit.Slide[] { 
            new AjaxControlToolkit.Slide("images/DSC08729.JPG", "Resim 1",             "Resim 1"),
            new AjaxControlToolkit.Slide("images/DSC08730.JPG",      "Resim 2", "Resim 2"),
            new AjaxControlToolkit.Slide("images/DSC08731.JPG", "Resim 3", "Resim 3"),
        };
        
        }
    </script>

    <div>
        <br />
        <asp:Image ID="Image1" runat="server" Height="233px" Width="277px" />
        <cc1:SlideShowExtender ID="Image1_SlideShowExtender" runat="server" 
            AutoPlay="True" ImageDescriptionLabelID="lbl1" Loop="True" 
            NextButtonID="Button3" PlayButtonID="Button2" PlayButtonText="oyna" 
            PreviousButtonID="Button1" SlideShowServiceMethod="GetSlides" 
            StopButtonText="Dur" TargetControlID="Image1" UseContextKey="True">
        </cc1:SlideShowExtender>
        <br />
        <br />
        <asp:Label ID="lbl1" runat="server" Text="Label"></asp:Label>
        <br />
        <asp:Button ID="Button1" runat="server" Text="geri" />
        <asp:Button ID="Button2" runat="server" Text="oyna" />
        <asp:Button ID="Button3" runat="server" Text="ileri" />
        <br />
        <br />
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
    </div>
    </form>
    
</body>
</html>
