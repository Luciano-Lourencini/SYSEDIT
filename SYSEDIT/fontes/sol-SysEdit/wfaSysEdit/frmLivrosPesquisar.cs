using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using cl_bll;
using cl_models;

namespace wfaSysEdit
{
    public partial class frmLivrosPesquisar : Form
    {
        public clsLivros parLivros = new clsLivros();

        private void carregarGrid()
        {
            clsLivrosBLL livrosBLL = new clsLivrosBLL();
            dgLivros.AutoGenerateColumns = true;
            dgLivros.DataSource = livrosBLL.listarTodos();
            formatarGrid();
        }

        public frmLivrosPesquisar()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            try
            {
                int vI = 0;
                vI = int.Parse(dgLivros.CurrentRow.Index.ToString());

                parLivros.Codigo = int.Parse(dgLivros[0, vI].Value.ToString());
                parLivros.Nome = dgLivros[1, vI].Value.ToString();
                parLivros.AnoPublicacao = int.Parse(dgLivros[2, vI].Value.ToString());
                parLivros.ISBN = double.Parse(dgLivros[3, vI].Value.ToString());
                parLivros.Observacoes = dgLivros[4, vI].Value.ToString();
                parLivros.EditoraCodigo = int.Parse(dgLivros[5, vI].Value.ToString());

                this.Close();
            }
            catch(Exception ex)
            {
                clsMensagens.Mensagem(ex.Message, clsMensagens.tipoMensagem.erro);
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            carregarGrid();
        }

        private void frmLivrosPesquisar_Load(object sender, EventArgs e)
        {
            carregarGrid();
            parLivros.Codigo = -1;
        }

        private void formatarGrid()
        {
            dgLivros.ReadOnly = true;
            dgLivros.MultiSelect = false;

            dgLivros.Columns[0].HeaderText = "Código";
            dgLivros.Columns[1].HeaderText = "Nome";
            dgLivros.Columns[2].HeaderText = "Ano de Publicação";
            dgLivros.Columns[3].HeaderText = "ISBN";
            dgLivros.Columns[4].HeaderText = "Observações";
            dgLivros.Columns[5].HeaderText = "Código da Editora";
        }
    }
}