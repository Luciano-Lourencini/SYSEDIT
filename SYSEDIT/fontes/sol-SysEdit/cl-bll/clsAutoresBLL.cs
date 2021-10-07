using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using cl_models;
using cl_dal;

using System.Data;
using System.Data.Sql;

namespace cl_bll
{
    //BLL - Business Logic Layer - Regras de Negócio

    //Tem os mesmos métodos da classe DAL
    //A usamos para que todos os sistemas que utilizarem a arquitetura que está sendo desenvolvida, vai ter que respeitar (serve como um porteiro)
    public class clsAutoresBLL
    {
        public int getProxID()
        {
            clsAutoresDAL dal = new clsAutoresDAL();
            return dal.getProxID();
        }

        public void Salvar(clsAutores parAutores)
        {
            //só estou encaminahndo pra lá   ->  Está servindo de intermediária

            clsAutoresDAL dal = new clsAutoresDAL();
            dal.Salvar(parAutores);
        }

        public void Editar(clsAutores parAutores)
        {
            clsAutoresDAL dal = new clsAutoresDAL();
            dal.Editar(parAutores);
        }

        public void Apagar(clsAutores parAutores)
        {
            clsAutoresDAL dal = new clsAutoresDAL();
            dal.Apagar(parAutores);
        }

        public DataTable listarTodos()
        {
            clsAutoresDAL dal = new clsAutoresDAL();
            return dal.ListarTodos();
        }

        public List<clsAutores> listarTodosArray()
        {
            clsAutoresDAL dal = new clsAutoresDAL();
            return dal.listarTodosArray();
        }
    }
}