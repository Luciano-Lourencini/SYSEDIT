using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaSysEdit
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void novoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmEditorasNovo editorasNovo = new frmEditorasNovo();
            editorasNovo.ShowDialog();
        }

        private void buscarEditarApagarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditorasEditar editorasEditar = new frmEditorasEditar();
            editorasEditar.ShowDialog();
        }

        private void tsCadastrar_Click(object sender, EventArgs e)
        {
            frmAutoresNovo autoresNovo = new frmAutoresNovo();
            autoresNovo.ShowDialog();
        }

        private void tsBuscarEditarApagar_Click(object sender, EventArgs e)
        {
            frmAutoresEditar autoresEditar = new frmAutoresEditar();
            autoresEditar.ShowDialog();
        }

        private void novoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmUsuariosNovo usuariosNovo = new frmUsuariosNovo();
            usuariosNovo.ShowDialog();
        }

        private void buscarEditarApagarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmUsuariosEditar usuariosEditar = new frmUsuariosEditar();
            usuariosEditar.ShowDialog();
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLivrosNovo livrosNovo = new frmLivrosNovo();
            livrosNovo.ShowDialog();
        }

        private void buscarEditarApagarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmLivrosEditar livrosEditar = new frmLivrosEditar();
            livrosEditar.ShowDialog();
        }

        private void tmPrincipal_Tick(object sender, EventArgs e)
        {
            tsslblTimer.Text = DateTime.Now.ToString();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.ShowDialog();

            if(login.acessoPermitido == false)
            {
                this.Close();
            }
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSobre sobre = new frmSobre();
            sobre.ShowDialog();
        }
    }
}