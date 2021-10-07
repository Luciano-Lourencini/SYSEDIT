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
    public class clsUsuariosBLL
    {
        clsUsuariosDAL dal = new clsUsuariosDAL();

        public int getProxID()
        {
            return dal.getProxID();
        }

        public void Salvar(clsUsuarios parUsuarios)
        {
            dal.Salvar(parUsuarios);
        }

        public void Editar(clsUsuarios parUsuarios)
        {
            dal.Editar(parUsuarios);
        }

        public void Apagar(clsUsuarios parUsuarios)
        {
            dal.Apagar(parUsuarios);
        }

        public DataTable listarTodos()
        {
            return dal.listarTodos();
        }

        public List<clsUsuarios> listarTodosArray()
        {
            return dal.listarTodosArray();
        }
    }
}