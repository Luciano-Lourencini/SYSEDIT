using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using cl_models;
using cl_bll;

namespace wfaSysEdit
{
    public partial class frmAutoresEditar : Form
    {
        private bool IsNull(TextBox txt)
        {
            if (txt.Text.Trim().Length == 0)
                return true;
            else
                return false;
        }
        
        public frmAutoresEditar()
        {
            InitializeComponent();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if(!(IsNull(txtAutID)))
            {
                if(!(IsNull(txtNome)))
                {
                    if (!(IsNull(txtPseud)))
                    {
                        try
                        {
                            clsAutores parAutores = new clsAutores();

                            parAutores.Codigo = int.Parse(txtAutID.Text);
                            parAutores.Nome = txtNome.Text;
                            parAutores.Pseudonimo = txtPseud.Text;
                            parAutores.Observacoes = txtObs.Text;

                            clsAutoresBLL autoresBLL = new clsAutoresBLL();
                            autoresBLL.Editar(parAutores);
                            MessageBox.Show("Autor Editado com Sucesso!");

                            txtAutID.Clear();
                            txtNome.Text = String.Empty;
                            txtObs.Text = "";
                            txtPseud.Clear();

                            txtAutID.Enabled = false;
                            txtNome.Enabled = false;
                            txtPseud.Enabled = false;
                            txtObs.Enabled = false;
                            btnEditar.Enabled = false;
                            btnLimpar.Enabled = false;
                            btnApagarAutor.Enabled = false;

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
                MessageBox.Show("Faltam dados para completar a edição!","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);
                
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmAutoresPesquisar autoresPesquisar = new frmAutoresPesquisar();
            autoresPesquisar.ShowDialog();

            if(autoresPesquisar.parAutores.Codigo >= 0)  //pq setei como -1 para se não selecionar nada (se ñ selecionar nada = -1)
            {
                txtAutID.Text = autoresPesquisar.parAutores.Codigo.ToString();
                txtNome.Text = autoresPesquisar.parAutores.Nome.ToString();
                txtPseud.Text = autoresPesquisar.parAutores.Pseudonimo.ToString();
                txtObs.Text = autoresPesquisar.parAutores.Observacoes.ToString();

                txtAutID.Enabled = true;
                txtAutID.ReadOnly = true;
                txtNome.Enabled = true;
                txtPseud.Enabled = true;
                txtObs.Enabled = true;
                btnEditar.Enabled = true;
                btnLimpar.Enabled = true;
                btnApagarAutor.Enabled = true;
            }
        }

        private void btnApagarAutor_Click(object sender, EventArgs e)
        {
            if (txtAutID.Text.Trim().Length == 0)
            {
                MessageBox.Show("Insira o código do Autor!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if ((MessageBox.Show("Você REALMENTE deseja apagar esse Autor?", "Confirmação", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)) == DialogResult.OK)
                {
                    try
                    {
                        clsAutores parAutores = new clsAutores();
                        parAutores.Codigo = int.Parse(txtAutID.Text);

                        clsAutoresBLL autoresBLL = new clsAutoresBLL();
                        autoresBLL.Apagar(parAutores);
                        MessageBox.Show("Autor Apagado!");

                        clsLimpar.Limpar(txtAutID);
                        clsLimpar.Limpar(txtNome);
                        clsLimpar.Limpar(txtObs);
                        clsLimpar.Limpar(txtPseud);

                        txtAutID.Enabled = false;
                        txtNome.Enabled = false;
                        txtPseud.Enabled = false;
                        txtObs.Enabled = false;
                        btnEditar.Enabled = false;
                        btnLimpar.Enabled = false;
                        btnApagarAutor.Enabled = false;

                        btnPesquisar.Focus();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        btnApagarAutor.Focus();
                    }
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            clsLimpar.Limpar(txtAutID);
            clsLimpar.Limpar(txtNome);
            clsLimpar.Limpar(txtObs);
            clsLimpar.Limpar(txtPseud);

            txtAutID.Enabled = false;
            txtNome.Enabled = false;
            txtPseud.Enabled = false;
            txtObs.Enabled = false;
            btnEditar.Enabled = false;
            btnLimpar.Enabled = false;
            btnApagarAutor.Enabled = false;

            btnPesquisar.Focus();
        }
    }
}