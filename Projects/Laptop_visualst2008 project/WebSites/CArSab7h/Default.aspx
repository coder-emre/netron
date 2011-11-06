<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
   <asp:Button ID="btnGonder" runat="server" Text="GOnder" />
  <asp:TextBox ID="txtAD" runat="server"></asp:TextBox>
        <br />
<a href="Default.aspx?Theme=Green"> YEŞİL</a>
<a href="Default.aspx?Theme=Red"> RED </a>

<hr />
<asp:Button ID="btnARTTIR" runat="server" Text="Arttır" OnClick="btnARTTIR_Click" />
<asp:Label ID="lblSonuc" runat="server"></asp:Label>
<hr />
 <asp:TextBox id="txtName" runat="server" ></asp:TextBox>
<asp:TextBox id="txtSoyad" runat="server" ></asp:TextBox>
<asp:Button ID="btnSubmit" runat="server" Text="NEsneyi gönder" OnClick="btnSubmit_Click" />
        <br />
        <asp:Label ID="lblMusteri" runat="server"></asp:Label>
        <br />
        <hr />
        <asp:Button ID="btnSession" runat="server" text="sesiona gönder"  OnClick="btnSession_Click"/>
    </div>
    </form>
</body>
</html>
