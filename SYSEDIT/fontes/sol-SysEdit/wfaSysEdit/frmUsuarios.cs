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
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            frmUsuariosNovo usuariosNovo = new frmUsuariosNovo();
            usuariosNovo.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            frmUsuariosEditar usuariosEditar = new frmUsuariosEditar();
            usuariosEditar.ShowDialog();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            frmUsuariosExcluir usuariosExcluir = new frmUsuariosExcluir();
            usuariosExcluir.ShowDialog();
        }
    }
}