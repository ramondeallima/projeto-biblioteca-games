using BibliotecaGames.Entities;
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
        protected void Page_Load(object sender, EventArgs e)
        {
            CarregarJogosNoRepeater();
        }

        private void CarregarJogosNoRepeater()
        {
            RepeaterJogos.DataSource = new List<Jogo>
            {
                new Jogo {Titulo = "Titulo 1"},
                new Jogo {Titulo = "Titulo 2"},
                new Jogo {Titulo = "Titulo 3"},
                new Jogo {Titulo = "Titulo 4"},
                new Jogo {Titulo = "Titulo 5"}
            };
            RepeaterJogos.DataBind();
        }
    }
}