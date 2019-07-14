using BibliotecaGames.BLL.Autenticacao;
using BibliotecaGames.BLL.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BibliotecaGames.Site.Autenticacao
{
    public partial class Login : System.Web.UI.Page
    {
        private LoginBO _loginBO;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnLogin_Click(object sender, EventArgs e)
        {
            _loginBO = new LoginBO();

            var nomeUsuario = TxtUsuario.Text;
            var senha = TxtSenha.Text;

            try
            {
                var usuario = _loginBO.ObterUsuarioParaLogar(nomeUsuario, senha);
                FormsAuthentication.RedirectFromLoginPage(nomeUsuario, false);
            }
            catch (UsuarioNaoCadastradoException)
            {
                LBLStatus.Text = "Usuário não cadastrado";
            }
            catch (Exception)
            {
                LBLStatus.Text = "Ocorreu um erro inesperado, favor consultar o administrador do sistema.";
            }
            

        }
    }
}