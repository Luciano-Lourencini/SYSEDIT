using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cl_models
{
    public class clsEditoras : clsModelo
    {
        private string _sigla;

        public string Sigla
        {
            get { return _sigla; }
            set 
            {
                try
                {
                    if (value.Trim().Length >= 15)
                    {
                        throw new Exception("Sigla deve conter no máximo 15 caracteres!");
                    }
                    else
                    {
                        _sigla = value;
                    }
                }
                catch(Exception ex)
                {
                    throw new Exception("clsEditoras: " + ex.Message);
                }
                
            }
        }
    }
}