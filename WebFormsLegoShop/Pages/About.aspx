<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="~/Site.Master.cs" Inherits="WebFormsLegoShop.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <img src="../Images/about.jpg" class="about-image" />
    <h2><%: Title %></h2>
    <p>This is our LEGO webshop, where you can find a lot of different LEGO for your friends (or foes).</p>
    <p>In the Products menu you can find all of our products.</p>
    <p>
        If you are only interested in different categories, such as LEGO Kingdoms or Pirates, you can click on any of them in the Categories dropdown list. 
        After that you will only see products from the chosen category.
    </p>
    <p>Our current categories are:</p>
    <asp:ListView ID="categoryList"
        ItemType="WebFormsLegoShop.Models.Category"
        runat="server"
        SelectMethod="GetCategories">
        <ItemTemplate>
            <a href="Pages/Products/Index.aspx?id=<%#: Item.CategoryID %>">
                <%#: Item.CategoryName %>
            </a>
            <p>
                <%#: Item.Description %>
            </p>
        </ItemTemplate>
    </asp:ListView>
</asp:Content>
