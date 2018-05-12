<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminLogin.aspx.cs" Inherits="deneme.AdminLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head>

    <meta charset="UTF-8">

    <title>CodePen - Login </title>
    <link href="css/mystyle.css" rel="stylesheet" />
    <link href="css/reset.css" rel="stylesheet" />
    <link href="css/loginstyle.css" rel="stylesheet" />
</head>

<body>
    <form id="form1" runat="server">
        <div>
            <div class="wrap">
                <div class="avatar">
                    <img>
                </div>
                <input type="text" name="txtuser" id="txtuser" placeholder="username" required runat="server">
                <div class="bar">
                    <i></i>
                </div>
                <input type="password" name="userpass" id="txtpass" placeholder="password" required runat="server">
                <a href="" class="forgot_link">forgot ?</a>
                <asp:Button ID="button" CssClass="button" runat="server" Text="Log In" OnClick="loginBtn_Click" />
            </div>

            <script src="js/index.js"></script>
        </div>
    </form>
</body>

</html>

