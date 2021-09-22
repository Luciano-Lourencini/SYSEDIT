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
    }
}