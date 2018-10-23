using Biblioteca.Basicas;
using Biblioteca.conexao;
using Biblioteca.interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.dados
{
    class DAOTipoConsulta : ConexaoSqlServer, InterfaceTipoConsulta
    {
        public void inativar(TipoConsulta tipoConsulta)
        {
            throw new NotImplementedException();
        }

        public void inserir(TipoConsulta tipoConsulta)
        {

            #region Inserir Tipo da Consulta
            try
            {
                //abrir a conexão
                this.abrirConexao();
                string sql = "INSERT INTO Tipo_Consulta";
                sql += "(Cd_Consulta,Nm_Consulta,sn_Ativo)";
                sql += "VALUES (@Cd_Consulta,@Nm_Consulta,@sn_Ativo)";
                //instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

                cmd.Parameters.Add("@Cd_Consulta", SqlDbType.Int);
                cmd.Parameters["@Cd_Consulta"].Value = tipoConsulta.CdConsulta;

                cmd.Parameters.Add("@Nm_Consulta", SqlDbType.VarChar);
                cmd.Parameters["@Nm_Consulta"].Value = tipoConsulta.NmConsulta;

                cmd.Parameters.Add("@sn_Ativo", SqlDbType.VarChar);
                cmd.Parameters["@sn_Ativo"].Value = tipoConsulta.SnAtivo;



                //executando a instrucao 
                cmd.ExecuteNonQuery();
                //liberando a memoria 
                cmd.Dispose();
                //fechando a conexao
                this.fecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception("Falha ao tentar Inserir o Paciente. " + ex.Message);
            }

            #endregion


        }

        public List<TipoConsulta> listarTipoConsulta()
        {
            throw new NotImplementedException();
        }
    }
}
