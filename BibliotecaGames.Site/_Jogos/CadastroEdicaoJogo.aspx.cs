using BibliotecaGames.BLL;
using BibliotecaGames.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BibliotecaGames.Site._Jogos
{
    public partial class CadastroEdicaoJogo : System.Web.UI.Page
    {
        private GeneroBO _generoBO;
        private EditorBO _editorBO;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                CarregarEditoresNaCombo();
                CarregarGenerosNaCombo();
            }
        }

        protected void BTNGravar_Click(object sender, EventArgs e)
        {
            var jogo = new Jogo();

            jogo.Titulo     = TXTTitulo.Text;
            jogo.ValorPago  = string.IsNullOrWhiteSpace(TXTValorPago.Text) ? (double?) null : Convert.ToDouble(TXTValorPago.Text);
            jogo.DataCompra = string.IsNullOrWhiteSpace(TXTDataCompra.Text) ? (DateTime?) null : Convert.ToDateTime(TXTDataCompra.Text);
            jogo.Imagem     = Imagem.FileName;
            jogo.IDEditor   = Convert.ToInt32(DDLEditor.SelectedValue);
            jogo.IDGenero   = Convert.ToInt32(DDLGenero.SelectedValue);

        }

        private void CarregarEditoresNaCombo()
        {
            _editorBO = new EditorBO();
            var editores = _editorBO.ObterTodosEditores();

            DDLEditor.DataSource = editores;
            DDLEditor.DataBind();
        }

        private void CarregarGenerosNaCombo()
        {
            _generoBO = new GeneroBO();
            var generos = _generoBO.ObterTodosOsGeneros();

            DDLGenero.DataSource = generos;
            DDLGenero.DataBind();
        }
    }
}