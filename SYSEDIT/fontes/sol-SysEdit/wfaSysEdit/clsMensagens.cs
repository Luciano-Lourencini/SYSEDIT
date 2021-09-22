using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace wfaSysEdit
{
    //essa será uma classe para economizar tempo ao imprimir MessageBoxes na tela (e utilizar conceitos de POO)
    //não estou usando no momento, mas vai ser útil daqui pra frente
    public class clsMensagens
    {
        public enum tipoMensagem
        {
            informacao,
            aviso,
            erro,
            sucesso
        }

        public static void Mensagem(String mensagem, tipoMensagem tipo)
        {
            switch(tipo)
            {
                case tipoMensagem.aviso:
                    MessageBox.Show(mensagem,"Aviso",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    break;

                case tipoMensagem.informacao:
                    MessageBox.Show(mensagem,"Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    break;

                case tipoMensagem.erro:
                    MessageBox.Show(mensagem,"ERRO",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    break;

                case tipoMensagem.sucesso:
                    MessageBox.Show(mensagem, "Sucesso", MessageBoxButtons.OK);
                    break;
            }
        }
    }
}