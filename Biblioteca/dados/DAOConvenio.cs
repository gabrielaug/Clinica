using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Basicas;
using Biblioteca.conexao;
using Biblioteca.interfaces;

namespace Biblioteca.dados
{
    public class DAOConvenio : ConexaoSqlServer, InterfaceConvenio
    {


        public void cadastrar(Convenio convenio)
        {
            #region Inserir convênio
            try
            {
                //abrir a conexão
                this.abrirConexao();
                string sql = "INSERT INTO convenio ( nm_convenio)";
                sql += "VALUES( @nm_convenio)";
                //instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

                cmd.Parameters.Add("@nm_convenio", SqlDbType.VarChar);
                cmd.Parameters["@nm_convenio"].Value = convenio.NmConvenio;
                
                cmd.Parameters.Add("@sn_ativo", SqlDbType.VarChar);
                cmd.Parameters["@sn_ativo"].Value = convenio.SnAtivo;


                //executando a instrucao 
                cmd.ExecuteNonQuery();
                //liberando a memoria 
                cmd.Dispose();
                //fechando a conexao
                this.fecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conectar e inserir " + ex.Message);
            }
        }
        #endregion

        #region Inativar convenio
        public void inativar(Convenio convenio)
        {
            try
            {
                //abrir a conexão
                this.abrirConexao();
                string sql = "update convenio set sn_ativo = @sn_ativo where cd_convenio = @cd_convenio";

              //  if (convenio.SnAtivo == "S") { sql += "update convenio set sn_ativo = @sn_ativo where cd_convenio = @cd_convenio ";}

               //instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);
                cmd.Parameters.Add("@cd_convenio", SqlDbType.Int);
                cmd.Parameters["@cd_convenio"].Value = convenio.CdConvenio;

                cmd.Parameters.Add("@sn_ativo", SqlDbType.VarChar);
                cmd.Parameters["@sn_ativo"].Value = convenio.SnAtivo;

                //executando a instrucao 
                cmd.ExecuteNonQuery();
                //liberando a memoria 
                cmd.Dispose();
                //fechando a conexao
                this.fecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conectar e inativar " + ex.Message);
            }

            #endregion
        }
        
        #region Listar Convênio
        public List<Convenio> listarConvenios(Convenio filtro)
        {
            List<Convenio> retorno = new List<Convenio>();
            try
            {

                this.abrirConexao();

                string sql = " select cd_convenio,nm_convenio, sn_ativo";
                sql += "from convenio a ";
                
                if (filtro.CdConvenio > 0)
                {
                    sql += " WHERE a.cd_convenio = @cd_convenio ";

                }

                SqlCommand cmd = new SqlCommand(sql, sqlConn);

                if (filtro.CdConvenio > 0)
                {
                    cmd.Parameters.Add("@cd_convenio", SqlDbType.Int);
                    cmd.Parameters["@cd_convenio"].Value = filtro.CdConvenio;
                }
               
                SqlDataReader DbReader = cmd.ExecuteReader();


                while (DbReader.Read())
                {
                    Convenio convenio = new Convenio();
                    //acessando os valores das colunas do resultado
                    convenio.CdConvenio = DbReader.GetInt32(DbReader.GetOrdinal("cd_convenio"));
                    convenio.NmConvenio = DbReader.GetString(DbReader.GetOrdinal("nm_convenio"));
                    convenio.SnAtivo = DbReader.GetString(DbReader.GetOrdinal("sn_ativo"));
                    retorno.Add(convenio);
                }
                //fechando o leitor de resultados
                DbReader.Close();
                //liberando a memoria 
                cmd.Dispose();
                //fechando a conexao
                this.fecharConexao();

            }
            catch (Exception ex)
            {
                throw new Exception("Falha ao Listar o(s) Convenio(s) " + ex.Message);
            }
            return retorno;


        }
        #endregion
    }
}
