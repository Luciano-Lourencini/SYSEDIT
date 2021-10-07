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
    public partial class frmAutoresNovo : Form
    {
        private bool IsNull(TextBox txt)
        {
            if (txt.Text.Trim().Length == 0)
                return true;
            else
                return false;
        }

        public frmAutoresNovo()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(!(IsNull(txtNome)))
            {
                if(!(IsNull(txtPseud)))
                {
                    try
                    {
                        clsAutores parAutores = new clsAutores();

                        parAutores.Nome = txtNome.Text;
                        parAutores.Pseudonimo = txtPseud.Text;
                        parAutores.Observacoes = txtObs.Text;

                        clsAutoresBLL autoresBLL = new clsAutoresBLL();
                        autoresBLL.Salvar(parAutores);

                        MessageBox.Show("Autor Salvo com Sucesso!");

                        txtNome.Text = String.Empty;
                        txtObs.Clear();
                        txtPseud.Text = "";

                        txtNome.Focus();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Preencher todos os itens!","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Preencher todos os itens!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}