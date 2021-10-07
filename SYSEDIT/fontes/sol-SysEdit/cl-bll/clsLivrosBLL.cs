using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.Sql;

using cl_dal;
using cl_models;

namespace cl_bll
{
    public class clsLivrosBLL
    {
        clsLivrosDAL dal = new clsLivrosDAL();

        public int getProxID()
        {
            return dal.getProximoID();
        }

        public void Salvar(clsLivros parLivros)
        {
            dal.Salvar(parLivros);
        }

        public void Editar(clsLivros parLivros)
        {
            dal.Editar(parLivros);
        }

        public void Apagar(clsLivros parLivros)
        {
            dal.Apagar(parLivros);
        }

        public DataTable listarTodos()
        {
            return dal.listarTodos();
        }

        public List<clsLivros> listarTodosArray()
        {
            return dal.listarTodosArray();
        }
    }
}