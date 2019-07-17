using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using BibliotecaGames.Entities;

namespace BibliotecaGames.DAL
{
    public class JogoDAO
    {
        public List<Jogo> ObterTodosOsJogos()
        {
            try
            {

                SqlCommand command = new SqlCommand();
                command.Connection = Conexao.connection;
                command.CommandText = "SELECT * FROM JOGOS";

                Conexao.Conectar();

                var reader = command.ExecuteReader();

                var jogos = new List<Jogo>();

                while (reader.Read())
                {
                    var jogo = new Jogo();

                    jogo.ID         = Convert.ToInt32(reader["ID"]);
                    jogo.Titulo     = reader["TITULO"].ToString();
                    jogo.ValorPago  = reader["VALOR_PAGO"] == DBNull.Value ? (double?) null : Convert.ToDouble(reader["VALOR_PAGO"]);
                    jogo.Imagem     = reader["IMAGEM"].ToString();
                    jogo.DataCompra = reader["DATA_COMPRA"] == DBNull.Value ? (DateTime?) null : Convert.ToDateTime(reader["DATA_COMPRA"]);

                    jogos.Add(jogo);
                }

                return jogos;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                Conexao.Desconectar();
            }
        }
    }
}
