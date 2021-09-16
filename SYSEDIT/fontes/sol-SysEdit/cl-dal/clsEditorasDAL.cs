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
    public class clsEditorasDAL
    {
        private static SqlConnection _conexao;
        private static SqlCommand _comando;

        public int getProxID()
        {
            _conexao = clsConexao.ObterConexao();

            _comando = new SqlCommand();
            _comando.Connection = _conexao;

            _comando.CommandText = "select isnull(max(EdiID),0) + 1 as codigo from tblEditoras";

            int vCodigo = int.Parse(_comando.ExecuteScalar().ToString());

            clsConexao.FecharConexao();

            return vCodigo;
        }

        public void Salvar(clsEditoras parEditoras)
        {
            int vCodigo = getProxID();

            _conexao = clsConexao.ObterConexao();

            _comando = new SqlCommand();
            _comando.Connection = _conexao;

            _comando.CommandText = "INSERT INTO tblEditoras values (@EdiID,@EdiNome,@EdiSigla,@EdiObs)";
            _comando.Parameters.Add("@EdiID", SqlDbType.Int).Value = vCodigo;
            _comando.Parameters.Add("@EdiNome", SqlDbType.VarChar).Value = parEditoras.Nome;
            _comando.Parameters.Add("@EdiSigla", SqlDbType.VarChar).Value = parEditoras.Sigla;
            _comando.Parameters.Add("@EdiObs", SqlDbType.VarChar).Value = parEditoras.Observacoes;

            _comando.ExecuteNonQuery();

            clsConexao.FecharConexao();
        }

        public void Editar(clsEditoras parEditoras)
        {
            _conexao = clsConexao.ObterConexao();

            _comando = new SqlCommand();
            _comando.Connection = _conexao;

            _comando.CommandText = "UPDATE tblEditoras set EdiNome = @Nome, EdiSigla = @Sigla, EdiObservacoes = @Obs where EdiID = @Codigo";
            _comando.Parameters.Add("@Nome", SqlDbType.VarChar).Value = parEditoras.Nome;
            _comando.Parameters.Add("@Sigla", SqlDbType.VarChar).Value = parEditoras.Sigla;
            _comando.Parameters.Add("@Obs", SqlDbType.VarChar).Value = parEditoras.Observacoes;
            _comando.Parameters.Add("@Codigo", SqlDbType.Int).Value = parEditoras.Codigo;

            _comando.ExecuteNonQuery();

            clsConexao.FecharConexao();
        }

        public void Apagar(clsEditoras parEditoras)
        {
            _conexao = clsConexao.ObterConexao();

            _comando = new SqlCommand();
            _comando.Connection = _conexao;

            _comando.CommandText = "DELETE FROM tblEditoras where EdiID = @id";
            _comando.Parameters.Add("@id", SqlDbType.Int).Value = parEditoras.Codigo;

            _comando.ExecuteNonQuery();

            clsConexao.FecharConexao();
        }
    }
}