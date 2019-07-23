using BibliotecaGames.BLL;
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