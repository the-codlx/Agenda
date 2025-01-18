using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Agenda.Conection;
using Agenda.Model;

namespace Agenda.DAO
{
    public static class ContatoDAO
    {
        

        public static void insereContato(Contato contato) 
        {

            string sql = "INSERT INTO Contato(nome, email) values (@nome, @email)";

            try
            {

                SqlCommand comando = new SqlCommand (sql, Conexao.obterConexao());

                comando.Parameters.AddWithValue("@nome", contato.nome);
                comando.Parameters.AddWithValue("@email", contato.email);

                comando.ExecuteNonQuery();


            }
            catch (Exception exception)
            {

                MessageBox.Show("Ocorreu um erro na aplicação!" + exception);
                
            }

            Conexao.fecharConexao();

        }

        public static DataTable retornaContatos() 
        {

            string sql = "SELECT * FROM CONTATO";
        
            DataTable dt = new DataTable();

            try
            {

                SqlCommand comando = new SqlCommand(sql, Conexao.obterConexao());

                

                comando.ExecuteNonQuery();

                SqlDataAdapter adapter = new SqlDataAdapter(comando);

                adapter.Fill(dt);


            }
            catch (Exception exception)
            {

                MessageBox.Show("Ocorreu uma exceção: " + exception);

            }

            Conexao.fecharConexao();
            return dt;

        }

        public static void editaContato(Contato contato)
        {

            string sql = "UPDATE CONTATO SET Nome = @nome, Email = @email WHERE ID = @id";

            try
            {

                SqlCommand comando = new SqlCommand(sql, Conexao.obterConexao());

                comando.Parameters.AddWithValue("@nome", contato.nome);
                comando.Parameters.AddWithValue("@email", contato.email);
                comando.Parameters.AddWithValue("@id", contato.id);

                comando.ExecuteNonQuery();

                MessageBox.Show("Contato atualizado com sucesso!");

            }
            catch (Exception exception)
            {

                MessageBox.Show("Ocorreu uma exceção! " + exception.Message);

            }

            Conexao.fecharConexao();

        }

        public static void excluiContato(int id) 
        {

            string sql = "DELETE FROM CONTATO WHERE ID = @ID";

            try
            {

                SqlCommand comando = new SqlCommand(sql, Conexao.obterConexao());

                comando.Parameters.AddWithValue("@ID", id);

                comando.ExecuteNonQuery();

                MessageBox.Show("Contato excluido com sucesso!");

            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
                
            }

            Conexao.fecharConexao();

        }

    }
}
