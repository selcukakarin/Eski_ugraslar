<%@ Page Title="" Language="C#" MasterPageFile="~/kullanici.Master" AutoEventWireup="true" CodeBehind="araDetay.aspx.cs" Inherits="siteBlog.araDetay" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="width:690px;height:auto;margin:0 auto;">
    <asp:DataList ID="dl_ara" runat="server" Width="690px">
                            <ItemTemplate>
                                <div style="width=690px;margin:auto;height:auto;">
                                    <div style="width: 690px; height: 40px; float: left">
                                        <div style="width: 40px; height: 40px; float: left">
                                            <asp:Image ID="Image3" runat="server" Height="40px" ImageUrl='<%# Eval("kategoriResim") %>' Width="40px" />
                                        </div>
                                        <div style="width: 650px; height: 40px; float: left; background-color: #58AFB4; line-height: 40px;">
                                           <a href="makaleDetay.aspx?makaleID=<%#Eval("makaleID")%>"> <asp:Label ID="Label1" runat="server" Font-Size="22px" Text='<%# Eval("makaleBaslik") %>' ForeColor="#2E2E2E"></asp:Label></a>
                                        </div>
                                    </div>
                                    <div style="float:left;height:auto;width:690px; background-color: #8CC9CC; padding-bottom: 10px;">

                                        <asp:Label ID="Label5" runat="server" Font-Size="18px" Text='<%# Eval("makaleOzet") %>' ForeColor="#313131"></asp:Label>

                                    </div>
                                    <div style="width:690px; float:left;20px;line-height:20px; font-size:12px; background-color: #A3D3D6;">

                                        <div style="width:auto; height:20px;float:left;margin-right:15px;">
                                            <img alt="" class="auto-style6" src="tema/clock.png" height="12px" width="12px" />
                                            <asp:Label ID="Label2" runat="server" Text='<%# Eval("makaleTarih","{0:MMMM dd, yyyy}") %>' ForeColor="#666666"></asp:Label>
                                        </div>
                                        <div style="width:auto; height:20px;float:left;margin-right:15px;">
                                            <img alt="" class="auto-style6" src="tema/eye.png" height="12px" width="12px" />
                                            <asp:Label ID="Label3" runat="server" Text='<%# Eval("makaleOkunma") %>' ForeColor="#666666"></asp:Label>
                                        </div>
                                    <div style="width:auto; height:20px;float:left;margin-right:15px;">
                                            <img alt="" class="auto-style6" src="tema/comment.png" height="12px" width="12px" />
                                            <asp:Label ID="Label4" runat="server" Text='<%# Eval("makaleYorumSayisi") %>' ForeColor="#666666"></asp:Label>
                                        </div>

                                    </div>
                                </div>
                                <div style="width:100%;height:40px;float:left;"></div>
                            </ItemTemplate>
                        </asp:DataList>
        </div>
    <div style="height:30px;"></div>
</asp:Content>
