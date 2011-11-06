<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MasterpageEklemek.aspx.cs" Inherits="MasterpageEklemek" MasterPageFile="~/CarMaster.master" %>


<asp:Content ID="cont" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" >

 <div>
        <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
        <asp:LinkButton ID="LinkButton1" runat="server">LinkButton</asp:LinkButton>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:HyperLink ID="HyperLink1" runat="server">HyperLink</asp:HyperLink>
        <asp:DropDownList ID="DropDownList1" runat="server">
        </asp:DropDownList></div>
 

</asp:Content>