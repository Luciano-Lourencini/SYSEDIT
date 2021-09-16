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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void editorasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmEditoras editoras = new frmEditoras();
            editoras.ShowDialog();
        }

        private void livrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLivros livros = new frmLivros();
            livros.ShowDialog();
        }

        private void autoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAutores autores = new frmAutores();
            autores.ShowDialog();
        }
    }
}