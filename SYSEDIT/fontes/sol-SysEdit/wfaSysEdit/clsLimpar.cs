using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaSysEdit
{
    public static class clsLimpar
    {
        public static void Limpar(TextBox txt)
        {
            txt.Text = String.Empty;
        }
    }
}