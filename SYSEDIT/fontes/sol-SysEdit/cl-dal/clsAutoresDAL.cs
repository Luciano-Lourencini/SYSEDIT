using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

using cl_models;

namespace cl_dal
{
    public class clsAutoresDAL
    {
        private SqlConnection _conexao;
        private SqlCommand _comando;

        private int getProxID()
        {
            _conexao = clsConexao.ObterConexao();

            _comando = new SqlCommand();
            _comando.Connection = _conexao;

            _comando.CommandText = "SELECT isnull(max(AutID),0) + 1 as codigo FROM tblAutores";

            int vCodigo = int.Parse(_comando.ExecuteScalar().ToString());  //ExecuteScalar retorna valor

            clsConexao.FecharConexao();

            return vCodigo;
        }

        public void Salvar(clsAutores parAutores)
        {
            int vCodigo = getProxID();

            _conexao = clsConexao.ObterConexao();

            _comando = new SqlCommand();
            _comando.Connection = _conexao;

            _comando.CommandText = "INSERT INTO tblAutores VALUES (@id, @nome, @pseud, @obs)";
            _comando.Parameters.Add("@id", SqlDbType.Int).Value = vCodigo;
            _comando.Parameters.Add("@nome", SqlDbType.VarChar).Value = parAutores.Nome;
            _comando.Parameters.Add("@pseud", SqlDbType.VarChar).Value = parAutores.Pseudonimo;
            _comando.Parameters.Add("@obs", SqlDbType.VarChar).Value = parAutores.Observacoes;

            _comando.ExecuteNonQuery();

            clsConexao.FecharConexao();
        }

        public void Editar(clsAutores parAutores)
        {
            _conexao = clsConexao.ObterConexao();

            _comando = new SqlCommand();
            _comando.Connection = _conexao;

            _comando.CommandText = "UPDATE tblAutores SET AutNome = @nome, AutPseudonimo = @pseud, AutObservacoes = @obs WHERE AutID = @codigo";
            _comando.Parameters.Add("@nome", SqlDbType.VarChar).Value = parAutores.Nome;
            _comando.Parameters.Add("@pseud", SqlDbType.VarChar).Value = parAutores.Pseudonimo;
            _comando.Parameters.Add("@obs", SqlDbType.VarChar).Value = parAutores.Observacoes;
            _comando.Parameters.Add("@codigo", SqlDbType.Int).Value = parAutores.Codigo;

            _comando.ExecuteNonQuery();

            clsConexao.FecharConexao();
        }

        public void Apagar(clsAutores parAutores)
        {
            _conexao = clsConexao.ObterConexao();

            _comando = new SqlCommand();
            _comando.Connection = _conexao;

            _comando.CommandText = "DELETE FROM tblAutores where AutID = @id";
            _comando.Parameters.Add("@id", SqlDbType.Int).Value = parAutores.Codigo;

            _comando.ExecuteNonQuery();

            clsConexao.FecharConexao();
        }
    }
}