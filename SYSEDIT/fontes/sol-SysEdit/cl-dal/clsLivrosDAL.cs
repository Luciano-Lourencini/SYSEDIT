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
    public class clsLivrosDAL
    {
        private static SqlConnection _conexao;
        private static SqlCommand _comando;
        private static SqlDataAdapter _adaptador;
        private static DataTable _tabela;

        private int getProximoID()
        {
            _conexao = clsConexao.ObterConexao();

            _comando = new SqlCommand();
            _comando.Connection = _conexao;

            _comando.CommandText = "SELECT isnull(max(LivID),0) + 1 as codigo FROM tblLivros";

            int vCodigo = int.Parse(_comando.ExecuteScalar().ToString());

            clsConexao.FecharConexao();

            return vCodigo;
        }

        public void Salvar(clsLivros parLivros)
        {
            int vCodigo = getProximoID();
            
            _conexao = clsConexao.ObterConexao();

            _comando = new SqlCommand();
            _comando.Connection = _conexao;

            _comando.CommandText = "INSERT INTO tblLivros values (@id, @nome, @anoPubli, @ISBN, @obs, @ediID)";
            _comando.Parameters.Add("@id", SqlDbType.Int).Value = vCodigo;
            _comando.Parameters.Add("@nome", SqlDbType.VarChar).Value = parLivros.Nome;
            _comando.Parameters.Add("@anoPubli", SqlDbType.Int).Value = parLivros.AnoPublicacao;
            _comando.Parameters.Add("@ISBN", SqlDbType.Decimal).Value = parLivros.ISBN;
            _comando.Parameters.Add("@obs", SqlDbType.VarChar).Value = parLivros.Observacoes;
            _comando.Parameters.Add("@ediID", SqlDbType.Int).Value = parLivros.EditoraCodigo;

            _comando.ExecuteNonQuery();

            clsConexao.FecharConexao();
        }

        public void Editar(clsLivros parLivros)
        {
            _conexao = clsConexao.ObterConexao();

            _comando = new SqlCommand();
            _comando.Connection = _conexao;

            _comando.CommandText = "UPDATE tblLivros SET LivNome = @nome, LivAnoPublicacao = @anoPubli, LivISBN = @isbn, LivObservacoes = @obs, EdiID = @ediID WHERE LivID = @codigo";
            _comando.Parameters.Add("@nome", SqlDbType.VarChar).Value = parLivros.Nome;
            _comando.Parameters.Add("@anoPubli", SqlDbType.Int).Value = parLivros.AnoPublicacao;
            _comando.Parameters.Add("@isbn", SqlDbType.Decimal).Value = parLivros.ISBN;
            _comando.Parameters.Add("@obs", SqlDbType.VarChar).Value = parLivros.Observacoes;
            _comando.Parameters.Add("@ediID", SqlDbType.Int).Value = parLivros.EditoraCodigo;
            _comando.Parameters.Add("@codigo", SqlDbType.Int).Value = parLivros.Codigo;

            _comando.ExecuteNonQuery();

            clsConexao.FecharConexao();
        }

        public void Apagar(clsLivros parLivros)
        {
            _conexao = clsConexao.ObterConexao();

            _comando = new SqlCommand();
            _comando.Connection = _conexao;

            _comando.CommandText = "DELETE FROM tblLivros where LivID = @id";
            _comando.Parameters.Add("@id", SqlDbType.Int).Value = parLivros.Codigo;

            _comando.ExecuteNonQuery();

            clsConexao.FecharConexao();
        }

        public DataTable listarTodos()
        {
            _conexao = clsConexao.ObterConexao();

            _comando = new SqlCommand();
            _comando.Connection = _conexao;

            _comando.CommandText = "SELECT * FROM tblLivros";

            _tabela = new DataTable();
            _adaptador = new SqlDataAdapter(_comando);
            _adaptador.Fill(_tabela);

            clsConexao.FecharConexao();

            return _tabela;
        }
    }
}