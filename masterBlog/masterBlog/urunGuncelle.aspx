<%@ Page Title="" Language="C#" MasterPageFile="~/masterAdmin.Master" AutoEventWireup="true" CodeBehind="urunGuncelle.aspx.cs" Inherits="masterYonetim.urunGuncelle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style3" style="text-align: center; font-family: 'trajan Pro';">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2" style="text-align: center;">Blog Başlık</td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server" Width="400px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2" style="text-align: center;">blog içerik</td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server" Height="66px" TextMode="MultiLine" Width="400px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2" style="text-align: center;">blog özet</td>
            <td>
                <asp:TextBox ID="TextBox3" runat="server" Height="66px" TextMode="MultiLine" Width="400px"></asp:TextBox>
                </td>
        </tr>
        <tr>
            <td class="auto-style2" style="text-align: center;">blog resim</td>
            <td>
                <asp:FileUpload ID="FileUpload1" runat="server" Width="400px" />
            </td>
        </tr>
        <tr>
            <td class="auto-style2" style="text-align: center;">&nbsp;</td>
            <td>
                <asp:Button ID="Button1" runat="server" Text="Güncelle" OnClick="Button1_Click" />
            </td>
        </tr>
        <tr>
            <td class="auto-style2" style="text-align: center;">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
