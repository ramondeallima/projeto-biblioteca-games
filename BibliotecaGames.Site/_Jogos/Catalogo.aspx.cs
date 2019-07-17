using BibliotecaGames.Entities;
using BibliotecaGames.BLL.Autenticacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BibliotecaGames.Site._Jogos
{
    public partial class Catalogo : System.Web.UI.Page
    {
        private JogosBO _jogosBO;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                CarregarJogosNoRepeater();
            }

        }

        private void CarregarJogosNoRepeater()
        {
            _jogosBO = new JogosBO();

            RepeaterJogos.DataSource = _jogosBO.ObterTodosOsJogos();
            RepeaterJogos.DataBind();
        }
    }
}