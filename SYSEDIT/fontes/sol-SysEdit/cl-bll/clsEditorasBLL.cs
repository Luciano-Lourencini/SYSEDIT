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
    public class clsEditorasBLL
    {
        clsEditorasDAL dal = new clsEditorasDAL();
        public int getProxID()
        {
            try
            {
                return dal.getProxID();
            }
            catch(Exception ex)
            {
                throw new Exception("clsEditorasBLL: " + ex.Message);
            }
        }

        public void Salvar(clsEditoras parEditoras)
        {
            /*
             * Não vou colocar aqui porque é uma VALIDAÇÃO DE DADOS, não REGRA DE NEGÓCIOS
             * (é algo lógico, não algo adotado pela empresa)
             
            try
            {
                if(parEditoras.Sigla.Trim().Length >= 15)
                {
                    throw new Exception("Sigla deve ter no máximo 15 caracteres!");
                }
                dal.Salvar(parEditoras);
            }
            */
            try
            {
                dal.Salvar(parEditoras);
            }
            catch (Exception ex)
            {
                throw new Exception("clsEditorasBLL: " + ex.Message);
            }
        }

        public void Editar(clsEditoras parEditoras)
        {
            try
            {
                dal.Editar(parEditoras);
            }
            catch (Exception ex)
            {
                throw new Exception("clsEditorasBLL: " + ex.Message);
            }
        }

        public void Apagar(clsEditoras parEditoras)
        {
            try
            {
                dal.Apagar(parEditoras);
            }
            catch (Exception ex)
            {
                throw new Exception("clsEditorasBLL: " + ex.Message);
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
                throw new Exception("clsEditorasBLL: " + ex.Message);
            }
        }

        public DataTable listarTodosComboBox()
        {
            try
            {
                return dal.listarTodosComboBox();
            }
            catch (Exception ex)
            {
                throw new Exception("clsEditorasBLL: " + ex.Message);
            }
        }

        public List<clsEditoras> listarTodosArray()
        {
            try
            {
                return dal.ListarTodosArray();
            }
            catch (Exception ex)
            {
                throw new Exception("clsEditorasBLL: " + ex.Message);
            }
        }
    }
}