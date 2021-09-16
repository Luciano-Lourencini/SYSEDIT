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
    public partial class frmEditorasEditar : Form
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

        public frmEditorasEditar()
        {
            InitializeComponent();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if(!(IsNull(txtEdiID)))
            {
                if(!(IsNull(txtNome)))
                {
                    if(!(IsNull(txtSigla)))
                    {
                        try
                        {
                            clsEditoras parEditoras = new clsEditoras();

                            parEditoras.Codigo = int.Parse(txtEdiID.Text);
                            parEditoras.Nome = txtNome.Text;
                            parEditoras.Sigla = txtSigla.Text;
                            parEditoras.Observacoes = txtObs.Text;

                            clsEditorasDAL editorasDAL = new clsEditorasDAL();
                            editorasDAL.Editar(parEditoras);
                            MessageBox.Show("Editado com sucesso!");

                            Limpar(txtEdiID);
                            Limpar(txtNome);
                            Limpar(txtObs);
                            Limpar(txtSigla);

                            txtEdiID.Focus();
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show(ex.Message);

                            Limpar(txtEdiID);
                            Limpar(txtNome);
                            Limpar(txtObs);
                            Limpar(txtSigla);

                            txtEdiID.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Faltam dados para completar a edição!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Faltam dados para completar a edição!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Faltam dados para completar a edição!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}