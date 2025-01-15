using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda.Conection
{
    public class Conexao
    {
        private static string connectionString =
        "Data Source=localhost;Initial Catalog=Agenda;Integrated Security=True";

        // Método para obter a conexão
        public SqlConnection obterConexao()
        {
            SqlConnection conexao = new SqlConnection(connectionString);

            try
            {

                conexao.Open();
                

            }
            catch (SqlException ex)
            {

                MessageBox.Show("Ocorreu um erro na conexão!");
                

            }

            return conexao;


        }


    }


}
