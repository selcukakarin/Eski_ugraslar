<%@ Page Title="" Language="C#" MasterPageFile="~/masterSayfa.Master" AutoEventWireup="true" CodeBehind="kullaniciKaydol.aspx.cs" Inherits="masterBlog.kullaniciKaydol" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style1 {
        width: 100%;
        height: 352px;
    }
    .auto-style2 {
        width: 390px;
    }
    .auto-style3 {
        margin-bottom: 34;
    }
    .auto-style4 {
        margin-bottom: 24;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="sari">
        <div class="sari-container">

            <table class="auto-style1">
                <tr>
                    <td class="auto-style2" style="text-align: right">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2" style="text-align: right">&nbsp;</td>
                    <td>Kullanıcı Kayıt Paneli</td>
                </tr>
                <tr>
                    <td class="auto-style2" style="text-align: right">Email =</td>
                    <td>
                        <asp:TextBox ID="TextBox6" runat="server" CssClass="auto-style4" Height="22px" Width="328px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2" style="text-align: right">Şifre =</td>
                    <td>
                        <asp:TextBox ID="TextBox7" runat="server" CssClass="auto-style3" Height="22px" Width="328px" TextMode="Password"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2" style="text-align: right">&nbsp;</td>
                    <td>
                        <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Kayıt!" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2" style="text-align: right">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>

        </div>
    </div>
</asp:Content>
