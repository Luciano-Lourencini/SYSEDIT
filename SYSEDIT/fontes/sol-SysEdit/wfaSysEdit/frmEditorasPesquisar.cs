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
        private bool entrouCelula = false;
        public clsEditoras parEditoras = new clsEditoras();
        private clsEditorasBLL editorasBLL = new clsEditorasBLL();

        private void filtrarGrid()
        {
            DataTable dt = editorasBLL.listarTodos();
            dt.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", "EdiNome", txtBuscarNome.Text);
            dgEditoras.DataSource = dt.DefaultView;
        }

        private void carregarGrid()
        {
            try
            {
                dgEditoras.AutoGenerateColumns = true;
                dgEditoras.DataSource = editorasBLL.listarTodos();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public frmEditorasPesquisar()
        {
            InitializeComponent();
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            if(entrouCelula == true)
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
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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

        private void dgEditoras_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            entrouCelula = true;
        }

        private void txtBuscarNome_KeyUp(object sender, KeyEventArgs e)
        {
            filtrarGrid();
        }
    }
}