<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="anaGiris.aspx.cs" Inherits="masterBlog.anaGiris" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="text-align:center; background:#333; height:80px; line-height:80px;">
        <asp:Button ID="Button1" runat="server" Text="Kullanıcı Girişi" OnClick="Button1_Click" />
        </div>
    <div style="text-align:center; background:#777; height:80px; line-height:80px;">
        <asp:Button ID="Button2" runat="server" Text="Admin Girişi" OnClick="Button2_Click" />
    </div>
    </form>
</body>
</html>
