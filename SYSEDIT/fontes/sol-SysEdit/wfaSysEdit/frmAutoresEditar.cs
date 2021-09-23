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

                            clsAutoresDAL autoresDAL = new clsAutoresDAL();
                            autoresDAL.Editar(parAutores);
                            MessageBox.Show("Autor Editado com Sucesso!");

                            txtAutID.Clear();
                            txtNome.Text = String.Empty;
                            txtObs.Text = "";
                            txtPseud.Clear();
                            txtAutID.Focus();
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show(ex.Message);
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

            txtAutID.Enabled = true;
            txtNome.Enabled = true;
            txtPseud.Enabled = true;
            txtObs.Enabled = true;

            if(autoresPesquisar.parAutores.Codigo >= 0)  //pq setei como -1 para se não selecionar nada (se ñ selecionar nada = -1)
            {
                txtAutID.Text = autoresPesquisar.parAutores.Codigo.ToString();
                txtNome.Text = autoresPesquisar.parAutores.Nome.ToString();
                txtPseud.Text = autoresPesquisar.parAutores.Pseudonimo.ToString();
                txtObs.Text = autoresPesquisar.parAutores.Observacoes.ToString();
            }
        }
    }
}