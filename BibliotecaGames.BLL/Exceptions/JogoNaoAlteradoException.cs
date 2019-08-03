using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaGames.BLL.Exceptions
{


    public class JogoNaoAlteradoException : Exception
    {
        public JogoNaoAlteradoException() { }
        public JogoNaoAlteradoException(string message) : base(message) { }
        public JogoNaoAlteradoException(string message, Exception inner) : base(message, inner) { }
    }
}
