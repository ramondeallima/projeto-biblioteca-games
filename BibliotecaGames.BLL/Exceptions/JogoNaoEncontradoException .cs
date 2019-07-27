﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaGames.BLL.Exceptions
{

    public class JogoNaoEncontradoException : Exception
    {
        public JogoNaoEncontradoException() { }
        public JogoNaoEncontradoException(string message) : base(message) { }
        public JogoNaoEncontradoException(string message, Exception inner) : base(message, inner) { }

    }
}
