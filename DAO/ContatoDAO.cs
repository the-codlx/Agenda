using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Agenda.Conection;
using Agenda.Model;

namespace Agenda.DAO
{
    public class ContatoDAO
    {

        private SqlConnection conexao = new Conexao().obterConexao();

        public void insereContato(Contato contato) 
        {

            string sql = "INSERT INTO Contato(nome, email) values (@nome, @email)";

            try
            {

                conexao.Open();

                SqlCommand comando = new SqlCommand (sql);

                comando.Parameters.AddWithValue("@nome", contato.nome);
                comando.Parameters.AddWithValue("@email", contato.email);

                comando.ExecuteNonQuery();


            }
            catch (Exception exception)
            {

                MessageBox.Show("Ocorreu um erro na aplicação!" + exception);
                
            }

            conexao.Close();

        }

    }
}
