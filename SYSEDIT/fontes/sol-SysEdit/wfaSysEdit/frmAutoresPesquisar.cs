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

namespace wfaSysEdit
{
    public partial class frmAutoresPesquisar : Form
    {
        private void carregarGridAutores()  //método que carrega os dados
        {
            clsAutoresDAL parAutores = new clsAutoresDAL();  //inicializa a variável

            dgEstados.AutoGenerateColumns = true;  //para gerar as colunas de forma automática
            dgEstados.DataSource = parAutores.ListarTodos();
        }

        public frmAutoresPesquisar()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            carregarGridAutores();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            carregarGridAutores();
        }
    }
}