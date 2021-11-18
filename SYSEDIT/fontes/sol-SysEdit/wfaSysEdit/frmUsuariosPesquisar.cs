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
    public partial class frmUsuariosPesquisar : Form
    {
        private bool entrouCelula = false;
        public clsUsuarios parUsuarios = new clsUsuarios();
        private clsUsuariosBLL usuariosBLL = new clsUsuariosBLL();

        private void filtrarGrid()
        {
            DataTable dt = usuariosBLL.listarTodos();
            dt.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", "UserNome",txtBuscarNome.Text);
            dgUsuarios.DataSource = dt.DefaultView;
        }

        private void carregarGrid()
        {
            try
            {
                dgUsuarios.AutoGenerateColumns = true;
                dgUsuarios.DataSource = usuariosBLL.listarTodos();
                formatarGrid();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public frmUsuariosPesquisar()
        {
            InitializeComponent();
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            if (entrouCelula == true)
            {
                try
                {
                    int vI = 0;
                    vI = int.Parse(dgUsuarios.CurrentRow.Index.ToString());

                    parUsuarios.Codigo = int.Parse(dgUsuarios[0, vI].Value.ToString());
                    parUsuarios.CPF = double.Parse(dgUsuarios[1, vI].Value.ToString());
                    parUsuarios.Nome = dgUsuarios[2, vI].Value.ToString();
                    parUsuarios.Senha = dgUsuarios[3, vI].Value.ToString();
                    parUsuarios.Email = dgUsuarios[4, vI].Value.ToString();
                    parUsuarios.Telefone = double.Parse(dgUsuarios[5, vI].Value.ToString());
                    parUsuarios.Observacoes = dgUsuarios[6, vI].Value.ToString();

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

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUsuariosPesquisar_Load(object sender, EventArgs e)
        {
            carregarGrid();
            parUsuarios.Codigo = -1;
        }

        private void formatarGrid()
        {
            dgUsuarios.ReadOnly = true;
            dgUsuarios.MultiSelect = false;

            //dgUsuarios.Columns[0].HeaderText = "Código";
            dgUsuarios.Columns[1].HeaderText = "CPF";
            dgUsuarios.Columns[2].HeaderText = "Nome";
            dgUsuarios.Columns[3].HeaderText = "Senha"; //tinha tirado por proteção, mas vai puxar na tela de qualquer jeito...
            dgUsuarios.Columns[4].HeaderText = "Email";
            dgUsuarios.Columns[5].HeaderText = "Telefone";
            dgUsuarios.Columns[6].HeaderText = "Observação";

            dgUsuarios.Columns[0].Visible = false;
            //dgUsuarios.Columns[3].Visible = false;
        }

        private void dgUsuarios_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            entrouCelula = true;
        }

        private void txtBuscarNome_KeyUp(object sender, KeyEventArgs e)
        {
            filtrarGrid();
        }
    }
}