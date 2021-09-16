using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cl_models
{
    public class clsAutores : clsModelo
    {
        private string _pseudonimo;

        public string Pseudonimo
        {
            get { return _pseudonimo; }
            set { _pseudonimo = value; }
        }
    }
}