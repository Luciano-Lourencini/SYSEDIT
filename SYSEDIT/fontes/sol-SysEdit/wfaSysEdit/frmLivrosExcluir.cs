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
    public partial class frmLivrosExcluir : Form
    {
        public frmLivrosExcluir()
        {
            InitializeComponent();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            txtLivID.Focus(); //deixa o cursor na TextBox (não precisava na situação, mas...)

            if(txtLivID.Text.Trim().Length == 0)
            {
                MessageBox.Show("Para excluir um livro, deve-se colocar o código do mesmo!","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);
                txtLivID.Focus();
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

                    txtLivID.Text = string.Empty;
                    txtLivID.Focus();
                }
            }
        }
    }
}