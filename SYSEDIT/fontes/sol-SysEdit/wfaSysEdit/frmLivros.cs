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
    public partial class frmLivros : Form
    {
        public frmLivros()
        {
            InitializeComponent();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            frmLivrosNovo LN = new frmLivrosNovo();
            LN.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            frmLivrosEditar LE = new frmLivrosEditar();
            LE.ShowDialog();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            frmLivrosExcluir livrosExcluir = new frmLivrosExcluir();
            livrosExcluir.ShowDialog();
        }
    }
}