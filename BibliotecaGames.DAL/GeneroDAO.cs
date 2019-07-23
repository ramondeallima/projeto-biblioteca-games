using BibliotecaGames.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaGames.DAL
{
    public class GeneroDAO
    {
        public List<Genero> ObterTodosOsGeneros()
        {
            try
            {

                SqlCommand command = new SqlCommand();
                command.Connection = Conexao.connection;
                command.CommandText = "SELECT * FROM GENEROS";

                Conexao.Conectar();

                var reader = command.ExecuteReader();

                var generos = new List<Genero>();

                while (reader.Read())
                {
                    var genero = new Genero();

                    genero.ID = Convert.ToInt32(reader["ID"]);
                    genero.Descricao = reader["DESCRICAO"].ToString();

                    generos.Add(genero);
                }

                return generos;
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
