<%@ Page Language="C#" AutoEventWireup="true"  
MasterPageFile="~/CarMaster.master"
Title=" Ana SAYFA "
CodeFile="Default.aspx.cs" Inherits="_Default" StylesheetTheme="Deneme" %>

<asp:Content ID="cnt" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div>
    <table> 
    <tr> <td>ADINIZ</td><td><asp:TextBox ID="txtAd" runat="server" SkinID="txt2"></asp:TextBox> </td><td>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtAd"
            ErrorMessage="Ad Alanı Boş Geçilemez">*</asp:RequiredFieldValidator></td></tr>
     <tr> <td>SOYADINIZ</td><td><asp:TextBox ID="txtSoyad" runat="server"></asp:TextBox> </td><td>
         <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtSoyad"
             ErrorMessage="Soyad Alanı Boş Geçilemez">*</asp:RequiredFieldValidator></td></tr>
      <tr> <td>Kullanici Adi</td><td><asp:TextBox ID="txtKullanici" runat="server" BackColor="#FF8080" BorderStyle="Groove" ForeColor="#C0C000"></asp:TextBox> </td><td>
          <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtKullanici"
              ErrorMessage="Kullanıcı ADI boş Geçilemz">*</asp:RequiredFieldValidator><br />
          <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtKullanici"
              ErrorMessage=" 8 karakterden az olamaz" ValidationExpression="\w{8,15}">*</asp:RegularExpressionValidator></td></tr>
       <tr> <td>Şifre</td><td><asp:TextBox ID="txtSifre" runat="server"></asp:TextBox> </td><td>
           <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtSifreTekrar"
               ControlToValidate="txtSifre" ErrorMessage="Girilen Şifre Aynı Olmalı ">*</asp:CompareValidator></td></tr>
       <tr> <td>Şifre Tekrar</td><td><asp:TextBox ID="txtSifreTekrar" runat="server"></asp:TextBox> </td><td>
           <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtSifreTekrar"
               ErrorMessage="Şifre Tekrar Alanı Boş Geçilemez">*</asp:RequiredFieldValidator></td></tr>
    <tr> <td>1-100 arası rakam</td><td><asp:TextBox ID="txtGizliSayi" runat="server"></asp:TextBox> </td><td>
        <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtGizliSayi"
            ErrorMessage="1-100  arası bir tam sayı giriniz" MaximumValue="100" MinimumValue="1"
            Type="Integer">*</asp:RangeValidator></td></tr>
     <tr> <td>Email </td><td><asp:TextBox ID="txtEmail" runat="server"></asp:TextBox> </td><td>
         <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtEmail"
             ErrorMessage="Email Formatı Uygun Değil" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator></td></tr>
      <tr> <td colspan="3" align="center"><asp:Button ID="btnGonder" Text="Gonder" runat="server" /> </td></tr>
      <tr> <td colspan="3" align="center"> 
          <asp:ValidationSummary ID="ValidationSummary1" runat="server" ShowMessageBox="True" />
      </td></tr>
        <tr>
            <td align="center" colspan="3">
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/default.aspx?skin=kirmizi">Kızmızı</asp:HyperLink>
                <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/default.aspx?skin=yesil">YEŞİL</asp:HyperLink></td>
        </tr>
      
    </table>
    
    </div>

</asp:Content>
