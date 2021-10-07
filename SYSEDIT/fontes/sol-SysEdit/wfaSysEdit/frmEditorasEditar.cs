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

                            clsEditorasBLL editorasBLL = new clsEditorasBLL();
                            editorasBLL.Editar(parEditoras);
                            MessageBox.Show("Editado com sucesso!");

                            clsLimpar.Limpar(txtEdiID);
                            clsLimpar.Limpar(txtNome);
                            clsLimpar.Limpar(txtSigla);
                            clsLimpar.Limpar(txtObs);

                            txtEdiID.Enabled = false;
                            txtNome.Enabled = false;
                            txtObs.Enabled = false;
                            txtSigla.Enabled = false;
                            btnApagar.Enabled = false;
                            btnEditar.Enabled = false;
                            btnLimpar.Enabled = false;

                            btnPesquisar.Focus();
                        }
                        catch(Exception ex)
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

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmEditorasPesquisar editorasPesquisar = new frmEditorasPesquisar();
            editorasPesquisar.ShowDialog();

            if(editorasPesquisar.parEditoras.Codigo >= 0)
            {
                txtEdiID.Text = editorasPesquisar.parEditoras.Codigo.ToString();
                txtNome.Text = editorasPesquisar.parEditoras.Nome;
                txtSigla.Text = editorasPesquisar.parEditoras.Sigla;
                txtObs.Text = editorasPesquisar.parEditoras.Observacoes;

                txtEdiID.Enabled = true;
                txtEdiID.ReadOnly = true;
                txtNome.Enabled = true;
                txtObs.Enabled = true;
                txtSigla.Enabled = true;
                btnApagar.Enabled = true;
                btnEditar.Enabled = true;
                btnLimpar.Enabled = true;
            }
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (txtEdiID.Text.Trim().Length == 0)
            {
                MessageBox.Show("Insira o código do Autor!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEdiID.Focus();
            }
            else
            {
                if ((MessageBox.Show("Você REALMENTE deseja apagar essa Editora?", "Confirmação", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)) == DialogResult.OK)
                {
                    try
                    {
                        clsEditoras parEditoras = new clsEditoras();
                        parEditoras.Codigo = int.Parse(txtEdiID.Text);

                        clsEditorasBLL editorasBLL = new clsEditorasBLL();
                        editorasBLL.Apagar(parEditoras);
                        MessageBox.Show("Editora Apagada!");

                        clsLimpar.Limpar(txtEdiID);
                        clsLimpar.Limpar(txtNome);
                        clsLimpar.Limpar(txtSigla);
                        clsLimpar.Limpar(txtObs);

                        txtEdiID.Enabled = false;
                        txtNome.Enabled = false;
                        txtObs.Enabled = false;
                        txtSigla.Enabled = false;
                        btnApagar.Enabled = false;
                        btnEditar.Enabled = false;
                        btnLimpar.Enabled = false;

                        btnPesquisar.Focus();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);

                        btnApagar.Focus();
                    }

                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            clsLimpar.Limpar(txtEdiID);
            clsLimpar.Limpar(txtNome);
            clsLimpar.Limpar(txtSigla);
            clsLimpar.Limpar(txtObs);

            txtEdiID.Enabled = false;
            txtNome.Enabled = false;
            txtObs.Enabled = false;
            txtSigla.Enabled = false;
            btnApagar.Enabled = false;
            btnEditar.Enabled = false;
            btnLimpar.Enabled = false;

            btnPesquisar.Focus();
        }
    }
}