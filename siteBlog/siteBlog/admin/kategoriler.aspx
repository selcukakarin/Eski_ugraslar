<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.Master" AutoEventWireup="true" CodeBehind="kategoriler.aspx.cs" Inherits="siteBlog.admin.kategoriler" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 243px;
        }
        .auto-style3 {
            width: 87px;
        }
        .auto-style4 {
            width: 509px;
        }
        .auto-style5 {
            width: 36px;
            height: 36px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <div style="height:25px; background-color:#2a595a; color:#fff; font-weight:bolder;">&nbsp;
            <asp:Button ID="btkeArti" runat="server" Height="25px" OnClick="btkeArti_Click" Text="+" Width="25px" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btkeEksi" runat="server" Height="25px" OnClick="btkeEksi_Click" Text="-" Width="25px" />
&nbsp;&nbsp; Kategori Ekleme Paneli</div>
    </div>
    <asp:Panel ID="pnl_kategoriEkle" runat="server" BackColor="#669999" ForeColor="White">
    <table class="auto-style1">
        <tr>
            <td class="auto-style2" style="text-align: right">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2" style="text-align: right">Kategori Adı:</td>
            <td>
                <asp:TextBox ID="txt_kategoriAdi" runat="server" CssClass="textboxGorsel"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2" style="text-align: right">Sıra:</td>
            <td>
                <asp:TextBox ID="txt_Sira" runat="server" CssClass="textboxGorsel"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2" style="text-align: right">Resim:</td>
            <td>
                <asp:FileUpload ID="fu_kategoriResim" runat="server" CssClass="textboxGorsel" Width="300px" />
            </td>
        </tr>
        <tr>
            <td class="auto-style2" style="text-align: right">&nbsp;</td>
            <td>
                <asp:Button ID="btn_kategoriEkle" runat="server" CssClass="butonGorsel"  Text="Button" OnClick="btn_kategoriEkle_Click" />
            </td>
        </tr>
        <tr>
            <td class="auto-style2" style="text-align: right">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
        </asp:Panel>
    <div style="height:30px;"></div>
    <div>
        <div style="height:25px; background-color:#2a595a; color:#fff; font-weight:bolder;">&nbsp;
            <asp:Button ID="btn_KategoriDuzenArti" runat="server" Height="25px"  Text="+" Width="25px" OnClick="btn_KategoriDuzenArti_Click" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btn_kategoriDuzenEksi" runat="server" Height="25px" Text="-" Width="25px" OnClick="btn_kategoriDuzenEksi_Click" />
&nbsp;&nbsp; Kategori Ekleme Paneli</div>
    </div>
    <asp:Panel ID="pnl_kategoriDuzenle" runat="server" BackColor="#669999" ForeColor="White">
        <asp:DataList ID="dl_kategoriGetir" runat="server">
            <HeaderTemplate>
                <table class="auto-style1">
                    <tr>
                        <td class="auto-style4">KATEGORİ ADI</td>
                        <td class="auto-style3">DÜZENLE</td>
                        <td>SİL</td>
                    </tr>
                </table>
            </HeaderTemplate>
            <ItemTemplate>
                <table class="auto-style1">
                    <tr>
                        <td class="auto-style4">
                            <asp:Literal ID="Literal1" runat="server" Text='<%# Eval("kategoriAdi") %>'></asp:Literal>
                        </td>
                        <td class="auto-style3">
                            <a href="kategori_Guncelle.aspx?kategoriID=<%#Eval("kategoriID") %>"><img alt="" class="auto-style5" src="../tema/guncelle.png" /></a>
                        </td>
                        <td>
                            <a href="kategoriler.aspx?kategoriID=<%#Eval("kategoriID")  %>&islem=sil"><img alt="" class="auto-style5" src="../tema/sil.png" /></a>
                        </td>
                    </tr>
                </table>
            </ItemTemplate>
        </asp:DataList>
        </asp:Panel>
    <div style="height:30px;"></div>
    
</asp:Content>
