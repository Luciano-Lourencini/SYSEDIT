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
    public partial class frmUsuariosEditar : Form
    {
        public frmUsuariosEditar()
        {
            InitializeComponent();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if( !(clsIsNull.IsNull(txtCPF,txtEmail)) && !(clsIsNull.IsNull(txtNome, txtObs)) && !(clsIsNull.IsNull(txtSenha, txtTelefone) && !(clsIsNull.IsNull(txtId))) )
            {
                try
                {
                    clsUsuarios parUsuarios = new clsUsuarios();

                    parUsuarios.Codigo = int.Parse(txtId.Text);
                    parUsuarios.CPF = double.Parse(txtCPF.Text);
                    parUsuarios.Nome = txtNome.Text;
                    parUsuarios.Senha = txtSenha.Text;
                    parUsuarios.Email = txtEmail.Text;
                    parUsuarios.Telefone = double.Parse(txtTelefone.Text);
                    parUsuarios.Observacoes = txtObs.Text;

                    clsUsuariosDAL usuariosDAL = new clsUsuariosDAL();
                    usuariosDAL.Editar(parUsuarios);

                    clsMensagens.Mensagem("Usuário editado com sucesso!", clsMensagens.tipoMensagem.sucesso);

                    clsLimpar.Limpar(txtCPF);
                    clsLimpar.Limpar(txtEmail);
                    clsLimpar.Limpar(txtId);
                    clsLimpar.Limpar(txtNome);
                    clsLimpar.Limpar(txtObs);
                    clsLimpar.Limpar(txtSenha);
                    clsLimpar.Limpar(txtTelefone);

                    gpEditar.Enabled = false;
                    btnApagar.Enabled = false;
                    btnEditar.Enabled = false;

                    btnPesquisar.Focus();
                }
                catch (Exception ex)
                {
                    clsMensagens.Mensagem(ex.Message, clsMensagens.tipoMensagem.erro);
                    btnEditar.Focus();
                }
            }
            else
            {
                clsMensagens.Mensagem("Está faltando um ou mais campos!", clsMensagens.tipoMensagem.aviso);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmUsuariosPesquisar usuariosPesquisar = new frmUsuariosPesquisar();
            usuariosPesquisar.ShowDialog();

            if(usuariosPesquisar.parUsuarios.Codigo >= 0)
            {
                txtId.Text = usuariosPesquisar.parUsuarios.Codigo.ToString();
                txtCPF.Text = usuariosPesquisar.parUsuarios.CPF.ToString();
                txtNome.Text = usuariosPesquisar.parUsuarios.Nome;
                txtSenha.Text = usuariosPesquisar.parUsuarios.Senha;
                txtEmail.Text = usuariosPesquisar.parUsuarios.Email;
                txtTelefone.Text = usuariosPesquisar.parUsuarios.Telefone.ToString();
                txtObs.Text = usuariosPesquisar.parUsuarios.Observacoes;

                gpEditar.Enabled = true;
                btnApagar.Enabled = true;
                btnEditar.Enabled = true;
            }
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (!(clsIsNull.IsNull(txtId)))
            {
                try
                {
                    if (MessageBox.Show("Tem certeza que quer apagar o usuário?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        clsUsuarios parUsuarios = new clsUsuarios();
                        parUsuarios.Codigo = int.Parse(txtId.Text);

                        clsUsuariosDAL usuariosDAL = new clsUsuariosDAL();
                        usuariosDAL.Apagar(parUsuarios);

                        clsLimpar.Limpar(txtId);
                        txtId.Focus();

                        clsMensagens.Mensagem("Usuário excluído com sucesso!", clsMensagens.tipoMensagem.sucesso);

                        clsLimpar.Limpar(txtCPF);
                        clsLimpar.Limpar(txtEmail);
                        clsLimpar.Limpar(txtId);
                        clsLimpar.Limpar(txtNome);
                        clsLimpar.Limpar(txtObs);
                        clsLimpar.Limpar(txtSenha);
                        clsLimpar.Limpar(txtTelefone);

                        gpEditar.Enabled = false;
                        btnApagar.Enabled = false;
                        btnEditar.Enabled = false;

                        btnPesquisar.Focus();
                    }
                    else
                        btnApagar.Focus();

                }
                catch (Exception ex)
                {
                    clsMensagens.Mensagem(ex.Message, clsMensagens.tipoMensagem.erro);
                    btnApagar.Focus();
                }
            }
            else
            {
                clsMensagens.Mensagem("Campo CÓDIGO não preenchido!", clsMensagens.tipoMensagem.aviso);
                btnApagar.Focus();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            clsLimpar.Limpar(txtCPF);
            clsLimpar.Limpar(txtEmail);
            clsLimpar.Limpar(txtId);
            clsLimpar.Limpar(txtNome);
            clsLimpar.Limpar(txtObs);
            clsLimpar.Limpar(txtSenha);
            clsLimpar.Limpar(txtTelefone);

            gpEditar.Enabled = false;
            btnApagar.Enabled = false;
            btnEditar.Enabled = false;

            btnPesquisar.Focus();
        }
    }
}