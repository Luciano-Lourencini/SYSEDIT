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
    public partial class frmEditorasExcluir : Form
    {
        public frmEditorasExcluir()
        {
            InitializeComponent();
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

                        clsEditorasDAL editorasDAL = new clsEditorasDAL();
                        editorasDAL.Apagar(parEditoras);
                        MessageBox.Show("Editora Apagada!");
                        txtEdiID.Clear();
                        txtEdiID.Focus();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        txtEdiID.Clear();
                        txtEdiID.Focus();
                    }

                }
            }
        }
    }
}