using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaGames.BLL.Modelo
{
    public class Jogo : ID
    {
        public double ValorPago { get; set; }
        public string Imagem { get; set; }
        public DateTime DataCompra { get; set; }
    }
}
