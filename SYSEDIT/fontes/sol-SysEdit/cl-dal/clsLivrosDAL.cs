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

        private static SqlDataReader _ReaderSql;

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

        public List<clsLivros> listarTodosArray()
        {
            List<clsLivros> lista = new List<clsLivros>();
            clsLivros item = new clsLivros();

            _conexao = clsConexao.ObterConexao();

            _comando = new SqlCommand();
            _comando.Connection = _conexao;

            _comando.CommandText = "SELECT * FROM tblLivros";

            _ReaderSql = _comando.ExecuteReader();

            while(_ReaderSql.Read())
            {
                item.Codigo = int.Parse(_ReaderSql["LivID"].ToString());  //tentei o 'int.Parse()', mas é o 'Convert.ToInt32()'
                item.Nome = _ReaderSql["LivNome"].ToString();
                item.AnoPublicacao = int.Parse(_ReaderSql["LivAnoPublicacao"].ToString());
                item.ISBN = double.Parse(_ReaderSql["LivISBN"].ToString());
                item.Observacoes = _ReaderSql["LivObservacoes"].ToString();
                item.EditoraCodigo = int.Parse(_ReaderSql["EdiID"].ToString());

                lista.Add(item);
            }

            _ReaderSql.Close();

            clsConexao.FecharConexao();

            return lista;
        }
    }
}