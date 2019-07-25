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
        private JogosBO _jogosBO;

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
            var _jogosBO = new JogosBO();
            var jogo = new Jogo();

            jogo.Titulo     = TXTTitulo.Text;
            jogo.ValorPago  = string.IsNullOrWhiteSpace(TXTValorPago.Text) ? (double?) null : Convert.ToDouble(TXTValorPago.Text);
            jogo.DataCompra = string.IsNullOrWhiteSpace(TXTDataCompra.Text) ? (DateTime?)null : Convert.ToDateTime(TXTDataCompra.Text);

            try
            {
                jogo.Imagem = GravarImagemNoDisco();
            }
            catch (Exception)
            {
                LBLMensagem.Text = "Ocorreu um erro ao salvar a imagem!";
            }


            jogo.IDEditor   = Convert.ToInt32(DDLEditor.SelectedValue);
            jogo.IDGenero   = Convert.ToInt32(DDLGenero.SelectedValue);

            try
            {
                _jogosBO.InserirNovoJogo(jogo);
                LBLMensagem.Text = "Jogo cadastrado com sucesso!";
                BTNGravar.Enabled = false;
            }
            catch (Exception)
            {
                LBLMensagem.Text = "Ocorreu um erro ao gravar o jogo!";
            }
        }

        private string GravarImagemNoDisco()
        {
            if (Imagem.HasFile)
            {
                try
                {
                    var caminho = $"{AppDomain.CurrentDomain.BaseDirectory}\\ImagensJogos\\";
                    var fileName = $"{DateTime.Now.ToString("yyyyMMddhhmmss")}{Imagem.FileName}";
                    Imagem.SaveAs($"{caminho}{fileName}");
                    return fileName;
                }
                catch (Exception)
                {

                    throw;
                }
            }
            else
            {
                return null;
            }
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