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
    public partial class frmEditorasPesquisar : Form
    {
        public clsEditoras parEditoras = new clsEditoras();

        private void carregarGrid()
        {
            clsEditorasBLL editorasBLL = new clsEditorasBLL();
            dgEditoras.AutoGenerateColumns = true;
            dgEditoras.DataSource = editorasBLL.listarTodos();
        }

        public frmEditorasPesquisar()
        {
            InitializeComponent();
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            try
            {
                int vI = 0;
                vI = dgEditoras.CurrentRow.Index;

                parEditoras.Codigo = int.Parse(dgEditoras[0, vI].Value.ToString());
                parEditoras.Nome = dgEditoras[1, vI].Value.ToString();
                parEditoras.Sigla = dgEditoras[2, vI].Value.ToString();
                parEditoras.Observacoes = dgEditoras[3, vI].Value.ToString();

                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            carregarGrid();
            formatarGrid();
        }

        private void frmEditorasPesquisar_Load(object sender, EventArgs e)
        {
            carregarGrid();
            formatarGrid();
            parEditoras.Codigo = -1;
        }

        private void formatarGrid()
        {
            dgEditoras.ReadOnly = true;
            dgEditoras.MultiSelect = false;

            dgEditoras.Columns[0].HeaderText = "Código";
            dgEditoras.Columns[1].HeaderText = "Nome";
            dgEditoras.Columns[2].HeaderText = "Sigla";
            dgEditoras.Columns[3].HeaderText = "Observações";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}