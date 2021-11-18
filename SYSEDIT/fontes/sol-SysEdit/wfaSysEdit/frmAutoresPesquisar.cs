using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using cl_models;
using cl_bll;

namespace wfaSysEdit
{
    public partial class frmAutoresPesquisar : Form
    {
        private bool entrouCelula = false;

        clsAutoresBLL parAutoresBLL = new clsAutoresBLL();  //inicializa a variável
        public clsAutores parAutores = new clsAutores();  //vai receber os dados da pesquisa

        private void filtrarGrid()
        {
            DataTable dt = parAutoresBLL.listarTodos();
            dt.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", "AutNome",txtBuscarNome.Text);
            dgAutores.DataSource = dt.DefaultView;
        }

        private void carregarGrid()  //método que carrega os dados
        {
            try
            {
                dgAutores.AutoGenerateColumns = true;  //para gerar as colunas de forma automática
                dgAutores.DataSource = parAutoresBLL.listarTodos();     //dg = data grid
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
            if(entrouCelula == true)
            {
                try
                {
                    int vI = 0;  //valor índice da linha (código da linha)
                    vI = dgAutores.CurrentRow.Index;   //O índice da linha recebe o código da linha selecionada
                                                       //linha atual

                    //coluna 0  //linha atual (selecionada)
                    parAutores.Codigo = int.Parse(dgAutores[0, vI].Value.ToString());
                    parAutores.Nome = dgAutores[1, vI].Value.ToString();
                    parAutores.Pseudonimo = dgAutores[2, vI].Value.ToString();
                    parAutores.Observacoes = dgAutores[3, vI].Value.ToString();

                    this.Close();  //vai fechar para abrir a tela de editar com os valores
                }
                catch (Exception ex)
                {
                    clsMensagens.Mensagem(ex.Message, clsMensagens.tipoMensagem.erro);
                }
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            carregarGrid();
            formatarGrid();
        }

        private void frmAutoresPesquisar_Load(object sender, EventArgs e)
        {
            parAutores.Codigo = -1;  //serve pra validar se vai selecionar algo ou não
            carregarGrid();  //para abrir automaticamente quando abrir a tela
            formatarGrid();
        }

        private void formatarGrid()
        {
            dgAutores.ReadOnly = true;
            dgAutores.MultiSelect = false; //selecionar vários

            dgAutores.ScrollBars = ScrollBars.Vertical;  //só vai ter scroll vertical

            //dgAutores.Columns[0].HeaderText = "Código";
            dgAutores.Columns[1].HeaderText = "Nome";
            dgAutores.Columns[2].HeaderText = "Pseudônimo";
            dgAutores.Columns[3].HeaderText = "Observações";

            dgAutores.Columns[0].Visible = false;

            //dgAutores.Columns[0].Width = 50;
        }

        private void dgAutores_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            entrouCelula = true;
        }

        private void txtBuscarNome_KeyUp(object sender, KeyEventArgs e)
        {
            filtrarGrid();
        }
    }
}