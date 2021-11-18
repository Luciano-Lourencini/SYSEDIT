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
    public partial class frmLogin : Form
    {
        public Boolean acessoPermitido = false;  //público para ser visto pela tela Principal

        public frmLogin()
        {
            InitializeComponent();
        }

        private void chMostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (chMostrarSenha.Checked == true)
                txtSenha.PasswordChar = '\0';
            else
                txtSenha.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtEmail.Text.Trim().Length == 0)
            {
                MessageBox.Show("Favor digitar o Email!","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                txtEmail.Focus();
            }
            else if(txtSenha.Text.Trim().Length == 0)
            {
                MessageBox.Show("Favor digitar a Senha!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtSenha.Focus();
            }
            else if(txtEmail.Text.Contains("@") == false)
            {
                MessageBox.Show("Favor digitar um Email válido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtEmail.Focus();
            }
            else if (txtEmail.Text.Contains(".com") == false)
            {
                MessageBox.Show("Favor digitar um Email válido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtEmail.Focus();
            }
            else
            {
                try
                {
                    clsUsuarios parUsuarios = null;
                    clsUsuariosBLL usuariosBLL = new clsUsuariosBLL();

                    parUsuarios = usuariosBLL.login(txtEmail.Text, txtSenha.Text);

                    if(parUsuarios != null)
                    {
                        MessageBox.Show("Seja bem-vindo(a) " + parUsuarios.Nome + "!","Login efetuado",MessageBoxButtons.OK);

                        acessoPermitido = true;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Usuário ou Senha incorreto!", "Erro", MessageBoxButtons.OK);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}