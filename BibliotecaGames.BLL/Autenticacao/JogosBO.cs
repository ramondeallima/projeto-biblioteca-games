using System;
using BibliotecaGames.DAL;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaGames.Entities;

namespace BibliotecaGames.BLL.Autenticacao
{
    public class JogosBO
    {
        private JogoDAO _jogoDAO;

        public List<Jogo> ObterTodosOsJogos()
        {
            _jogoDAO = new JogoDAO();
            return _jogoDAO.ObterTodosOsJogos();
        }
    }
}
