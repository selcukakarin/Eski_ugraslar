<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.Master" AutoEventWireup="true" CodeBehind="duyuruguncelle.aspx.cs" Inherits="siteBlog.admin.duyuruguncelle" %>
<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 231px;
            height: 21px;
        }
        .auto-style3 {
            height: 21px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style1" style="background-color: #669999">
        <tr>
            <td class="auto-style2" style="text-align: right"></td>
            <td class="auto-style3"></td>
        </tr>
        <tr>
            <td class="auto-style2" style="text-align: right">Başlık:</td>
            <td class="auto-style3">
                <asp:TextBox ID="txt_duyuruBaslik" runat="server" CssClass="textboxGorsel" Width="400px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2" style="text-align: right">İçerik:</td>
            <td class="auto-style3"><CKEditor:CKEditorControl ID="txt_DuyuruIcerik" BasePath="/ckeditor/" runat="server" Width="400px"></CKEditor:CKEditorControl></td>
        </tr>
        <tr>
            <td class="auto-style2" style="text-align: right">&nbsp;</td>
            <td class="auto-style3">
                <asp:Button ID="btn_guncelle" runat="server" CssClass="butonGorsel" Text="Guncelle" OnClick="btn_guncelle_Click" />
            </td>
        </tr>
        <tr>
            <td class="auto-style2" style="text-align: right">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
    </table>
</asp:Content>
