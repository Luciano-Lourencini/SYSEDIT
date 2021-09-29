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
    public partial class frmUsuariosPesquisar : Form
    {
        public clsUsuarios parUsuarios = new clsUsuarios();

        private void carregarGrid()
        {
            clsUsuariosDAL usuariosDAL = new clsUsuariosDAL();
            dgUsuarios.AutoGenerateColumns = true;
            dgUsuarios.DataSource = usuariosDAL.listarTodos();
            formatarGrid();
        }

        public frmUsuariosPesquisar()
        {
            InitializeComponent();
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
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
            catch(Exception ex)
            {
                clsMensagens.Mensagem(ex.Message, clsMensagens.tipoMensagem.erro);
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

            dgUsuarios.Columns[0].HeaderText = "Código";
            dgUsuarios.Columns[1].HeaderText = "CPF";
            dgUsuarios.Columns[2].HeaderText = "Nome";
            dgUsuarios.Columns[3].HeaderText = "Senha"; //tinha tirado por proteção, mas vai puxar na tela de qualquer jeito...
            dgUsuarios.Columns[4].HeaderText = "Email";
            dgUsuarios.Columns[5].HeaderText = "Telefone";
            dgUsuarios.Columns[6].HeaderText = "Observação";

            //dgUsuarios.Columns[3].Visible = false;
        }
    }
}