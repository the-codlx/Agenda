using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda.Conection
{
    public class Conexao
    {
        private static string connectionString =
        @"Data Source=LUCAS\SQLEXPRESS;Initial Catalog=Agenda;Integrated Security=True";

        public static SqlConnection connection = null;

        // Método para obter a conexão
        public static SqlConnection obterConexao()
        {

            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();

                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }

            return connection;

        }

        public static void fecharConexao()
        {
            try
            {
                if (connection != null && connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                    
                }
            }
            catch (SqlException ex)
            {

                MessageBox.Show("Ocorreu um erro na conexão!" + ex);

            }
        }

    }


}
