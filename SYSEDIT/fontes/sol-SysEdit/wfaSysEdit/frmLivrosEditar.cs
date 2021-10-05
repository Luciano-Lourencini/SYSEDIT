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
        private clsEditorasDAL parEditorasDAL = new clsEditorasDAL();

        private void carregarComboEditoras()
        {
            cbEdiID.DataSource = parEditorasDAL.listarTodosComboBox();
            cbEdiID.DisplayMember = "EdiSigla";
            cbEdiID.ValueMember = "EdiID";
        }

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
            if(!(cbEdiID.SelectedIndex<0))
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
                                    parLivros.EditoraCodigo = int.Parse(cbEdiID.SelectedValue.ToString());
                                    parLivros.Observacoes = txtObs.Text;

                                    clsLivrosDAL livrosDAL = new clsLivrosDAL();
                                    livrosDAL.Editar(parLivros);

                                    MessageBox.Show("Editado com Sucesso!");

                                    Limpar(txtAnoPubli);
                                    cbEdiID.SelectedIndex = -1;
                                    Limpar(txtISBN);
                                    Limpar(txtLivID);
                                    Limpar(txtNome);
                                    Limpar(txtObs);

                                    txtAnoPubli.Enabled = false;
                                    cbEdiID.Enabled = false;
                                    txtISBN.Enabled = false;
                                    txtLivID.Enabled = false;
                                    txtNome.Enabled = false;
                                    txtObs.Enabled = false;
                                    btnApagar.Enabled = false;
                                    btnEditar.Enabled = false;
                                    btnLimpar.Enabled = false;

                                    btnPesquisar.Focus();

                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message);
                                    btnEditar.Focus();
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

        private void btnApagar_Click(object sender, EventArgs e)
        {
            txtLivID.Focus(); //deixa o cursor na TextBox (não precisava na situação, mas...)

            if (txtLivID.Text.Trim().Length == 0)
            {
                MessageBox.Show("Para excluir um livro, deve-se selecionar um primeiro!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnPesquisar.Focus();
            }
            else
            {
                if ((MessageBox.Show("Você REALMENTE deseja excluir o Livro?", "Confirmação", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK))
                {
                    clsLivros parLivros = new clsLivros();
                    parLivros.Codigo = int.Parse(txtLivID.Text);

                    clsLivrosDAL livrosDAL = new clsLivrosDAL();
                    livrosDAL.Apagar(parLivros);
                    MessageBox.Show("Livro Apagado!");

                    Limpar(txtAnoPubli);
                    cbEdiID.SelectedIndex = -1;
                    Limpar(txtISBN);
                    Limpar(txtLivID);
                    Limpar(txtNome);
                    Limpar(txtObs);

                    txtAnoPubli.Enabled = false;
                    cbEdiID.Enabled = false;
                    txtISBN.Enabled = false;
                    txtLivID.Enabled = false;
                    txtNome.Enabled = false;
                    txtObs.Enabled = false;
                    btnApagar.Enabled = false;
                    btnEditar.Enabled = false;
                    btnLimpar.Enabled = false;

                    btnPesquisar.Focus();
                }
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmLivrosPesquisar livrosPesquisar = new frmLivrosPesquisar();
            livrosPesquisar.ShowDialog();

            if(livrosPesquisar.parLivros.Codigo >= 0)
            {
                txtLivID.Text = livrosPesquisar.parLivros.Codigo.ToString();
                txtNome.Text = livrosPesquisar.parLivros.Nome;
                txtAnoPubli.Text = livrosPesquisar.parLivros.AnoPublicacao.ToString();
                txtISBN.Text = livrosPesquisar.parLivros.ISBN.ToString();
                txtObs.Text = livrosPesquisar.parLivros.Observacoes;
                cbEdiID.SelectedValue = livrosPesquisar.parLivros.EditoraCodigo.ToString();

                txtAnoPubli.Enabled = true;
                cbEdiID.Enabled = true;
                txtISBN.Enabled = true;
                txtLivID.Enabled = true;
                txtNome.Enabled = true;
                txtObs.Enabled = true;
                btnApagar.Enabled = true;
                btnEditar.Enabled = true;
                btnLimpar.Enabled = true;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar(txtAnoPubli);
            cbEdiID.SelectedIndex = -1;
            Limpar(txtISBN);
            Limpar(txtLivID);
            Limpar(txtNome);
            Limpar(txtObs);

            txtAnoPubli.Enabled = false;
            cbEdiID.Enabled = false;
            txtISBN.Enabled = false;
            txtLivID.Enabled = false;
            txtNome.Enabled = false;
            txtObs.Enabled = false;
            btnApagar.Enabled = false;
            btnEditar.Enabled = false;
            btnLimpar.Enabled = false;

            btnPesquisar.Focus();
        }

        private void frmLivrosEditar_Load(object sender, EventArgs e)
        {
            carregarComboEditoras();
            cbEdiID.SelectedIndex = -1;
        }
    }
}