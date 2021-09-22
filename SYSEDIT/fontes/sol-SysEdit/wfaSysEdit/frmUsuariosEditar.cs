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

                    txtId.Focus();
                }
                catch (Exception ex)
                {
                    clsMensagens.Mensagem(ex.Message, clsMensagens.tipoMensagem.erro);
                }
            }
            else
            {
                clsMensagens.Mensagem("Está faltando um ou mais campos!", clsMensagens.tipoMensagem.aviso);
            }
        }
    }
}