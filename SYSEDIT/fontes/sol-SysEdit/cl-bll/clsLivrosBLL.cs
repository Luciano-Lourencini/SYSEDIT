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
            try
            {
                return dal.getProximoID();
            }
            catch(Exception ex)
            {
                throw new Exception("clsLivrosBLL: " + ex.Message);
            }
        }

        public void Salvar(clsLivros parLivros)
        {
            try
            {
                dal.Salvar(parLivros);
            }
            catch (Exception ex)
            {
                throw new Exception("clsLivrosBLL: " + ex.Message);
            }
        }

        public void Editar(clsLivros parLivros)
        {
            try
            {
                dal.Editar(parLivros);
            }
            catch (Exception ex)
            {
                throw new Exception("clsLivrosBLL: " + ex.Message);
            }
        }

        public void Apagar(clsLivros parLivros)
        {
            try
            {
                dal.Apagar(parLivros);
            }
            catch (Exception ex)
            {
                throw new Exception("clsLivrosBLL: " + ex.Message);
            }
        }

        public DataTable listarTodos()
        {
            try
            {
                return dal.listarTodos();
            }
            catch (Exception ex)
            {
                throw new Exception("clsLivrosBLL: " + ex.Message);
            }
        }

        public List<clsLivros> listarTodosArray()
        {
            try
            {
                return dal.listarTodosArray();
            }
            catch (Exception ex)
            {
                throw new Exception("clsLivrosBLL: " + ex.Message);
            }
        }
    }
}