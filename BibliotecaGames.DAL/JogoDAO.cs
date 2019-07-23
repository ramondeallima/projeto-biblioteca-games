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

                    jogo.ID = Convert.ToInt32(reader["ID"]);
                    jogo.Titulo = reader["TITULO"].ToString();
                    jogo.ValorPago = reader["VALOR_PAGO"] == DBNull.Value ? (double?)null : Convert.ToDouble(reader["VALOR_PAGO"]);
                    jogo.Imagem = reader["IMAGEM"].ToString();
                    jogo.DataCompra = reader["DATA_COMPRA"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(reader["DATA_COMPRA"]);

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

        public int InserirJogo(Jogo jogo)
        {

            try
            {

                SqlCommand command = new SqlCommand();
                command.Connection = Conexao.connection;
                command.CommandText = @"INSERT INTO[dbo].[JOGOS]
                                                ([TITULO]
                                                ,[VALOR_PAGO]
                                                ,[DATA_COMPRA]
                                                ,[ID_GENERO]
                                                ,[ID_EDITOR]
                                                ,[IMAGEM]
                                                 )
                                        VALUES
                                                (@TITULO,
                                                 @VALOR_PAGO
                                                 @DATA_COMPRA
                                                 @ID_GENERO
                                                 @ID_EDITOR
                                                 @IMAGEM)";

                command.Parameters.AddWithValue("@TITULO",      jogo.Titulo);
                command.Parameters.AddWithValue("@VALOR_PAGO",  jogo.ValorPago);
                command.Parameters.AddWithValue("@DATA_COMPRA", jogo.DataCompra);
                command.Parameters.AddWithValue("@ID_GENERO",   jogo.IDGenero);
                command.Parameters.AddWithValue("@ID_EDITOR",   jogo.IDEditor);
                command.Parameters.AddWithValue("@IMAGEM",      jogo.Imagem);

                Conexao.Conectar();

                return command.ExecuteNonQuery();
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


