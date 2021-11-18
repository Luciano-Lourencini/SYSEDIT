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
    public class clsUsuariosDAL
    {
        private static SqlConnection _conexao;
        private static SqlCommand _comando;
        private static SqlDataAdapter _adaptador;
        private static DataTable _tabela;

        private static SqlDataReader _ReaderSql;

        public int getProxID()
        {
            _conexao = clsConexao.ObterConexao();

            _comando = new SqlCommand();
            _comando.Connection = _conexao;

            _comando.CommandText = "SELECT isnull(max(UserID),0) +1 as codigo FROM tblUsuarios";

            int vCodigo = int.Parse(_comando.ExecuteScalar().ToString());

            clsConexao.FecharConexao();

            return vCodigo;
        }

        public void Salvar(clsUsuarios parUsuarios)
        {
            int vCodigo = getProxID();

            _conexao = clsConexao.ObterConexao();

            _comando = new SqlCommand();
            _comando.Connection = _conexao;

            _comando.CommandText = "INSERT INTO tblUsuarios VALUES (@id,@cpf,@nome,@senha,@email,@telefone,@obs)";
            _comando.Parameters.Add("@id", SqlDbType.Int).Value = vCodigo;
            _comando.Parameters.Add("@cpf", SqlDbType.Decimal).Value = parUsuarios.CPF;
            _comando.Parameters.Add("@nome", SqlDbType.VarChar).Value = parUsuarios.Nome;
            _comando.Parameters.Add("@senha", SqlDbType.VarChar).Value = parUsuarios.Senha;
            _comando.Parameters.Add("@email", SqlDbType.VarChar).Value = parUsuarios.Email;
            _comando.Parameters.Add("@telefone", SqlDbType.Decimal).Value = parUsuarios.Telefone;
            _comando.Parameters.Add("@obs", SqlDbType.VarChar).Value = parUsuarios.Observacoes;

            _comando.ExecuteNonQuery();

            clsConexao.FecharConexao();
        }

        public void Editar(clsUsuarios parUsuarios)
        {
            _conexao = clsConexao.ObterConexao();

            _comando = new SqlCommand();
            _comando.Connection = _conexao;

            _comando.CommandText = "UPDATE tblUsuarios SET UserCPF = @cpf,UserNome = @nome, UserSenha = @senha, UserEmail = @email, UserTelefone = @telefone, UserObs = @obs WHERE UserID = @id";
            _comando.Parameters.Add("@id", SqlDbType.Int).Value = parUsuarios.Codigo;
            _comando.Parameters.Add("@cpf", SqlDbType.Decimal).Value = parUsuarios.CPF;
            _comando.Parameters.Add("@nome", SqlDbType.VarChar).Value = parUsuarios.Nome;
            _comando.Parameters.Add("@senha", SqlDbType.VarChar).Value = parUsuarios.Senha;
            _comando.Parameters.Add("@email", SqlDbType.VarChar).Value = parUsuarios.Email;
            _comando.Parameters.Add("@telefone", SqlDbType.Decimal).Value = parUsuarios.Telefone;
            _comando.Parameters.Add("@obs", SqlDbType.VarChar).Value = parUsuarios.Observacoes;

            _comando.ExecuteNonQuery();

            clsConexao.FecharConexao();
        }

        public void Apagar(clsUsuarios parUsuarios)
        {
            _conexao = clsConexao.ObterConexao();

            _comando = new SqlCommand();
            _comando.Connection = _conexao;

            _comando.CommandText = "DELETE FROM tblUsuarios where @id = UserID";
            _comando.Parameters.Add("@id", SqlDbType.Int).Value = parUsuarios.Codigo;

            _comando.ExecuteNonQuery();

            clsConexao.FecharConexao();
        }

        public DataTable listarTodos()
        {
            _conexao = clsConexao.ObterConexao();

            _comando = new SqlCommand();
            _comando.Connection = _conexao;

            _comando.CommandText = "SELECT * FROM tblUsuarios";

            _tabela = new DataTable();
            _adaptador = new SqlDataAdapter(_comando);
            _adaptador.Fill(_tabela);

            clsConexao.FecharConexao();

            return _tabela;
        }

        public clsUsuarios login(string email,string senha)
        {
            clsUsuarios parUsuarios = null;

            _conexao = clsConexao.ObterConexao();

            _comando = new SqlCommand();
            _comando.Connection = _conexao;

            _comando.CommandText = "SELECT * FROM tblUsuarios where @email = UserEmail and @senha = UserSenha";
            _comando.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
            _comando.Parameters.Add("@senha",SqlDbType.VarChar).Value = senha;

            _ReaderSql = _comando.ExecuteReader();

            while(_ReaderSql.Read())
            {
                parUsuarios = new clsUsuarios();

                parUsuarios.Email = _ReaderSql["UserEmail"].ToString();
                parUsuarios.Senha = _ReaderSql["UserSenha"].ToString();
                parUsuarios.Nome = _ReaderSql["UserNome"].ToString();
            }

            _ReaderSql.Close();

            clsConexao.FecharConexao();

            return parUsuarios;
        }

        public List<clsUsuarios> listarTodosArray()
        {
            List<clsUsuarios> lista = new List<clsUsuarios>();
            clsUsuarios item = new clsUsuarios();

            _conexao = clsConexao.ObterConexao();

            _comando = new SqlCommand();
            _comando.Connection = _conexao;

            _comando.CommandText = "SELECT * FROM tblUsuarios";

            _ReaderSql = _comando.ExecuteReader();

            while(_ReaderSql.Read())
            {
                item.Codigo = int.Parse(_ReaderSql["UserID"].ToString());
                item.CPF = double.Parse(_ReaderSql["UserCPF"].ToString());
                item.Nome = _ReaderSql["UserNome"].ToString();
                item.Senha = _ReaderSql["UserSenha"].ToString();
                item.Email = _ReaderSql["UserEmail"].ToString();
                item.Telefone = double.Parse(_ReaderSql["UserTelefone"].ToString());
                item.Observacoes = _ReaderSql["UserObs"].ToString();

                lista.Add(item);
            }

            _ReaderSql.Close();

            clsConexao.FecharConexao();

            return lista;
        }
    }
}