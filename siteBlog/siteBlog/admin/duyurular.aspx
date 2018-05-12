<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.Master" AutoEventWireup="true" CodeBehind="duyurular.aspx.cs" Inherits="siteBlog.admin.duyurular" %>
<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 175px;
        }
        .auto-style3 {
            width: 474px;
            height: 21px;
        }
        .auto-style4 {
            width: 81px;
            height: 21px;
        }
        .auto-style5 {
            height: 21px;
        }
        .auto-style6 {
            width: 41px;
            height: 40px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div>
        <div style="height:25px; background-color:#2a595a; color:#fff; font-weight:bolder;">&nbsp;
            <asp:Button ID="btn_deArti" runat="server" Height="25px"  Text="+" Width="25px" OnClick="btn_deArti_Click" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btn_deEksi" runat="server" Height="25px"  Text="-" Width="25px" OnClick="btn_deEksi_Click" />
&nbsp;&nbsp; Duyuru Ekleme Paneli</div>
    </div>
    <asp:Panel ID="pnl_duyuruEkle" runat="server" BackColor="#669999" ForeColor="White">
        <table class="auto-style1">
            <tr>
                <td class="auto-style2" style="text-align: right">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2" style="text-align: right">Başlık:</td>
                <td>
                    <asp:TextBox ID="txt_DuyuruBaslik" runat="server" CssClass="textboxGorsel" Width="420px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2" style="text-align: right">İçerik:</td>
                <td><CKEditor:CKEditorControl ID="ckeditor" BasePath="/ckeditor/" runat="server" Width="419px"></CKEditor:CKEditorControl></td>
            </tr>
            <tr>
                <td class="auto-style2" style="text-align: right">&nbsp;</td>
                <td>
                    <asp:Button ID="btn_duyuruEkle" runat="server" Text="Ekle" CssClass="butonGorsel" OnClick="btn_duyuruEkle_Click" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2" style="text-align: right">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
        </asp:Panel>
    <div style="height:30px;"></div>

    <div style="height:25px;  background-color:#2a595a; color:#fff; font-weight:bolder;">&nbsp;<asp:Button ID="btn_DuyDuzArti" runat="server" Text="+" Height="25px" Width="25px" />
     &nbsp;&nbsp;&nbsp;
        <asp:Button ID="btn_DuyDuzEksi" runat="server" Height="25px" Text="-" Width="25px" />
&nbsp;&nbsp; Duyuru Düzenleme Paneli</div>
    <asp:Panel ID="pnl_DuyuruDuzenle" BackColor="#669999" runat="server">
        <asp:DataList ID="datalist_dgetir" runat="server" Width="700px" ForeColor="White">
            <HeaderTemplate>
                <table class="auto-style1">
                    <tr>
                        <td class="auto-style3">Duyurular</td>
                        <td class="auto-style4">Düzenle</td>
                        <td class="auto-style5">Sil</td>
                    </tr>
                </table>
            </HeaderTemplate>
            <ItemTemplate>
                <table class="auto-style1">
                    <tr>
                        <td class="auto-style3">
                            <asp:Literal ID="Literal1" runat="server" Text='<%# Eval("duyurularBaslik") %>'></asp:Literal>
                        </td>
                        <td class="auto-style4">
                            <a href="duyuruguncelle.aspx?duyurularID=<%#Eval("duyurularID") %>"><img alt="" class="auto-style6" src="../tema/guncelle.png" /></a>
                        </td>
                        <td class="auto-style5">
                           <a href="duyurular.aspx?duyurularID=<%#Eval("duyurularID") %>&islem=sil"> <img alt="" class="auto-style6" src="../tema/sil.png" /></a>
                        </td>
                    </tr>
                </table>
            </ItemTemplate>
        </asp:DataList>
     </asp:Panel>
    <div style="height:30px;"></div>

</asp:Content>
