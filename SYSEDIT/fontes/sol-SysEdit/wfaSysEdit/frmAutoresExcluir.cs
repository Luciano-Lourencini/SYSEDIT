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
    public partial class frmAutoresExcluir : Form
    {
        public frmAutoresExcluir()
        {
            InitializeComponent();
        }

        private void btnApagarAutor_Click(object sender, EventArgs e)
        {
            if(txtAutID.Text.Trim().Length == 0)
            {
                MessageBox.Show("Insira o código do Autor!","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                if ((MessageBox.Show("Você REALMENTE deseja apagar esse Autor?", "Confirmação", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)) == DialogResult.OK)
                {
                    try
                    {
                        clsAutores parAutores = new clsAutores();
                        parAutores.Codigo = int.Parse(txtAutID.Text);

                        clsAutoresDAL autoresDAL = new clsAutoresDAL();
                        autoresDAL.Apagar(parAutores);
                        MessageBox.Show("Autor Apagado!");
                        txtAutID.Focus();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        txtAutID.Focus();
                    }
                }
            }
        }
    }
}