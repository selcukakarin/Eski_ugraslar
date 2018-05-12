<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.Master" AutoEventWireup="true" CodeBehind="yorumlar.aspx.cs" Inherits="siteBlog.admin.yorumlar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }

        .auto-style2 {
            width: 403px;
        }

        .auto-style3 {
            width: 25px;
            height: 25px;
        }

        .auto-style4 {
            width: 30px;
            height: 30px;
        }

        .auto-style5 {
            width: 36px;
            height: 37px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div>
        <div>
            <div style="height: 25px; background-color: #2a595a; color: #fff; font-weight: bolder; line-height: 25px;">
                &nbsp;
            <asp:Button ID="btn_oyarti" runat="server" Height="25px" OnClick="btkeArti_Click" Text="+" Width="25px" />
                &nbsp;&nbsp;&nbsp;
            <asp:Button ID="btn_oyeksi" runat="server" Height="25px" OnClick="btkeEksi_Click" Text="-" Width="25px" />
                &nbsp;&nbsp; Onaysız Yorum Paneli
            </div>
        </div>
        <asp:Panel ID="pnl_onasizyorum" runat="server" ForeColor="White">

            <asp:DataList ID="dl_yorum" runat="server" Width="700px">
                <ItemTemplate>
                    <div style="width: 690px; height: auto">
                        <div style="width: 100px; height: 60px; float: left">
                            <asp:Image ID="Image1" runat="server" Height="60px" ImageUrl='<%# Eval("yorumResim") %>' Width="60px" />
                        </div>
                        <div style="width: 590px; height: auto; float: left">
                            <div style="float: left; width: 590px; height: 25px; background-color: #669999;">
                                <asp:Label ID="Label1" runat="server" Font-Size="18px" Text='<%# Eval("yorumAdSoyad") %>' ForeColor="White"></asp:Label>
                                &nbsp;-
                            <asp:Label ID="Label2" runat="server" Font-Size="12px" Text='<%# Eval("yorumEmail") %>' ForeColor="White"></asp:Label>
                                &nbsp;-
                            <asp:Label ID="Label3" runat="server" Font-Size="12px" Text='<%# Eval("yorumTarih","{0:dd MMMM yyyy}") %>' ForeColor="#FFFFFF"></asp:Label>
                            </div>
                            <div style="width: 590px; height: 25px; float: left; color: #E4E4E4; background-color: #82ACAC; font-weight: bold;">
                                Makale :
                            <asp:Label ID="Label4" runat="server" Text='<%# Eval("makaleBaslik") %>' ForeColor="White"></asp:Label>
                            </div>
                            <div style="width: 590px; height: auto; float: left; background-color: #98BABA;">
                                <asp:Label ID="Label5" runat="server" Text='<%# Eval("yorumIcerik") %>' ForeColor="#666666"></asp:Label>
                            </div>
                            <div style="width: 590px; height: 40px; float: left;">

                                <table class="auto-style1" style="text-align: right">
                                    <tr>
                                        <td class="auto-style2">
                                         <a href="yorumGuncelle.aspx?yorumID=<%#Eval("yorumID") %>&makaleID=<%#Eval("makaleID") %>">   <img alt="" class="auto-style4" src="../tema/guncelle.png" /></a>
                                        </td>
                                        <td>
                                           <a href="yorumlar.aspx?yorumID=<%#Eval("yorumID") %>&islem=sil"> <img alt="" class="auto-style3" src="../tema/sil.png" /></a>
                                        </td>
                                        <td>
                                           <a href="yorumCevap.aspx?makaleID=<%#Eval("makaleID") %>"> <img alt="" class="auto-style5" src="../tema/comment.png" /></a>
                                        </td>
                                    </tr>
                                </table>

                            </div>
                        </div>

                    </div>
                    <div style="width: 690px; height: 25px; float: left;">
                    </div>
                </ItemTemplate>
            </asp:DataList>
        </asp:Panel>
        <div style="height: 30px;"></div>
        <div>
            <div style="height: 25px; background-color: #2a595a; color: #fff; font-weight: bolder; line-height: 25px;">
                &nbsp;
            <asp:Button ID="btn_onaylananarti" runat="server" Height="25px" Text="+" Width="25px" OnClick="btn_onaylananarti_Click" />
                &nbsp;&nbsp;&nbsp;
            <asp:Button ID="btn_onaylananeksi" runat="server" Height="25px"  Text="-" Width="25px" OnClick="btn_onaylananeksi_Click" />
                &nbsp;&nbsp; Onaylanan Yorum Paneli
            </div>
        </div>
        <asp:Panel ID="pnl_onaylananYorum" runat="server" ForeColor="White">

            <asp:DataList ID="dl_onayli" runat="server" Width="700px">
                <ItemTemplate>
                    <div style="width: 690px; height: auto">
                        <div style="width: 100px; height: 60px; float: left">
                            <asp:Image ID="Image1" runat="server" Height="60px" ImageUrl='<%# Eval("yorumResim") %>' Width="60px" />
                        </div>
                        <div style="width: 590px; height: auto; float: left">
                            <div style="float: left; width: 590px; height: 25px; background-color: #669999;">
                                <asp:Label ID="Label1" runat="server" Font-Size="18px" Text='<%# Eval("yorumAdSoyad") %>' ForeColor="White"></asp:Label>
                                &nbsp;-
                            <asp:Label ID="Label2" runat="server" Font-Size="12px" Text='<%# Eval("yorumEmail") %>' ForeColor="White"></asp:Label>
                                &nbsp;-
                            <asp:Label ID="Label3" runat="server" Font-Size="12px" Text='<%# Eval("yorumTarih","{0:dd MMMM yyyy}") %>' ForeColor="#FFFFFF"></asp:Label>
                            </div>
                            <div style="width: 590px; height: 25px; float: left; color: #E4E4E4; background-color: #82ACAC; font-weight: bold;">
                                Makale :
                            <asp:Label ID="Label4" runat="server" Text='<%# Eval("makaleBaslik") %>' ForeColor="White"></asp:Label>
                            </div>
                            <div style="width: 590px; height: auto; float: left; background-color: #98BABA;">
                                <asp:Label ID="Label5" runat="server" Text='<%# Eval("yorumIcerik") %>' ForeColor="#666666"></asp:Label>
                            </div>
                            <div style="width: 590px; height: 40px; float: left;">

                                <table class="auto-style1" style="text-align: right">
                                    <tr>
                                        <td class="auto-style2">
                                            &nbsp;</td>
                                        <td>
                                            &nbsp;</td>
                                        <td>
                                           <a href="yorumGuncelle.aspx?yorumID=<%#Eval("yorumID") %>&islemiki=siliki&makaleID=<%#Eval("makaleID") %>"><img alt="" class="auto-style3" src="../tema/sil.png" /></a></td>
                                    </tr>
                                </table>

                            </div>
                        </div>

                    </div>
                    <div style="width: 690px; height: 25px; float: left;">
                    </div>
                </ItemTemplate>
            </asp:DataList>
        </asp:Panel>
        <div style="height: 30px;"></div>
    </div>
</asp:Content>
