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
        private bool entrouCelula = false;
        public clsLivros parLivros = new clsLivros();
        clsLivrosBLL livrosBLL = new clsLivrosBLL();

        private void filtrarGrid()
        {
            DataTable dt = livrosBLL.listarTodos();
            dt.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", "LivNome", txtBuscarNome.Text);
            dgLivros.DataSource = dt.DefaultView;
        }

        private void carregarGrid()
        {
            try
            {
                dgLivros.AutoGenerateColumns = true;
                dgLivros.DataSource = livrosBLL.listarTodos();
                formatarGrid();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
            if(entrouCelula == true)
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
                catch (Exception ex)
                {
                    clsMensagens.Mensagem(ex.Message, clsMensagens.tipoMensagem.erro);
                }
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

            //dgLivros.Columns[0].HeaderText = "Código";
            dgLivros.Columns[1].HeaderText = "Nome";
            dgLivros.Columns[2].HeaderText = "Ano de Publicação";
            dgLivros.Columns[3].HeaderText = "ISBN";
            dgLivros.Columns[4].HeaderText = "Observações";
            dgLivros.Columns[5].HeaderText = "Código da Editora";

            dgLivros.Columns[0].Visible = false;
        }

        private void dgLivros_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            entrouCelula = true;
        }

        private void txtBuscarNome_KeyUp(object sender, KeyEventArgs e)
        {
            filtrarGrid();
        }
    }
}