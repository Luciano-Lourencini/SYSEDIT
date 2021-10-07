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
    public partial class frmUsuariosNovo : Form
    {
        public bool IsNull(TextBox txt)
        {
            if (txt.Text.Trim().Length == 0)
                return true;
            else
                return false;
        }

        public void Limpar(TextBox txt)
        {
            txt.Text = "";
        }

        public frmUsuariosNovo()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(!(IsNull(txtCPF)) && !(IsNull(txtEmail)) && !(IsNull(txtNome)) && !(IsNull(txtObs)) && !(IsNull(txtSenha)) && !(IsNull(txtTelefone)))
            {
                try
                {

                    clsUsuarios parUsuarios = new clsUsuarios();

                    parUsuarios.CPF = double.Parse(txtCPF.Text);
                    parUsuarios.Nome = txtNome.Text;
                    parUsuarios.Senha = txtSenha.Text;
                    parUsuarios.Email = txtEmail.Text;
                    parUsuarios.Telefone = double.Parse(txtTelefone.Text);
                    parUsuarios.Observacoes = txtObs.Text;

                    clsUsuariosBLL usuariosBLL = new clsUsuariosBLL();
                    usuariosBLL.Salvar(parUsuarios);

                    clsMensagens.Mensagem("Usuário cadastrado com sucesso!", clsMensagens.tipoMensagem.sucesso);

                    clsLimpar.Limpar(txtCPF);
                    clsLimpar.Limpar(txtEmail);
                    clsLimpar.Limpar(txtNome);
                    clsLimpar.Limpar(txtObs);
                    clsLimpar.Limpar(txtSenha);
                    clsLimpar.Limpar(txtTelefone);

                    txtCPF.Focus();
                }
                catch (Exception ex)
                {
                    clsMensagens.Mensagem(ex.Message,clsMensagens.tipoMensagem.erro);
                }
            }
            else
            {
                clsMensagens.Mensagem("Está faltando um ou mais campos!", clsMensagens.tipoMensagem.aviso);
            }
        }
    }
}