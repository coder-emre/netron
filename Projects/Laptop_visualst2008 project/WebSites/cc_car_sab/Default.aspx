<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
         $<input type="text" id="txtKur" runat="server" />
         <input type="submit" id="btnCevir" value="Cevir" runat="server" onserverclick="btnClick"  />
       
         <%--saşlkdjf aşslkfj  --%>
        <div id="dvResult" style="width: 683px; height: 43px; font-weight: bold; font-size: 15pt; color: blue; font-family: Cambria;" runat="server">
        </div>
        <select id="kurlar" runat="server"></select>
    
    </div>
    </form>
</body>
</html>
