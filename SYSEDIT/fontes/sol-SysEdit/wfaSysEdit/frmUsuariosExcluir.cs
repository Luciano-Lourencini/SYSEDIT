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
    public partial class frmUsuariosExcluir : Form
    {
        public frmUsuariosExcluir()
        {
            InitializeComponent();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if(!(clsIsNull.IsNull(txtUserId)))
            {
                try
                {
                    if (MessageBox.Show("Tem certeza que quer apagar o usuário?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        clsUsuarios parUsuarios = new clsUsuarios();
                        parUsuarios.Codigo = int.Parse(txtUserId.Text);

                        clsUsuariosDAL usuariosDAL = new clsUsuariosDAL();
                        usuariosDAL.Apagar(parUsuarios);

                        clsLimpar.Limpar(txtUserId);
                        txtUserId.Focus();

                        clsMensagens.Mensagem("Usuário excluído com sucesso!", clsMensagens.tipoMensagem.sucesso);
                    }
                    else
                        txtUserId.Focus();

                }
                catch(Exception ex)
                {
                    clsMensagens.Mensagem(ex.Message, clsMensagens.tipoMensagem.erro);
                }
            }
            else
            {
                clsMensagens.Mensagem("Campo CÓDIGO não preenchido!",clsMensagens.tipoMensagem.aviso);
            }
        }
    }
}