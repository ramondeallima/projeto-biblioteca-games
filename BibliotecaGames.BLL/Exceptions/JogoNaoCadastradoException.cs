using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaGames.BLL.Exceptions
{

    [Serializable]
    public class JogoNaoCadastradoException : Exception
    {
        public JogoNaoCadastradoException() { }
        public JogoNaoCadastradoException(string message) : base(message) { }
        public JogoNaoCadastradoException(string message, Exception inner) : base(message, inner) { }
    }
    
}
