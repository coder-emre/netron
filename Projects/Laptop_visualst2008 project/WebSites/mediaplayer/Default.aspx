<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
<object id="VIDEO" width="320" height="240" 

    style="position:absolute; left:0;top:0;"

    classid="CLSID:6BF52A52-394A-11d3-B153-00C04F79FAA6"

    type="application/x-oleobject">

        <param name="URL" value="your file or url"/>

    <param name="SendPlayStateChangeEvents" value="False"/>

    <param name="AutoStart" value="True"/>

    <param name="uiMode" value="none"/>

    <param name="PlayCount" value="9999"/>

    <param name="Volume" value="9999"/>

</object>

<object id="VIDEO" width="320" height="240" 

    style="position:absolute; left:0;top:0;"

    classid="CLSID:22D6F312-B0F6-11D0-94AB-0080C74C7E95"

    type="application/x-oleobject">

        <param name="URL" value="my url"/>

    <param name="SendPlayStateChangeEvents" value="False"/>

    <param name="AutoStart" value="True"/>

    <param name="uiMode" value="none"/>

    <param name="PlayCount" value="9999"/>

    <param name="Volume" value="9999"/>
    
 <%--   to programattically set the URL of the video, you must build the object
  tag in the code behind of the web page using a "new HtmlGenericControl("object")
  . Once you instantiate the HtmlGenericControl object, you can set the ID,
   and then add attributes for the classid, width, height, etc.
   Parameters can be added using the innerHTML property.
    And finally, add the HtmlGenericControl to the collection of controls on 
    the page (this.Controls.Add(myHtmlGenericControl))--%>

</object>

  
    </div>
    </form>
</body>
</html>
