<%@ Page Title="" Language="C#" MasterPageFile="~/_Jogos/SiteMasterPage.Master" AutoEventWireup="true" CodeBehind="CadastroEdicaoJogo.aspx.cs" Inherits="BibliotecaGames.Site._Jogos.CadastroEdicaoJogo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="form-group">
            <label for="TxtTitulo">Título</label>
            <asp:TextBox runat="server" ID="TXTTitulo" CssClass="form-control"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RFVTitulo" runat="server" ControlToValidate="TXTTitulo" ErrorMessage="O preenchimento do título é obrigatório!"></asp:RequiredFieldValidator>
        </div>
        <div class="form-group">
            <label for="ValorPago">Valor Pago</label>
            <asp:TextBox runat="server" ID="TXTValorPago" TextMode="Number" CssClass="form-control"></asp:TextBox>
        </div>

        <div class="form-group">
            <label for="DataCompra">Data Compra</label>
            <asp:TextBox runat="server" ID="TXTDataCompra" TextMode="Date" CssClass="form-control"></asp:TextBox>
        </div>

        <div class="form-group">
            <label for="Imagem">Imagem</label>
            <asp:FileUpload ID="Imagem" runat="server" CssClass="form-control"/>
        </div>

        <div class="form-group">
            <label for="Genero">Gênero</label>
            <asp:DropDownList runat="server" ID="DDLGenero" CssClass="form-control" DataValueField="ID" DataTextField="DESCRICAO"></asp:DropDownList>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="DDLGenero" ErrorMessage="O preenchimento do gênero é obrigatório!"></asp:RequiredFieldValidator>
        </div>
        
        <div class="form-group">
            <label for="DDLEditor">Editor</label>
            <asp:DropDownList ID="DDLEditor" runat="server" DataValueField="ID" DataTextField="NOME" CssClass="form-control"></asp:DropDownList>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="DDLEditor" ErrorMessage="O preenchimento do editor é obrigatório!!"></asp:RequiredFieldValidator>
        </div>
       
        <asp:Button  ID="BTNGravar" Text="Gravar" CssClass="btn btn-primary" runat="server" OnClick="BTNGravar_Click"/>
        <asp:ValidationSummary runat="server" 
                               ID="VSCamposObrigatorios" 
                               DisplayMode="BulletList" 
                               EnableClientScript="true" 
                               HeaderText="Alguns erros foram encontrados, verifique abaixo:"/>
    </div>
</asp:Content>
