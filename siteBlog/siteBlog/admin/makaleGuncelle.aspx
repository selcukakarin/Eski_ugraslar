<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.Master" AutoEventWireup="true" CodeBehind="makaleGuncelle.aspx.cs" Inherits="siteBlog.admin.makaleGuncelle" %>
<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 147px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style1" style="background-color: #669999">
        <tr>
            <td class="auto-style2" style="text-align: right; background-color: #669999">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2" style="text-align: right; background-color: #669999">Başlık:</td>
            <td>
                <asp:TextBox ID="txt_MBaslik" runat="server" CssClass="textboxGorsel" Width="471px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2" style="text-align: right; background-color: #669999">Özet:</td>
            <td>
                <asp:TextBox ID="txt_MOzet" runat="server" CssClass="textboxGorsel" Height="100px" TextMode="MultiLine" Width="471px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2" style="text-align: right; background-color: #669999">İçerik:</td>
            <td><CKEditor:CKEditorControl ID="txt_ckmguncelle" BasePath="/ckeditor/" runat="server" Width="471px"></CKEditor:CKEditorControl></td>
        </tr>
        <tr>
            <td class="auto-style2" style="text-align: right; background-color: #669999">Slider:</td>
            <td>
                <asp:FileUpload ID="fu_slider" runat="server" CssClass="textboxGorsel" Width="471px" />
            </td>
        </tr>
        <tr>
            <td class="auto-style2" style="text-align: right; background-color: #669999">YorumSayısı:</td>
            <td>
                <asp:TextBox ID="txt_YorumSay" runat="server" CssClass="textboxGorsel" Width="471px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2" style="text-align: right; background-color: #669999">&nbsp;</td>
            <td>
                <asp:Button ID="btn_Guncelle" runat="server" CssClass="butonGorsel" Text="Güncelle" OnClick="btn_Guncelle_Click" />
            </td>
        </tr>
        <tr>
            <td class="auto-style2" style="text-align: right; background-color: #669999">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
