<%@ Page Title="" Language="C#" MasterPageFile="~/_Jogos/SiteMasterPage.Master" AutoEventWireup="true" CodeBehind="CadastroEdicaoJogo.aspx.cs" Inherits="BibliotecaGames.Site._Jogos.CadastroEdicaoJogo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="form-group">
            <label for="TxtTitulo">Título</label>
            <asp:TextBox runat="server" ID="TxtTitulo" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="ValorPago">Valor Pago</label>
            <asp:TextBox runat="server" ID="ValorPago" TextMode="Number" CssClass="form-control"></asp:TextBox>
        </div>

        <div class="form-group">
            <label for="DataCompra">Data Compra</label>
            <asp:TextBox runat="server" ID="DataCompra" TextMode="Date" CssClass="form-control"></asp:TextBox>
        </div>

        <div class="form-group">
            <label for="Imagem">Imagem</label>
            <asp:FileUpload ID="Imagem" runat="server" CssClass="form-control"/>
        </div>

        <div class="form-group">
            <label for="Genero">Gênero</label>
            <asp:DropDownList runat="server" ID="DDLGenero" CssClass="form-control"></asp:DropDownList>
        </div>
        
        <div class="form-group">
            <label for="DDLEditor">Editor</label>
            <asp:DropDownList ID="DDLEditor" runat="server" DataValueField="ID" DataTextField="Nome" CssClass="form-control"></asp:DropDownList>
        </div>
       
        <asp:Button  ID="BTNGravar" Text="Gravar" CssClass="btn btn-primary" runat="server"/>
    </div>
</asp:Content>
