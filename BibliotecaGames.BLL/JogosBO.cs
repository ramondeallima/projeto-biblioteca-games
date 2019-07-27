using System;
using BibliotecaGames.DAL;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaGames.Entities;
using BibliotecaGames.BLL.Exceptions;

namespace BibliotecaGames.BLL
{
    public class JogosBO
    {
        private JogoDAO _jogoDAO;

        public List<Jogo> ObterTodosOsJogos()
        {
            _jogoDAO = new JogoDAO();
            return _jogoDAO.ObterTodosOsJogos();
        }

        public Jogo ObterJogoPeloID(int ID)
        {
            _jogoDAO = new JogoDAO();
            var jogo = _jogoDAO.ObterJogoPeloID(ID);

            if (jogo == null)
            {
                throw new JogoNaoEncontradoException();
            }

            return _jogoDAO.ObterJogoPeloID(ID);
            
        }

        public void InserirNovoJogo(Jogo jogo)
        {
            ValidarJogo(jogo);

            _jogoDAO = new JogoDAO();
            var linhasAfetadas = _jogoDAO.InserirJogo(jogo);

            if (linhasAfetadas == 0)
            {
                throw new JogoNaoCadastradoException();
            }
        }

        public void ValidarJogo(Jogo jogo)
        {
            if (string.IsNullOrWhiteSpace(jogo.Titulo) ||
                jogo.IDEditor == 0 ||
                jogo.IDGenero == 0)
            {
                throw new JogoInvalidoException();
            }
        }
    }
}
