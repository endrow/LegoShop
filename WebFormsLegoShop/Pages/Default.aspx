<%@ Page Title="Dear, Traveler!" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebFormsLegoShop._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="text-center">
        <h1><%: Title %></h1>
        <h2>LEGO Shop can help you find the perfect gift.</h2>
        <img src="../Images/default.jpg" class="rounded mx-auto d-block greeting-image" />
    </div>
</asp:Content>
