using System;
using System.Data.SqlClient;
using BibliotecaGames.Entities;

namespace BibliotecaGames.DAL
{
    public class UsuarioDAO
    {
        public Usuario ObterUsuarioPeloUsuarioESenha(string nomeUsuario, string senha)
        {
            try
            {

                SqlCommand command = new SqlCommand();
                command.Connection = Conexao.connection;
                command.CommandText = "SELECT * FROM USUARIOS WHERE USUARIO = @USUARIO AND SENHA = @SENHA";

                command.Parameters.AddWithValue("@USUARIO", nomeUsuario);
                command.Parameters.AddWithValue("@SENHA", senha);

                Conexao.Conectar();

                var reader = command.ExecuteReader();

                Usuario usuario = null;

                while (reader.Read())
                {
                    usuario = new Usuario();

                    usuario.ID           = Convert.ToInt32(reader["ID"]);
                    usuario.NomeUsuario  = reader["USUARIO"].ToString();
                    usuario.Senha        = reader["SENHA"].ToString();
                    usuario.Perfil       = Convert.ToChar(reader["PERFIL"]);
                }
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
