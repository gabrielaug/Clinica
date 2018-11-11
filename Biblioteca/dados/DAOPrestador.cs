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
    public class DAOPrestador : ConexaoSqlServer, InterfacePrestador
    {
        #region Atualizar Prestador
        public void atualizar(Prestador prestador)
        {
            try
            {
                //abrir a conexão
                this.abrirConexao();
                string sql = "update prestador set nm_prestador = @nm_prestador, cpf = @cpf, telefone = @telefone, nr_conselho = @nr_conselho, sn_ativo = @sn_ativo where cd_prestador = @cd_prestador";

                //instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);
                cmd.Parameters.Add("@cd_prestador", SqlDbType.Int);
                cmd.Parameters["@cd_prestador"].Value = prestador.CdPrestador;


                cmd.Parameters.Add("@nm_prestador", SqlDbType.VarChar);
                cmd.Parameters["@nm_prestador"].Value = prestador.NmPrestador;

                cmd.Parameters.Add("@telefone", SqlDbType.VarChar);
                cmd.Parameters["@telefone"].Value = prestador.Telefone;

                cmd.Parameters.Add("@nr_conselho", SqlDbType.VarChar);
                cmd.Parameters["@nr_conselho"].Value = prestador.NrConselho;

                cmd.Parameters.Add("@sn_ativo", SqlDbType.VarChar);
                cmd.Parameters["@sn_ativo"].Value = prestador.SnAtivo;

                //executando a instrucao 
                cmd.ExecuteNonQuery();
                //liberando a memoria 
                cmd.Dispose();
                //fechando a conexao
                this.fecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conectar e atualizar " + ex.Message);
            }
        }
        #endregion

        #region Cadastrar Prestador
        public void cadastrar(Prestador prestador)
        {
            try
            {
                //abrir a conexão
                this.abrirConexao();
                string sql = "INSERT INTO prestador ( nm_prestador, cpf, telefone, nr_conselho, sn_ativo";
                sql += "VALUES(@nm_prestador, @cpf, @telefone, @nr_conselho,@sn_ativo)";
                //instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

                cmd.Parameters.Add("@nm_prestador", SqlDbType.VarChar);
                cmd.Parameters["@nm_prestador"].Value = prestador.NmPrestador;

                cmd.Parameters.Add("@cpf", SqlDbType.VarChar);
                cmd.Parameters["@cpf"].Value = prestador.Cpf;

                cmd.Parameters.Add("@telefone", SqlDbType.VarChar);
                cmd.Parameters["@telefone"].Value = prestador.Telefone;

                cmd.Parameters.Add("@nr_conselho", SqlDbType.VarChar);
                cmd.Parameters["@nr_conselho"].Value = prestador.NrConselho;

                cmd.Parameters.Add("@sn_ativo", SqlDbType.VarChar);
                cmd.Parameters["@sn_ativo"].Value = prestador.SnAtivo;


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

        #region Inativar Prestador
        public void inativar(Prestador prestador)
        {
            try
            {
                //abrir a conexão
                this.abrirConexao();
                string sql = "update prestador set sn_ativo = @sn_ativo where cd_prestador = @cd_prestador";

                //instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);
                cmd.Parameters.Add("@cd_prestador", SqlDbType.Int);
                cmd.Parameters["@cd_prestador"].Value = prestador.CdPrestador;

                cmd.Parameters.Add("@sn_ativo", SqlDbType.VarChar);
                cmd.Parameters["@sn_ativo"].Value = prestador.SnAtivo;

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
        }
        #endregion
        #region Listar Prestadores
        public List<Prestador> ListaPrestadores(Prestador filtro)
        {
            List<Prestador> retorno = new List<Prestador>();
            try
            {

                this.abrirConexao();

                string sql = "select cd_prestador, nm_prestador, cpf, telefone, nr_conselho, sn_ativo";
                sql += "from prestador ";

                if (filtro.CdPrestador > 0)
                {
                    sql += " where cd_prestador = @cd_prestador";
                    if (filtro.Cpf != null) { sql += " and cpf = @cpf "; }
                }

                else if (filtro.Cpf != null)
                {
                    sql += " and cpf = @cpf ";
                }

                SqlCommand cmd = new SqlCommand(sql, sqlConn);

                if (filtro.CdPrestador > 0)
                {
                    cmd.Parameters.Add("@cd_prestador", SqlDbType.Int);
                    cmd.Parameters["@cd_prestador"].Value = filtro.CdPrestador;
                    if (filtro.Cpf != null)
                    {
                        cmd.Parameters.Add("@cpf", SqlDbType.VarChar);
                        cmd.Parameters["@cpf"].Value = filtro.Cpf;
                    }

                }
                else if (filtro.Cpf != null)
                {
                    cmd.Parameters.Add("@cpf", SqlDbType.VarChar);
                    cmd.Parameters["@cpf"].Value = filtro.Cpf;
                }

                SqlDataReader DbReader = cmd.ExecuteReader();


                while (DbReader.Read())
                {
                    Prestador prestador = new Prestador();
                    //acessando os valores das colunas do resultado

                    prestador.CdPrestador = DbReader.GetInt32(DbReader.GetOrdinal("Cd_Agendamento"));
                    prestador.NmPrestador = DbReader.GetString(DbReader.GetOrdinal("Nm_Agendamento"));
                    prestador.Cpf = DbReader.GetString(DbReader.GetOrdinal("CPF"));
                    prestador.Telefone = DbReader.GetString(DbReader.GetOrdinal("telefone"));
                    prestador.NrConselho = DbReader.GetString(DbReader.GetOrdinal("nr_conselho"));
                    prestador.SnAtivo = DbReader.GetString(DbReader.GetOrdinal("sn_ativo"));
                    retorno.Add(prestador);
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
                throw new Exception("Falha ao Listar o(s) Prestador(s) " + ex.Message);
            }
            return retorno;
        }
        #endregion

        public bool VerificarCPF(Prestador prestador)
        {
            #region Verificar se o CPF já esta cadastrado
            bool retorno = false;

            try
            {

                this.abrirConexao();

                string sql;

                sql = "SELECT cd_prestador,nm_prestador,cpf,telefone,nr_conselho, sn_ativo from prestador WHERE CPF = @CPF";
              //  sql += "";


                SqlCommand cmd = new SqlCommand(sql, sqlConn);

                cmd.Parameters.Add("@CPF", SqlDbType.VarChar);
                cmd.Parameters["@CPF"].Value = prestador.Cpf;


                SqlDataReader DbReader = cmd.ExecuteReader();


                if (!DbReader.Read())
                {
                    retorno = true;

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
                throw new Exception("Falha ao Verificar Duplicidade " + ex.Message);
            }

            return retorno;
            #endregion
        }
    }

    }
