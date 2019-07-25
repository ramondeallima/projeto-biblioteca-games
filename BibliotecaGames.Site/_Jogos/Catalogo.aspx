<%@ Page Title="" Language="C#" MasterPageFile="~/_Jogos/SiteMasterPage.Master" AutoEventWireup="true" CodeBehind="Catalogo.aspx.cs" Inherits="BibliotecaGames.Site._Jogos.Catalogo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../Jogos/catalogo.css" rel="stylesheet" />

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div class="container">
        <h4>Catálogo de Jogos</h4>
        <a href="CadastroEdicaoJogo.aspx">Cadastrar Novo Jogo</a>
        <hr />
        <asp:Repeater ID="RepeaterJogos" runat="server">
            <ItemTemplate>
                <div class="jogo" onclick="redirecionarParaPaginaDoJogo('<%= Session["Perfil"].ToString() %>' , <%# DataBinder.Eval(Container.DataItem, "ID") %>)">
                    <div class ="capa-jogo">
                        <img src="../ImagensJogos/<%# DataBinder.Eval(Container.DataItem, "Imagem") %>" alt="<%# DataBinder.Eval(Container.DataItem, "Titulo") %>" />
                    </div>
                    <div class="nome-jogo">
                        <%# DataBinder.Eval(Container.DataItem, "Titulo") %>
                    </div>
                </div>
            </ItemTemplate>
        </asp:Repeater>
        <script>     
            function redirecionarParaPaginaDoJogo(perfil, id) {
                if (perfil == "A") {
                    top.location.href = "CadastroEdicaoJogo.aspx?id="
                } else {
                    top.location.href = "DetalhesJogo.aspx?id="
                }
                
            }
        </script>
    </div>
    
</asp:Content>
