<%@ Page Title="" Language="C#" MasterPageFile="~/kullanici.Master" AutoEventWireup="true" CodeBehind="iletisim.aspx.cs" Inherits="siteBlog.iletisim" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style6 {
            width: 25px;
        }
        .auto-style7 {
            width: 24px;
            height: 24px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="height:auto;width:100%;float:left;">
        <table class="auto-style1" style="color: #808080">
            <tr>
                <td class="auto-style6">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style6">
                    <img alt="" class="auto-style7" src="tema/face.png" /></td>
                <td>&nbsp;facebook/selcukakarin&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style6">
                    <img alt="" class="auto-style7" src="tema/twitter.png" /></td>
                <td>&nbsp;twitter/selcukakarin&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style6">
                    <img alt="" class="auto-style7" src="tema/youtube.png" /></td>
                <td>&nbsp; youtube/selcukakarin</td>
            </tr>
            <tr>
                <td class="auto-style6">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </div>
    <div style="height:40px;width:100%;float:left; color: #666666; font-weight: bold;">

    &nbsp;&nbsp;Bana alttaki panelden mesaj gönderebilirsiniz</div>

    <div style="height: 200px; width: 100%; float: left;">
        <div style="border: 1px dotted #2a595c; width: 330px; height: 200px; float: left; margin-left:5px; ">
            <asp:TextBox ID="txt_yorumIcerik" placeHolder="Buraya Mesajınızı Yazınız" runat="server" Height="200px" TextMode="MultiLine" Width="330px"></asp:TextBox>
        </div>
        <div style="border: 1px dotted #2a595c; float: right; width: 330px; height: 200px;margin-right:5px;">

            <table class="auto-style1">
                <tr>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td style="text-align: center">
                        <asp:TextBox ID="txt_AdSoyad" runat="server" placeHolder="Ad Soyad" CssClass="textboxGorsel" Width="300px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="text-align: center">
                        <asp:TextBox ID="txt_Email" runat="server" placeHolder="Email" CssClass="textboxGorsel" Width="300px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="text-align: center">
                        <asp:Button ID="btn_YorumEkle" runat="server" CssClass="butonGorsel" Text="Gönder" OnClick="btn_YorumEkle_Click"  />
                    </td>
                </tr>
                <tr>
                    <td style="text-align: center">
                        <asp:Label ID="lbl_bilgi" runat="server" ForeColor="Red"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td style="text-align: center">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txt_YorumIcerik" ErrorMessage="RequiredFieldValidator" ForeColor="Red">Yorum Yazınız</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td style="text-align: center">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txt_AdSoyad" ErrorMessage="RequiredFieldValidator" ForeColor="Red">Adınız Soyadınız</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td style="text-align: center">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txt_Email" ErrorMessage="RequiredFieldValidator" ForeColor="Red">Emailiniz</asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txt_Email" ErrorMessage="RegularExpressionValidator" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">Hatalı Mail</asp:RegularExpressionValidator>
                    </td>
                </tr>
            </table>

        </div>
        <div style="height: 10px; width: 100%; float:left;">
</asp:Content>
