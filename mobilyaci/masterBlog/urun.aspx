<%@ Page Title="" Language="C#" MasterPageFile="~/masterSayfa.Master" AutoEventWireup="true" CodeBehind="urun.aspx.cs" Inherits="masterAdmin.blog" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="Content/css/blog1.css" rel="stylesheet" />



    <asp:ListView ID="ListView1" runat="server" DataSourceID="SqlDataSource1">
        <ItemTemplate>
            <div class="kirmizi">
                <div class="kirmizi-container">

                    <div class="kirmizi kirmizi-container resim"> <img src='/urunresim/<%# Eval("urunResim") %>' width="191" height="171"/></div>
                    <div class="kirmiziyazi">
                        <h1><%# Eval("urunBaslik") %></h1>
                        <p>
                            <%# Eval("urunIcerik") %>
                        </p>

                    </div>
                </div>
            </div>


        </ItemTemplate>


    </asp:ListView>
    <br />




   <div class="pager">
    <asp:DataPager ID="DataPager1" runat="server" PagedControlID="ListView1" PageSize="5">
        <Fields>
            <asp:NextPreviousPagerField ButtonType="Button" ShowFirstPageButton="True" ShowNextPageButton="False" ShowPreviousPageButton="False" />
            <asp:NumericPagerField />
            <asp:NextPreviousPagerField ButtonType="Button" ShowLastPageButton="True" ShowNextPageButton="False" ShowPreviousPageButton="False" />
        </Fields>
    </asp:DataPager>
    </div>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:urunConnectionString %>" SelectCommand="SELECT [urunBaslik], [urunIcerik], [urunResim], [urunTarih] FROM [urun] ORDER BY [urunTarih] DESC"></asp:SqlDataSource>
</asp:Content>
