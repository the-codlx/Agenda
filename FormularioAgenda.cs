using Agenda.Conection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Agenda.DAO;
using Agenda.Model;
using Agenda.Utils;

namespace Agenda
{
    public partial class FormularioAgenda : Form
    {

        private static int id = -1;

        public FormularioAgenda()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //verifica se os campos nome e email estão vazios antes de inserir
                if (verificaSeOsCamposEstaoVazios(txtnome, txtemail))
                {

                    Contato contato = new Contato();

                    contato.nome = txtnome.Text;
                    contato.email = txtemail.Text;

                    ContatoDAO.insereContato(contato);

                    MessageBox.Show("Contato inserido com sucesso!");

                    limpaCamposEAtualizaDataGridView();

                }

            }
            catch (Exception exception)
            {

                MessageBox.Show("Ocorreu um erro na aplicação " + exception.Message);
                
            }

        }

        private void txtnome_TextChanged(object sender, EventArgs e)
        {

            

        }

        private void FormularioAgenda_Load(object sender, EventArgs e)
        {
            Utils.Utils.atualizaDataGridView(dataGridAgenda);

            dataGridAgenda.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void dataGridAgenda_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {

                //pega o valor da coluna "id" da célula que o usuário clicar e faz o parse para int
                id = int.Parse(dataGridAgenda.Rows[dataGridAgenda.CurrentCell.RowIndex].Cells[0].Value.ToString());

                //pega o valor da coluna que estiver dentro do colchetes Cells[]                 |
                txtnome.Text = dataGridAgenda.Rows[dataGridAgenda.CurrentCell.RowIndex].Cells["Nome"].Value.ToString();
                txtemail.Text = dataGridAgenda.Rows[dataGridAgenda.CurrentCell.RowIndex].Cells["Email"].Value.ToString();

            }
            catch (Exception exception)
            {

                MessageBox.Show("Ocorreu uma exceção! " + exception.Message);
                
            }

        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (verificaSeFoiSelecionadoContato())
                {

                    Contato contato = new Contato();

                    contato.id = id;
                    contato.nome = txtnome.Text;
                    contato.email = txtemail.Text;
                    
                    ContatoDAO.editaContato(contato);

                    limpaCamposEAtualizaDataGridView();


                }

            }
            catch (Exception exception)
            {

                MessageBox.Show("Ocorreu uma exceção!" + exception.Message);
                
            }
        }

       
        private void btnexcluir_Click(object sender, EventArgs e)
        {
            try
            {

                if (verificaSeFoiSelecionadoContato())
                {

                    ContatoDAO.excluiContato(id);

                    limpaCamposEAtualizaDataGridView();           

                }

            }
            catch (Exception exception)
            {

                MessageBox.Show("Ocorreu uma exceção " + exception.Message);

            }
        }

        public static bool verificaSeFoiSelecionadoContato() {


            if (id == -1)
            {

                MessageBox.Show("Não foi selecionado nenhum contato!");
                return false;

            }

            return true;

        }

        private void limpaCamposEAtualizaDataGridView()
        {

            Utils.Utils.atualizaDataGridView(dataGridAgenda);

            Utils.Utils.limpaCampos(txtnome, txtemail);

            //define id como valor padrão -1 para que não ocorra uma inconsistência caso o usuário clique duas vezes em um botão
            id = -1;

        }

        private void btnatualizar_Click(object sender, EventArgs e)
        {

            limpaCamposEAtualizaDataGridView();

        }

        public static bool verificaSeOsCamposEstaoVazios(TextBox txtnome, TextBox txtemail) 
        {

            if (String.IsNullOrEmpty(txtnome.Text) || String.IsNullOrEmpty(txtemail.Text))
            {
                MessageBox.Show("Por favor, insira o nome e email!");
                return false;
            }

            return true;
        
        }

        private void dataGridAgenda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}
