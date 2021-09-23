using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using cl_dal;
using cl_models;

namespace wfaSysEdit
{
    public partial class frmAutoresPesquisar : Form
    {
        public clsAutores parAutores = new clsAutores();  //vai receber os dados da pesquisa

        private void carregarGridAutores()  //método que carrega os dados
        {
            clsAutoresDAL parAutores = new clsAutoresDAL();  //inicializa a variável

            dgEstados.AutoGenerateColumns = true;  //para gerar as colunas de forma automática
            dgEstados.DataSource = parAutores.ListarTodos();
        }

        public frmAutoresPesquisar()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            int vI = 0;  //valor índice da linha (código da linha)
            vI = dgEstados.CurrentRow.Index;   //O índice da linha recebe o código da linha selecionada
                           //linha atual

                                           //coluna 0  //linha atual (selecionada)
            parAutores.Codigo = int.Parse(dgEstados[0, vI].Value.ToString());
            parAutores.Nome = dgEstados[1, vI].Value.ToString();
            parAutores.Pseudonimo = dgEstados[2, vI].Value.ToString();
            parAutores.Observacoes = dgEstados[3, vI].Value.ToString();

            this.Close();  //vai fechar para abrir a tela de editar com os valores
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            carregarGridAutores();
        }

        private void frmAutoresPesquisar_Load(object sender, EventArgs e)
        {
            parAutores.Codigo = -1;  //serve pra validar se vai selecionar algo ou não
            carregarGridAutores();  //para abrir automaticamente quando abrir a tela
        }
    }
}