using Agenda.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda.Utils
{
    public class Utils
    {
        public static void atualizaDataGridView(DataGridView dataGrid) 
        {

            DataTable dataTable = null;

            try
            {

                dataTable = ContatoDAO.retornaContatos();

                dataGrid.DataSource = dataTable;

            }
            catch (Exception exceção)
            {

                MessageBox.Show(exceção.Message);
                
            }
        
        }

        public static void limpaCampos(TextBox txtnome, TextBox txtemail) 
        {

            txtnome.Text = "";
            txtemail.Text = "";
        
        }

    }
}
