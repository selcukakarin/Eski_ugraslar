<%@ Page Title="" Language="C#" MasterPageFile="~/kullanici.Master" AutoEventWireup="true" CodeBehind="makaleDetay.aspx.cs" Inherits="siteBlog.makaleDetay" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="width: 690px; height: auto; margin: 0 auto;">
        <asp:DataList ID="dl_MakaleGetir" runat="server" Width="690px">
            <ItemTemplate>
                <div style="width:690px; margin: auto; height: auto;">
                    <div style="width: 690px; height: 40px; float: left">
                        <div style="width: 40px; height: 40px; float: left">
                            <asp:Image ID="Image3" runat="server" Height="40px" ImageUrl='<%# Eval("kategoriResim") %>' Width="40px" />
                        </div>
                        <div style="width: 650px; height: 40px; float: left; background-color: #58AFB4; line-height: 40px;">
                            <asp:Label ID="Label1" runat="server" Font-Size="22px" Text='<%# Eval("makaleBaslik") %>' ForeColor="#2E2E2E"></asp:Label>
                        </div>
                    </div>
                    <div style="float: left; height: auto; width: 690px; background-color: #8CC9CC; padding-bottom: 10px;">

                        <asp:Label ID="Label5" runat="server" Font-Size="18px" Text='<%# Eval("makaleIcerik") %>' ForeColor="#313131"></asp:Label>

                    </div>
                    <div style="width: 690px; float: left; height:20px; line-height: 20px; font-size: 12px; background-color: #A3D3D6;">

                        <div style="width: auto; height: 20px; float: left; margin-right: 15px;">
                            <img alt="" class="auto-style6" src="tema/clock.png" />
                            <asp:Label ID="Label2" runat="server" Text='<%# Eval("makaleTarih","{0:MMMM dd, yyyy}") %>' ForeColor="#666666"></asp:Label>
                        </div>
                        <div style="width: auto; height: 20px; float: left; margin-right: 15px;">
                            <img alt="" class="auto-style6" src="tema/eye.png"  />
                            <asp:Label ID="Label3" runat="server" Text='<%# Eval("makaleOkunma") %>' ForeColor="#666666"></asp:Label>
                        </div>
                        <div style="width: auto; height: 20px; float: left; margin-right: 15px;">
                            <img alt="" class="auto-style6" src="tema/comment.png"  />
                            <asp:Label ID="Label4" runat="server" Text='<%# Eval("makaleYorumSayisi") %>' ForeColor="#666666"></asp:Label>
                        </div>

                    </div>
                </div>
                <div style="width: 100%; height: 40px; float: left;"></div>
            </ItemTemplate>
        </asp:DataList>
    </div>
    <div style="height: 30px; width: 100%">
    </div>
    <div style="background-color: #2a595c; color: #fff; height: 30px; text-align: center; font-size: 24px; font-weight: bold; width: 100%;">
        Makaleye Yapılan Yorumlar
    </div>
        <div style="height: 10px; width: 100%; float: left;">
    </div>
    
    <div style="width:690px;height:auto; margin:0 auto;">
        <asp:DataList ID="dl_yorumGetir" runat="server">
            <ItemTemplate>
                <div style="width: 688px; height: auto; float: left; ">
                    <div style="border-color: #2a595c; float: left; width: 50px; height: 60px; border-style: dotted; border-width: 1px;">
                        <asp:Image ID="Image4" runat="server" Height="60px" ImageUrl='<%# Eval("yorumResim") %>' Width="50px" />
                    </div>
                    <div style="width: 630px; height: auto; float: left">
                        <div style="float: left; width: 630px; height: 25px">
                            <asp:Label ID="Label6" runat="server" Text='<%# Eval("yorumAdSoyad") %>' Font-Size="18px" ForeColor="#333333"></asp:Label>
                            &nbsp;-
                            <asp:Label ID="Label7" runat="server" Font-Size="12px" ForeColor="#999999" Text='<%# Eval("yorumTarih","{0:dd MMMM yyyy}") %>'></asp:Label>
                        </div>
                        <div style="float:left;width:630px;height:auto;">
                            <asp:Label ID="Label8" runat="server" Text='<%# Eval("yorumIcerik") %>' ForeColor="Gray"></asp:Label>

                        </div>
                    </div>
                </div>
                <div style="float: left; width: 688px; height: 20px">
                </div>
            </ItemTemplate>
        </asp:DataList>
    </div>
    <div style="height: 30px; width: 100%">
    </div>
    <div style="background-color: #2a595c; color: #fff; height: 30px; text-align: center; font-size: 24px; font-weight: bold; width: 100%;">
        &nbsp;</div>
    <div style="height: 10px; width: 100%; float: left;">
    </div>
    <div style="height: 200px; width: 100%; float: left;">
        <div style="border: 1px dotted #2a595c; width: 330px; height: 200px; float: left; margin-left:5px; ">
            <asp:TextBox ID="txt_YorumIcerik" placeHolder="Buraya Yorum Yazınız" runat="server" Height="200px" TextMode="MultiLine" Width="330px"></asp:TextBox>
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
                        <asp:Button ID="btn_YorumEkle" runat="server" CssClass="butonGorsel" Text="Gönder" OnClick="btn_YorumEkle_Click" />
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
    </div>
    </div>


</asp:Content>
