using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cl_models
{
    public class clsUsuarios : clsModelo
    {
        private double _cpf;
        private string _senha;
        private string _email;
        private double _telefone;

        public double CPF
        {
            get { return _cpf; }
            set { _cpf = value; }
        }

        public string Senha
        {
            get { return _senha; }
            set { _senha = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public double Telefone
        {
            get { return _telefone; }
            set { _telefone = value; }
        }
    }
}