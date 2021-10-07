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
            return dal.getProxID();
        }

        public void Salvar(clsEditoras parEditoras)
        {
            dal.Salvar(parEditoras);
        }

        public void Editar(clsEditoras parEditoras)
        {
            dal.Editar(parEditoras);
        }

        public void Apagar(clsEditoras parEditoras)
        {
            dal.Apagar(parEditoras);
        }

        public DataTable listarTodos()
        {
            return dal.listarTodos();
        }

        public DataTable listarTodosComboBox()
        {
            return dal.listarTodosComboBox();
        }

        public List<clsEditoras> listarTodosArray()
        {
            return dal.ListarTodosArray();
        }
    }
}