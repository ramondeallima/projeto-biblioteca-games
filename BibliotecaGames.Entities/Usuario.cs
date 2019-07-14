using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaGames.Entities
{
    public class Usuario : IntID
    {
        public string NomeUsuario { get; set; }
        public string Senha { get; set; }
        public char Perfil { get; set; }
    }
}
