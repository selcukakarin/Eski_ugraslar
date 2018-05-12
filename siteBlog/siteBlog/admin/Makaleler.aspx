<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.Master" AutoEventWireup="true" CodeBehind="Makaleler.aspx.cs" Inherits="siteBlog.admin.Makaleler" %>

<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }

        .auto-style3 {
            width: 129px;
        }

        .auto-style4 {
            width: 501px;
        }

        .auto-style5 {
            width: 87px;
        }

        .auto-style6 {
            width: 37px;
            height: 32px;
        }
    .auto-style7 {
        width: 169px;
    }
    .auto-style8 {
        width: 169px;
        height: 21px;
    }
    .auto-style9 {
        height: 21px;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div>
        <div style="height: 25px; background-color: #2a595a; color: #fff; font-weight: bolder;">
            &nbsp;
            <asp:Button ID="btmeArti" runat="server" Height="25px" Text="+" Width="25px" OnClick="btmeArti_Click" />
            &nbsp;&nbsp;&nbsp;
            <asp:Button ID="btmeEksi" runat="server" Height="25px" Text="-" Width="25px" OnClick="btmeEksi_Click" />
            &nbsp;&nbsp; Makale Ekleme Paneli
        </div>

        <asp:Panel ID="pnl_makaleEkle" runat="server" BackColor="#669999" ForeColor="White">
            <table class="auto-style1">
                <tr>
                    <td class="auto-style3" style="text-align: right">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3" style="text-align: right">Kategori:</td>
                    <td>
                        <asp:DropDownList ID="ddlist_kategori" runat="server" CssClass="dropdownlistgorsel">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3" style="text-align: right">Makale Başlık:</td>
                    <td>
                        <asp:TextBox ID="txt_mbaslik" runat="server" CssClass="textboxGorsel" Width="500px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3" style="text-align: right">Özet:</td>
                    <td>
                        <asp:TextBox ID="txt_ozet" runat="server" CssClass="textboxGorsel" Height="100px" TextMode="MultiLine" Width="500px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3" style="text-align: right">İçerik:</td>
                    <td>
                        <CKEditor:CKEditorControl ID="ckeditor" BasePath="/ckeditor/" runat="server" Width="500px"></CKEditor:CKEditorControl></td>
                </tr>
                <tr>
                    <td class="auto-style3" style="text-align: right">Slider:</td>
                    <td>
                        <asp:FileUpload ID="fu_slider" runat="server" CssClass="textboxGorsel" Width="500px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3" style="text-align: right">&nbsp;</td>
                    <td>
                        <asp:Button ID="btn_makaleekle" runat="server" CssClass="butonGorsel" Text="Ekle" OnClick="btn_makaleekle_Click" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3" style="text-align: right">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </asp:Panel>
        <div style="height: 30px"></div>
        <div style="height: 25px; background-color: #2a595a; color: #fff; font-weight: bolder;">
            &nbsp;
            <asp:Button ID="makaleDuzenleArti" runat="server" Height="25px" Text="+" Width="25px" OnClick="makaleDuzenleArti_Click" />
            &nbsp;&nbsp;&nbsp;
            <asp:Button ID="makaleDuzenleEksi" runat="server" Height="25px" Text="-" Width="25px" OnClick="makaleDuzenleEksi_Click" />
            &nbsp;&nbsp; Makale Düzenleme Paneli
        </div>

        <asp:Panel ID="PanelDuzenle" runat="server" BackColor="#669999" ForeColor="White">
            <asp:DataList ID="DataList1" runat="server" Width="699px">
                <HeaderTemplate>
                    <table class="auto-style1">
                        <tr>
                            <td class="auto-style4">MAKALE ADI</td>
                            <td class="auto-style5">GUNCELLE</td>
                            <td>SİL</td>
                        </tr>
                    </table>
                </HeaderTemplate>
                <ItemTemplate>
                    <table class="auto-style1">
                        <tr>
                            <td class="auto-style4">
                                <asp:Literal ID="Literal1" runat="server" Text='<%# Eval("makaleBaslik") %>'></asp:Literal>
                            </td>
                            <td>
                                <a href="makaleGuncelle.aspx?makaleID=<%#Eval("makaleID") %>">
                                    <img alt="" class="auto-style6" src="../tema/guncelle.png" /></a>
                            </td>
                            <td>
                                <a href="makaleler.aspx?makaleID=<%# Eval("makaleID") %>&islem=sil">
                                    <img alt="" class="auto-style6" src="../tema/sil.png" /></a>
                            </td>
                        </tr> 
                    </table>
                </ItemTemplate>
            </asp:DataList>
        </asp:Panel>
        <div style="height: 30px"></div>
        <div style="height: 25px; background-color: #2a595a; color: #fff; font-weight: bolder;">
            &nbsp;
            <asp:Button ID="Bnt_DosyaEkleArti" runat="server" Height="25px" Text="+" Width="25px" OnClick="Bnt_DosyaEkleArti_Click"  />
            &nbsp;&nbsp;&nbsp;
            <asp:Button ID="Btn_DosyaEkleEksi" runat="server" Height="25px" Text="-" Width="25px" OnClick="Btn_DosyaEkleEksi_Click"  />
            &nbsp;&nbsp; Makale Dosya Ekleme Paneli
        </div>

        <asp:Panel ID="Panel_DosyaEkle" runat="server" BackColor="#669999" ForeColor="White">
            <table class="auto-style1">
                <tr>
                    <td class="auto-style7" style="text-align: right">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style7" style="text-align: right">Dosya Seç:</td>
                    <td>
                        <asp:FileUpload ID="fu_makaleDosya" runat="server" CssClass="textboxGorsel" Width="300px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style7" style="text-align: right">&nbsp;</td>
                    <td>
                        <asp:Button ID="btn_makaleDosyaEkle" runat="server" CssClass="butonGorsel" OnClick="btn_makaleDosyaEkle_Click" Text="Ekle" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style8" style="text-align: right"></td>
                    <td class="auto-style9"></td>
                </tr>
                <tr>
                    <td class="auto-style7" style="text-align: right">NOT</td>
                    <td>&nbsp;Ekleme işlemi / dosyalar / eklenecekdosya.uzantı şeklinde kullanılacak&nbsp;</td>
                </tr>
            </table>
        </asp:Panel>
        <div style="height: 30px"></div>
    </div>

</asp:Content>
