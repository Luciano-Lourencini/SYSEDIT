using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace cl_dal
{
    public class clsConexao
    {
        private static SqlConnection _conexao;
        private static String _StringConexao = "Data Source = localhost\\SQLEXPRESS; " +
                                               "Initial Catalog = dbSysEdit; " +
                                               "Integrated Security = true; " ;

        public static SqlConnection ObterConexao()
        {
            try
            {
                _conexao = new SqlConnection(_StringConexao);
                _conexao.Open();
                return _conexao;
            }
            catch(Exception ex)
            {
                return null;
                throw new Exception(ex.Message);
            }
        }

        public static void FecharConexao()
        {
            if(_conexao.State == ConnectionState.Open)
            {
                _conexao.Close();
            }
        }
    }
}