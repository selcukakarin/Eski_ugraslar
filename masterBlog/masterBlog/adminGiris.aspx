<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="adminGiris.aspx.cs" Inherits="masterBlog.adminGiris" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div style="margin: auto; text-align: center; background: #999; color: white; margin-top: 2px;">
                <asp:Label ID="lbl_giris" runat="server" Text="Yönetici Giriş"></asp:Label>
            </div>
            <div style="margin: auto; text-align: center; background: #777; color: white; margin-top: 2px;">
                Kullanıcı&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </div>
            <div style="margin: auto; text-align: center; background: #555; color: white; margin-top: 2px;">
                Şifre&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
            </div>
            <div style="margin: auto; text-align: center; background: #333; color: white; margin-top: 2px;">
                <asp:Button ID="btn_giris" runat="server" Text="Giriş" OnClick="btn_giris_Click" />
                <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
            </div>
        </div>
    </form>
</body>
</html>
