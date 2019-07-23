using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaGames.Entities
{
    public class Jogo : IntID
    {
        public double? ValorPago { get; set; }
        public string Imagem { get; set; }
        public DateTime? DataCompra { get; set; }
        public string Titulo { get; set; }
        public int IDGenero { get; set; }
        public Genero Genero { get; set; }
        public int IDEditor { get; set; }
        public Editor Editor { get; set; }
    }
}
