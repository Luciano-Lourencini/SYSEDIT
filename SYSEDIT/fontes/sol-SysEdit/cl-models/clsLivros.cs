using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cl_models
{
    public class clsLivros : clsModelo
    {
        private int _anoPublicacao;
        private double _isbn;
        private int _editoraCodigo;

        public int AnoPublicacao
        {
            get { return _anoPublicacao; }
            set 
            { 
                try
                {
                    DateTime data = System.DateTime.Now;
                    int ano = data.Year;

                    if (value <= ano)
                    {
                        _anoPublicacao = value;
                    }
                    else
                    {
                        throw new Exception("Livro deve já ter sido publicado!");
                    }
                }
                catch(Exception ex)
                {
                    throw new Exception("clsLivros: " + ex.Message);
                }
            }
        }

        public double ISBN
        {
            get { return _isbn; }
            set 
            { 
                try
                {
                    if(_isbn.ToString().Trim().Length != 14)
                    {
                        throw new Exception("ISBN deve conter 14 números!");
                    }
                    else
                    {
                        _isbn = value;
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("clsLivros: " + ex.Message);
                }
            }
        }

        public int EditoraCodigo
        {
            get { return _editoraCodigo; }
            set { _editoraCodigo = value; }
        }
    }
}