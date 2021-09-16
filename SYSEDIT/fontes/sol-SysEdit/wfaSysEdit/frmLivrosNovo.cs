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
    public partial class frmLivrosNovo : Form
    {
        public bool IsNull(TextBox txt)
        {
            if (txt.Text.Trim().Length == 0)
                return true;
            else
                return false;
        }

        public void Apagar(TextBox txt)
        {
            txt.Text = "";
        }

        public frmLivrosNovo()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(!(IsNull(txtAnoPubli)))
            {
                if (!(IsNull(txtEdiID)))
                {
                    if (!(IsNull(txtISBN)))
                    {
                        if (!(IsNull(txtNome)))
                        {
                            try
                            {
                                clsLivros parLivros = new clsLivros();

                                parLivros.Nome = txtNome.Text;
                                parLivros.AnoPublicacao = int.Parse(txtAnoPubli.Text);
                                parLivros.ISBN = double.Parse(txtISBN.Text);
                                parLivros.Observacoes = txtObs.Text;
                                parLivros.EditoraCodigo = int.Parse(txtEdiID.Text);

                                clsLivrosDAL livrosDAL = new clsLivrosDAL();
                                livrosDAL.Salvar(parLivros);

                                MessageBox.Show("Livro cadastrado com sucesso!");

                                Apagar(txtAnoPubli);
                                Apagar(txtEdiID);
                                Apagar(txtISBN);
                                Apagar(txtNome);
                                Apagar(txtObs);

                                txtNome.Focus();
                            }
                            catch(Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                                txtNome.Focus();
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