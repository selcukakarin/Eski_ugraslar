<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.Master" AutoEventWireup="true" CodeBehind="mesajlar.aspx.cs" Inherits="siteBlog.admin.mesajlar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 28px;
            height: 29px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="height:25px; background-color:#2a595a; color:#fff; font-weight:bolder;">&nbsp;
            <asp:Button ID="btn_mesajArti" runat="server" Height="25px"  Text="+" Width="25px" OnClick="btn_mesajArti_Click"  />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btn_mesajEksi" runat="server" Height="25px"  Text="-" Width="25px" OnClick="btn_mesajEksi_Click" />
&nbsp;&nbsp; Mesaj Paneli</div>
    
    <asp:Panel ID="pnl_duyuruEkle" runat="server" BackColor="#669999" ForeColor="White">
        <asp:DataList ID="dl_mesaj" runat="server" Width="700px">
            <ItemTemplate>
                <table class="auto-style1">
                    <tr>
                        <td style="width: 200px">
                            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="18px" ForeColor="#FFFF99" Text='<%# Eval("iletisimAdSoyad") %>'></asp:Label>
                        </td>
                        <td style="width: 200px">
                            <asp:Label ID="Label2" runat="server" Font-Size="12px" Text='<%# Eval("iletisimEmail") %>'></asp:Label>
                        </td>
                        <td style="width: 200px">
                            <asp:Label ID="Label3" runat="server" Font-Size="12px" Text='<%# Eval("iletisimTarih","{0:dd MMMM yyyy}") %>'></asp:Label>
                        </td>
                        <td style="width: 98px; text-align: right;">
                            <a href="mesajlar.aspx?iletisimID=<%#Eval("iletisimID") %>&islem=sil"><img alt="" class="auto-style2" src="../tema/sil.png" /></a>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="4">
                            <asp:Label ID="Label4" runat="server" Text='<%# Eval("iletisimIcerik") %>'></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="4">&nbsp;</td>
                    </tr>
                    <tr>
                        <td colspan="4">&nbsp;</td>
                    </tr>
                </table>
            </ItemTemplate>
        </asp:DataList>
        </asp:Panel>
    <div style="height:30px;"></div>

</asp:Content>
