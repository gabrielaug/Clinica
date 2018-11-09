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
    public  class DAOTipoConsulta : ConexaoSqlServer, InterfaceTipoConsulta
    {
        public void inativar(TipoConsulta tipoConsulta)
        {

            #region Inativar Tipo de Consulta
            try
            {
                //abrir a conexão
                this.abrirConexao();
                string sql = "UPDATE Tipo_Consulta SET ";
                sql += "sn_Ativo = @sn_Ativo WHERE Cd_Consulta =  @Cd_Consulta";

                //instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

                cmd.Parameters.Add("@sn_Ativo", SqlDbType.VarChar);
                cmd.Parameters["@sn_Ativo"].Value = tipoConsulta.SnAtivo;

                cmd.Parameters.Add("@Cd_Consulta", SqlDbType.Int);
                cmd.Parameters["@Cd_Consulta"].Value = tipoConsulta.CdConsulta;


                //executando a instrucao 
                cmd.ExecuteNonQuery();
                //liberando a memoria 
                cmd.Dispose();
                //fechando a conexao
                this.fecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception("Falha ao tentar Inativar Tipo de Consulta " + ex.Message);
            }
            #endregion


        }

        public void inserir(TipoConsulta tipoConsulta)
        {

            #region Inserir Tipo da Consulta
            try
            {
                //abrir a conexão
                this.abrirConexao();
                string sql = "INSERT INTO Tipo_Consulta";
                sql += "(Nm_Consulta)";
                sql += "VALUES (@Nm_Consulta)";
                //instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

              
                cmd.Parameters.Add("@Nm_Consulta", SqlDbType.VarChar);
                cmd.Parameters["@Nm_Consulta"].Value = tipoConsulta.NmConsulta;


                //executando a instrucao 
                cmd.ExecuteNonQuery();
                //liberando a memoria 
                cmd.Dispose();
                //fechando a conexao
                this.fecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception("Falha ao tentar Inserir Tipo de Consulta. " + ex.Message);
            }

            #endregion
        }

        public List<TipoConsulta> listarTipoConsulta(TipoConsulta tipoConsulta)
        {
            try
            {

                List<TipoConsulta> retorno = new List<TipoConsulta>();

                this.abrirConexao();

                string sql = "SELECT Cd_Consulta,Nm_Consulta,sn_Ativo FROM Tipo_Consulta ";
                
                if (tipoConsulta.CdConsulta > 0)
                {
                    sql += "WHERE Cd_Consulta = @Cd_Consulta";
                }

                SqlCommand cmd = new SqlCommand(sql, sqlConn);

                if (tipoConsulta.CdConsulta > 0)
                {
                    cmd.Parameters.Add("@Cd_Consulta", SqlDbType.Int);
                    cmd.Parameters["@Cd_Consulta"].Value = tipoConsulta.CdConsulta;
                }

                SqlDataReader DbReader = cmd.ExecuteReader();


                while (DbReader.Read())
                {
                    TipoConsulta tipoC = new TipoConsulta();
                    //acessando os valores das colunas do resultado
                    tipoC.CdConsulta = DbReader.GetInt32(DbReader.GetOrdinal("Cd_Consulta"));
                    tipoC.NmConsulta = DbReader.GetString(DbReader.GetOrdinal("Nm_Consulta"));
                    tipoC.SnAtivo = DbReader.GetString(DbReader.GetOrdinal("sn_Ativo"));
                    retorno.Add(tipoC);
                }

                return retorno;

                //fechando o leitor de resultados
                DbReader.Close();
                //liberando a memoria 
                cmd.Dispose();
                //fechando a conexao
                this.fecharConexao();

            }


            catch (Exception ex)
            {
                throw new Exception("Falha ao Listar o  Paciente " + ex.Message);
            }

        }
    }
}
