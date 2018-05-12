<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="siteBlog.admin._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        *{
            margin:0;
            padding:0;
            border:0;
        }
    </style>
</head>
<body style="background-color:#e1e1e1">
    <form id="form1" runat="server">
    <div style="height:50px; background-color:#2a595c;">
        <div style="float:left; width:350px; margin-top:20px; color:#fff;">Kullanıcı Adı: <asp:TextBox ID="txt_kullanici" runat="server" Height="25px"></asp:TextBox></div>
        <div style="float:left; width:250px; margin-top:20px; color:#fff;">Şifre: <asp:TextBox ID="txt_sifre" runat="server" Height="25px" TextMode="Password"></asp:TextBox></div>
        <div style="float:left; width:100px;color:#fff; margin-top:20px;">
            <asp:Button ID="btn_giris" runat="server" Text="Giriş" Height="25px" Width="80px" BackColor="White"  ForeColor="#2a595c" OnClick="btn_giris_Click"/></div>
    
        <div style="float:right; width:300px; margin-top:20px; text-align:right;">
            <asp:Label ID="lbl_bilgi" runat="server" Text="Yönetici Paneli" ForeColor="White"></asp:Label>
        </div>
        </div>
    </form>
</body>
</html>
