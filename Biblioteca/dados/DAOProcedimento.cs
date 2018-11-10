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
    public class DAOProcedimento : ConexaoSqlServer, InterfaceProcedimento
    {
        public void Atuaizar(Procedimento procedimento)
        {
            #region Atualizar Procedimento
            try
            {
                this.abrirConexao();
                string sql = "UPDATE Procedimento SET sn_Ativo = @sn_Ativo  ";

                if(procedimento.Valor > 0)
                {
                    sql += ", Valor = @Valor ";

                }

                sql += " WHERE Cd_Procedimento = @Cd_Procedimento ";

                //instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

                if (procedimento.Valor > 0)
                {
                    cmd.Parameters.Add("@Valor", SqlDbType.Decimal);
                    cmd.Parameters["@Valor"].Value = procedimento.Valor; 

                }
                cmd.Parameters.Add("@sn_Ativo", SqlDbType.VarChar);
                cmd.Parameters["@sn_Ativo"].Value = procedimento.SnAtivo;

                cmd.Parameters.Add("@Cd_Procedimento", SqlDbType.VarChar);
                cmd.Parameters["@Cd_Procedimento"].Value =  procedimento.CdProcedimento;


                //executando a instrucao 
                cmd.ExecuteNonQuery();
                //liberando a memoria 
                cmd.Dispose();
                //fechando a conexao
                this.fecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception("Falha ao tentar Atualizar Procedimento. " + ex.Message);

            }


            #endregion 
        }

        public void Adicionar(Procedimento procedimento)
        {

            #region Adicionar Procedimento
            try
            {
                this.abrirConexao();
                string sql = "INSERT INTO Procedimento ";
                sql += "(Cd_Procedimento,Nm_Procedimento,Valor,Cd_Convenio) VALUES (@Cd_Procedimento,@Nm_Procedimento,@Valor,@Cd_Convenio)";
                //instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

                cmd.Parameters.Add("@Cd_Procedimento", SqlDbType.VarChar);
                cmd.Parameters["@Cd_Procedimento"].Value =  procedimento.CdProcedimento;

                cmd.Parameters.Add("@Nm_Procedimento", SqlDbType.VarChar);
                cmd.Parameters["@Nm_Procedimento"].Value = procedimento.NmProcedimento;

                cmd.Parameters.Add("@Valor", SqlDbType.Decimal);
                cmd.Parameters["@Valor"].Value = procedimento.Valor;

                cmd.Parameters.Add("@Cd_Convenio", SqlDbType.VarChar);
                cmd.Parameters["@Cd_Convenio"].Value = procedimento.Convenio.CdConvenio;

                //executando a instrucao 
                cmd.ExecuteNonQuery();
                //liberando a memoria 
                cmd.Dispose();
                //fechando a conexao
                this.fecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception("Falha ao tentar Adicionar Procedimento. " + ex.Message);

            }


            #endregion

        }

        public List<Procedimento> ListarProcedimento(Procedimento procedimento)
        {
            #region Listar Procedimentos
            List<Procedimento> retorno = new List<Procedimento>();

            try
            {

                this.abrirConexao();

                string sql;

                sql = "SELECT p.Cd_Procedimento,p.Nm_Procedimento,p.Valor,p.Cd_Convenio,c.Nm_Convenio,p.sn_Ativo ";
                sql += "FROM Procedimento as p INNER JOIN Convenio AS c ON c.Cd_Convenio = p.Cd_Convenio";


                if (procedimento.CdProcedimento != null && !procedimento.CdProcedimento.Trim().Equals(""))
                {
                    sql += " WHERE Cd_Procedimento = @Cd_Procedimento";

                }

                SqlCommand cmd = new SqlCommand(sql, sqlConn);

                if (procedimento.CdProcedimento != null && !procedimento.CdProcedimento.Trim().Equals(""))
                {
                    cmd.Parameters.Add("@Cd_Procedimento", SqlDbType.VarChar);
                    cmd.Parameters["@Cd_Procedimento"].Value = procedimento.CdProcedimento;

                }



                SqlDataReader DbReader = cmd.ExecuteReader();


                while (DbReader.Read())
                {
                    Procedimento p = new Procedimento();
                    //acessando os valores das colunas do resultado
                    p.CdProcedimento = DbReader.GetString(DbReader.GetOrdinal("Cd_Procedimento"));
                    p.NmProcedimento = DbReader.GetString(DbReader.GetOrdinal("Nm_Procedimento"));
                    p.Valor = (Double) DbReader.GetDecimal(DbReader.GetOrdinal("Valor"));
                    p.Convenio.CdConvenio = DbReader.GetInt32(DbReader.GetOrdinal("Cd_Convenio"));
                    p.Convenio.NmConvenio = DbReader.GetString(DbReader.GetOrdinal("Nm_Convenio"));
                    p.SnAtivo = DbReader.GetString(DbReader.GetOrdinal("sn_Ativo"));
                    retorno.Add(p);
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
                throw new Exception("Falha ao Listar Procedimentos " + ex.Message);
            }
            return retorno;

            #endregion
        }
    }
    
}
