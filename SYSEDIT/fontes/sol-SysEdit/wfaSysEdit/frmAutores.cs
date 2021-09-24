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
    public partial class frmAutores : Form
    {
        public frmAutores()
        {
            InitializeComponent();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            frmAutoresNovo AU = new frmAutoresNovo();
            AU.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            frmAutoresEditar autoresEditar = new frmAutoresEditar();
            autoresEditar.ShowDialog();
        }
    }
}