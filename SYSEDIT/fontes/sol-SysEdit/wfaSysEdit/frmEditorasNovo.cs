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
    public partial class frmEditorasNovo : Form
    {
        private bool IsNull(TextBox txt)
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

        public frmEditorasNovo()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(!(IsNull(txtNome)))
            {
                if(!(IsNull(txtSigla)))
                {
                    try
                    {
                        clsEditoras Editora = new clsEditoras();

                        Editora.Nome = txtNome.Text;
                        Editora.Sigla = txtSigla.Text;
                        Editora.Observacoes = txtObs.Text;


                        clsEditorasDAL editorasDAL = new clsEditorasDAL();
                        editorasDAL.Salvar(Editora);

                        MessageBox.Show("Editora Cadastrada!");

                        Limpar(txtNome);
                        Limpar(txtObs);
                        Limpar(txtSigla);

                        txtNome.Focus();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Preencher todos os itens!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Preencher todos os itens!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}