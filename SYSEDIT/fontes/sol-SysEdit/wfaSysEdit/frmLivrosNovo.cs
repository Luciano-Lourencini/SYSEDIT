using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using cl_bll;
using cl_models;

namespace wfaSysEdit
{
    //Livro é o único a ter FK, por isso tem o ComboBox
    public partial class frmLivrosNovo : Form
    {
        private clsEditorasBLL parEditorasBLL = new clsEditorasBLL(); //private para ninguém acessar além dele

        private void carregarComboEditoras()  //ComboBox
        {
            cbEdiID.DataSource = parEditorasBLL.listarTodosComboBox();
            cbEdiID.DisplayMember = "EdiSigla";  //exiba essa coluna    //qual o campo que eu quero que exiba
            cbEdiID.ValueMember = "EdiID";  //qual vai ser o valor que ele representa    //ex: 'Abril' vai valer '1'
        }

        public bool IsNull(TextBox txt)
        {
            if (txt.Text.Trim().Length == 0)
                return true;
            else
                return false;
        }

        public void Apagar(TextBox txt)
        {
            txt.Text = "";
        }

        public frmLivrosNovo()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(!(IsNull(txtAnoPubli)))
            {
                if (!(cbEdiID.SelectedIndex<0))  //0 é a 1ª linha
                {
                    if (!(IsNull(txtISBN)))
                    {
                        if (!(IsNull(txtNome)))
                        {
                            try
                            {
                                clsLivros parLivros = new clsLivros();

                                parLivros.Nome = txtNome.Text;
                                parLivros.AnoPublicacao = int.Parse(txtAnoPubli.Text);
                                parLivros.ISBN = double.Parse(txtISBN.Text);
                                parLivros.Observacoes = txtObs.Text;
                                parLivros.EditoraCodigo = int.Parse(cbEdiID.SelectedValue.ToString());

                                clsLivrosBLL livrosBLL = new clsLivrosBLL();
                                livrosBLL.Salvar(parLivros);

                                MessageBox.Show("Livro cadastrado com sucesso!");

                                Apagar(txtAnoPubli);
                                cbEdiID.SelectedIndex = -1;  //limpar combo
                                Apagar(txtISBN);
                                Apagar(txtNome);
                                Apagar(txtObs);

                                txtNome.Focus();
                            }
                            catch(Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                                txtNome.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Preencher todos os itens!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Preencher todos os itens!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Preencher todos os itens!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Preencher todos os itens!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void frmLivrosNovo_Load(object sender, EventArgs e)
        {
            carregarComboEditoras();
            cbEdiID.SelectedIndex = -1; //para inicializar limpo
        }
    }
}