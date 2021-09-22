using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace wfaSysEdit
{
    public static class clsIsNull
    {
        public static bool IsNull(TextBox txt)
        {
            if (txt.Text.Trim().Length == 0)
                return true;
            else
                return false;
        }

        public static bool IsNull(TextBox txt, TextBox txt2)
        {
            if (txt.Text.Trim().Length == 0 || txt2.Text.Trim().Length == 0)
                return true;
            else
                return false;
        }
    }
}