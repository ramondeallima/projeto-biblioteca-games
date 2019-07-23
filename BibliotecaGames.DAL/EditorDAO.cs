using BibliotecaGames.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaGames.DAL
{
    public class EditorDAO
    {
        public List<Editor> ObterTodosEditores()
        {
            try
            {

                SqlCommand command = new SqlCommand();
                command.Connection = Conexao.connection;
                command.CommandText = "SELECT * FROM EDITORES";

                Conexao.Conectar();

                var reader = command.ExecuteReader();

                var editores = new List<Editor>();

                while (reader.Read())
                {
                    var editor = new Editor();

                    editor.ID = Convert.ToInt32(reader["ID"]);
                    editor.Nome = reader["NOME"].ToString();

                    editores.Add(editor);
                }

                return editores;
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
