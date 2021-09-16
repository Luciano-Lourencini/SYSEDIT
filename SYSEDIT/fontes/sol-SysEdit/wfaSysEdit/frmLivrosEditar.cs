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
    public partial class frmLivrosEditar : Form
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

        public frmLivrosEditar()
        {
            InitializeComponent();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if(!(IsNull(txtEdiID)))
            {
                if (!(IsNull(txtNome)))
                {
                    if (!(IsNull(txtAnoPubli)))
                    {
                        if (!(IsNull(txtISBN)))
                        {
                            if (!(IsNull(txtLivID)))
                            {
                                try
                                {
                                    clsLivros parLivros = new clsLivros();

                                    parLivros.Codigo = int.Parse(txtLivID.Text);
                                    parLivros.Nome = txtNome.Text;
                                    parLivros.AnoPublicacao = int.Parse(txtAnoPubli.Text);
                                    parLivros.ISBN = double.Parse(txtISBN.Text);
                                    parLivros.EditoraCodigo = int.Parse(txtEdiID.Text);
                                    parLivros.Observacoes = txtObs.Text;

                                    clsLivrosDAL livrosDAL = new clsLivrosDAL();
                                    livrosDAL.Editar(parLivros);

                                    MessageBox.Show("Editado com Sucesso!");

                                    Limpar(txtAnoPubli);
                                    Limpar(txtEdiID);
                                    Limpar(txtISBN);
                                    Limpar(txtLivID);
                                    Limpar(txtNome);
                                    Limpar(txtObs);

                                    txtLivID.Focus();

                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message);
                                    txtLivID.Focus();
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