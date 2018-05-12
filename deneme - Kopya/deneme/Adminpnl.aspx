﻿<%@ Page Title="" Language="C#" MasterPageFile="~/AdminPanel.Master" AutoEventWireup="true" CodeBehind="Adminpnl.aspx.cs" Inherits="deneme.adminpnl" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style2 {
            width: 244px;
        }
        .auto-style3 {
            width: 244px;
            height: 22px;
        }
        .auto-style4 {
            height: 22px;
        }
        .auto-style5 {
            width: 100%;
        }
        .auto-style8 {
            width: 562px;
            height: 27px;
        }
        .auto-style10 {
            height: 27px;
        }
        .auto-style11 {
            width: 30px;
            height: 31px;
        }
        .auto-style12 {
            width: 560px;
        }
        .auto-style13 {
            width: 58px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="sagust">
        <asp:Button ID="arti" runat="server" Text="+" Width="34px" OnClick="arti_Click" />
&nbsp;&nbsp;
        <asp:Button ID="eksi" runat="server" Text="-" Width="34px" OnClick="eksi_Click"  />
&nbsp;&nbsp; Urun Ekleme Paneli</div>
    <asp:Panel ID="blogekle" runat="server" CssClass="paneller">
        <table id="tabloblogekle" >
        <tr>
            <td class="auto-style2" style="text-align: center; font-family: 'Trajan Pro'; font-size: 16px">

            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2" style="text-align: center; font-family: 'Trajan Pro'; font-size: 16px">Urun Başlık</td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2" style="text-align: center; font-family: 'Trajan Pro'; font-size: 16px">Urun İçerik</td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server" Height="66px" TextMode="MultiLine" Width="400px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2" style="text-align: center; font-family: 'Trajan Pro'; font-size: 16px">Urun Özet</td>
            <td>
                <asp:TextBox ID="TextBox3" runat="server" Height="66px" TextMode="MultiLine" Width="400px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3" style="text-align: center; font-family: 'Trajan Pro'; font-size: 16px">Urun Resim</td>
            <td class="auto-style4">
                <asp:FileUpload ID="FileUpload1" runat="server" />
                &nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label1" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style2" style="text-align: center; font-family: 'Trajan Pro'; font-size: 16px"></td>
            <td>
                <asp:Button ID="Button1" runat="server" Text="Ekle" OnClick="Button1_Click"  />
            </td>
        </tr>
        <tr>
            <td class="auto-style2" style="text-align: center; font-family: 'Trajan Pro'; font-size: 16px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table></asp:Panel>
    <div class="sagalt">
        <asp:Button ID="Button4" runat="server"  Text="+" Width="34px" OnClick="Button4_Click"/>
&nbsp;&nbsp;
        <asp:Button ID="Button5" runat="server"  Text="-" Width="34px" OnClick="Button5_Click" />
&nbsp;&nbsp; Urun Güncelleme Paneli</div>
    <asp:Panel ID="blogguncelle" runat="server" CssClass="paneller">
        <asp:DataList ID="DataList1" runat="server" Width="672px">
            <HeaderTemplate>
                <table class="auto-style5">
                    <tr>
                        <td class="auto-style12">Urun Başlık</td>
                        <td class="auto-style13">Güncelle</td>
                        <td>Sil</td>
                    </tr>
                </table>
            </HeaderTemplate>
            <ItemTemplate>
                <table class="auto-style5">
                    <tr>
                        <td class="auto-style8">
                            <asp:Literal ID="Literal1" runat="server" Text='<%# Eval("blogBaslik") %>'></asp:Literal>
                        </td>
                        <td class="auto-style10">
                            &nbsp;<img alt="" class="auto-style11" src="images/Update.png" /></td>
                        <td class="auto-style10">
                            &nbsp;<img alt="" class="auto-style11" src="images/delete.png" /></td>
                    </tr>
                </table>
            </ItemTemplate>
        </asp:DataList>
        </asp:Panel>
</asp:Content>
