<%@ Page Title="" Language="C#" MasterPageFile="~/masterSayfa.Master" AutoEventWireup="true" CodeBehind="blog1.aspx.cs" Inherits="masterBlog.blog" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="Content/css/projelerim.css" rel="stylesheet" />
    <asp:ListView ID="lstmobil" runat="server">
        
        <ItemTemplate>
            <div class="kirmizi">
        <div class="kirmizi-container">

            <div class="ozgur">
                <div class="ozgurresim">
                    <asp:Image ImageUrl='<%#"/blogResim/" + Eval("blogResim")  %>' runat="server" />
                </div>
            </div>
            <div class="kirmiziyazi">
                <h1><asp:Label  Text='<%# Eval("blogBaslik")    %>' runat="server" /></h1>
                <p>
<asp:Label  Text='<%# Eval("blogOzet") %>' runat="server" />                </p>

            </div>
        </div>
    </div>
           
        </ItemTemplate>
    </asp:ListView>


    <br />


            

   </asp:Content>
