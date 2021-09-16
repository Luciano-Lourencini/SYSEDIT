using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaSysEdit
{
    public partial class frmEditoras : Form
    {
        public frmEditoras()
        {
            InitializeComponent();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            frmEditorasNovo EN = new frmEditorasNovo();
            EN.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            frmEditorasEditar Edi = new frmEditorasEditar();
            Edi.ShowDialog();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            frmEditorasExcluir Ex = new frmEditorasExcluir();
            Ex.ShowDialog();
        }
    }
}