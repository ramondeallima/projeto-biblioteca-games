using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaGames.BLL.Exceptions
{

    public class JogoInvalidoException : Exception
    {
        public JogoInvalidoException() { }
        public JogoInvalidoException(string message) : base(message) { }
        public JogoInvalidoException(string message, Exception inner) : base(message, inner) { }

    }
}
