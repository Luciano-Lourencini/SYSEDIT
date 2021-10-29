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
            try
            {
                //só estou encaminahndo pra lá   ->  Está servindo de intermediária
                clsAutoresDAL dal = new clsAutoresDAL();
                return dal.getProxID();
            }
            catch(Exception ex)
            {
                throw new Exception("clsAutoresBLL: " + ex.Message);  //não coloquei o MessageBox porque não tem o Forms referenciado
            }
            
        }

        public void Salvar(clsAutores parAutores)
        {
            try
            {
                clsAutoresDAL dal = new clsAutoresDAL();
                dal.Salvar(parAutores);
            }
            catch (Exception ex)
            {
                throw new Exception("clsAutoresBLL: " + ex.Message);
            }
        }

        public void Editar(clsAutores parAutores)
        {
            try
            {
                clsAutoresDAL dal = new clsAutoresDAL();
                dal.Editar(parAutores);
            }
            catch (Exception ex)
            {
                throw new Exception("clsAutoresBLL: " + ex.Message);
            }
        }

        public void Apagar(clsAutores parAutores)
        {
            try
            {
                clsAutoresDAL dal = new clsAutoresDAL();
                dal.Apagar(parAutores);
            }
            catch (Exception ex)
            {
                throw new Exception("clsAutoresBLL: " + ex.Message);
            }
        }

        public DataTable listarTodos()
        {
            try
            {
                clsAutoresDAL dal = new clsAutoresDAL();
                return dal.ListarTodos();
            }
            catch (Exception ex)
            {
                throw new Exception("clsAutoresBLL: " + ex.Message);
            }
        }

        public List<clsAutores> listarTodosArray()
        {
            try
            {
                clsAutoresDAL dal = new clsAutoresDAL();
                return dal.listarTodosArray();
            }
            catch (Exception ex)
            {
                throw new Exception("clsAutoresBLL: " + ex.Message);
            }
        }
    }
}