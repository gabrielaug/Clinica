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
    public class DAOAtendimento : ConexaoSqlServer, InterfaceAtendimento
    {
        
        public void atualizar(Atendimento atendimento)
        {
            #region Atualizar Atendimento
            try
            {
                //abrir a conexão
                this.abrirConexao();
                string sql = "update atendimento set dt_atendimento = @dt_atendimento, cd_prestador = @cd_prestador, cd_agendamento = @cd_agendamento, cd_procedimento = @cd_procedimento,cd_consulta = @cd_consulta, username = @username,dt_AtendFinalizado = @dt_atendfinalizado where cd_atendimento = @cd_atendimento";

                //instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);
                cmd.Parameters.Add("@cd_atendimento", SqlDbType.Int);
                cmd.Parameters["@cd_atendimento"].Value = atendimento.CdAtendimento;


                cmd.Parameters.Add("@dt_atendimento", SqlDbType.DateTime);
                cmd.Parameters["@dt_atendimento"].Value = atendimento.DtAtendimento;

                cmd.Parameters.Add("@cd_prestador", SqlDbType.Int);
                cmd.Parameters["@cd_prestador"].Value = atendimento.Prestador.CdPrestador;

                cmd.Parameters.Add("@cd_agendamento", SqlDbType.Int);
                cmd.Parameters["@cd_agendamento"].Value = atendimento.Agendamento.CdAgendamento;

                cmd.Parameters.Add("@cd_procedimento", SqlDbType.Int);
                cmd.Parameters["@cd_procedimento"].Value = atendimento.Procedimento.CdProcedimento;

                cmd.Parameters.Add("@cd_consulta", SqlDbType.Int);
                cmd.Parameters["@cd_consulta"].Value = atendimento.TipoConsulta.CdConsulta;

                cmd.Parameters.Add("@username", SqlDbType.VarChar);
                cmd.Parameters["@username"].Value = atendimento.Usuario.UserName;

                cmd.Parameters.Add("@dt_Atendfinalizado", SqlDbType.VarChar);
                cmd.Parameters["@dt_Atendfinalizado"].Value = atendimento.DtAtendFinalizado;


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
            #endregion
        }


        public void excluir(Atendimento atendimento){
            #region Excluir Atendimento
            try
            {
                //abrir a conexão
                this.abrirConexao();
                string sql = "delete from atendimento where cd_atendimento = @cd_atendimento";
                //instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);
                cmd.Parameters.Add("@cd_atendimento", SqlDbType.Int);
                cmd.Parameters["@cd_atendimento"].Value = atendimento.CdAtendimento;
                //executando a instrucao 
                cmd.ExecuteNonQuery();
                //liberando a memoria 
                cmd.Dispose();
                //fechando a conexao
                this.fecharConexao();
             }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conectar e remover " + ex.Message);
            }
            #endregion
        }


        public void gerar(Atendimento atendimento)
        {
            #region Atender Paciente
            try
            {
                //abrir a conexão
                this.abrirConexao();
                string sql = "INSERT INTO atendimento(dt_atendimento, cd_prestador, cd_agendamento, cd_procedimento,cd_consulta, username, dt_atendfinalizado)";
                sql += "VALUES(@dt_atendimento, @cd_prestador, @cd_agendamento, @cd_procedimento,@cd_consulta, @username, @dt_atendFinalizado)";
                //instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

                cmd.Parameters.Add("@dt_atendimento", SqlDbType.DateTime);
                cmd.Parameters["@dt_atendimento"].Value = atendimento.DtAtendimento;

                cmd.Parameters.Add("@cd_prestador", SqlDbType.Int);
                cmd.Parameters["@cd_prestador"].Value = atendimento.Prestador.CdPrestador;

                cmd.Parameters.Add("@cd_agendamento", SqlDbType.Int);
                cmd.Parameters["@cd_agendamento"].Value = atendimento.Agendamento.CdAgendamento;

                cmd.Parameters.Add("@cd_procedimento", SqlDbType.Int);
                cmd.Parameters["@cd_procedimento"].Value = atendimento.Procedimento.CdProcedimento;

                cmd.Parameters.Add("@cd_consulta", SqlDbType.Int);
                cmd.Parameters["@cd_consulta"].Value = atendimento.TipoConsulta.CdConsulta;

                cmd.Parameters.Add("@username", SqlDbType.VarChar);
                cmd.Parameters["@username"].Value = atendimento.Usuario.UserName;

                cmd.Parameters.Add("@dt_Atendfinalizado", SqlDbType.DateTime);
                cmd.Parameters["@dt_Atendfinalizado"].Value = atendimento.DtAtendFinalizado;

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
            #endregion
        }


        
        public List<Atendimento> listarAtendimentos(Atendimento filtro)
        {
            #region Listar ou consultar atendimentos
            List<Atendimento> retorno = new List<Atendimento>();

            try
            {

                this.abrirConexao();

                string sql= " select a.Cd_Agendamento, a.Cd_Atendimento, b.Cd_Paciente,c.Nm_Paciente,a.Cd_Consulta,d.Nm_Consulta,a.Dt_Atendimento,a.Cd_Prestador,p.Nm_Prestador,a.Cd_Procedimento,g.Nm_Procedimento ";
                sql += "from atendimento a ";
                sql += "inner join Agendamento b on b.Cd_Agendamento = a.Cd_Agendamento ";
                sql += "inner join Paciente c on c.Cd_Paciente = b.Cd_Paciente ";
                sql += "inner join Tipo_Consulta d on d.Cd_Consulta = a.Cd_Consulta ";
                sql += "inner join Prestador p on p.Cd_Prestador = b.Cd_Prestador ";
                sql += "inner join Procedimento g on g.Cd_Procedimento = a.Cd_Procedimento ";

                if (filtro.CdAtendimento > 0)
                {
                    sql += " WHERE a.Cd_Atendimento = @Cd_Atendimento ";
                  
                }

                

                if (filtro.Prestador != null && filtro.Prestador.CdPrestador > 0)
                {
                    sql += " and cd_prestador = @Cd_Prestador ";
                }

                if (filtro.Agendamento.CdAgendamento > 0)
                {
                    sql += " WHERE a.Cd_Agendamento = @Cd_Agendamento ";

                }

                SqlCommand cmd = new SqlCommand(sql, sqlConn);

                if (filtro.CdAtendimento > 0)
                {
                    cmd.Parameters.Add("@Cd_Atendimento", SqlDbType.Int);
                    cmd.Parameters["@Cd_Atendimento"].Value = filtro.CdAtendimento;
                }
                if (filtro.Prestador != null && filtro.Prestador.CdPrestador > 0)
                {
                    cmd.Parameters.Add("@Cd_Prestador", SqlDbType.Int);
                    cmd.Parameters["@Cd_Prestador"].Value = filtro.Prestador.CdPrestador;
                }
                if (filtro.Agendamento.CdAgendamento > 0)
                {
                    cmd.Parameters.Add("@Cd_Agendamento", SqlDbType.Int);
                    cmd.Parameters["@Cd_Agendamento"].Value = filtro.Agendamento.CdAgendamento;

                }

                SqlDataReader DbReader = cmd.ExecuteReader();


                while (DbReader.Read())
                {
                    Atendimento atendimento = new Atendimento();
                    //acessando os valores das colunas do resultado
                    atendimento.Agendamento.CdAgendamento = DbReader.GetInt32(DbReader.GetOrdinal("Cd_Agendamento"));
                    atendimento.CdAtendimento = DbReader.GetInt32(DbReader.GetOrdinal("Cd_Atendimento"));
                    atendimento.Agendamento.Paciente.CdPaciente = DbReader.GetInt32(DbReader.GetOrdinal("Cd_Paciente"));
                    atendimento.Agendamento.Paciente.NmPaciente = DbReader.GetString(DbReader.GetOrdinal("Nm_Paciente"));
                    atendimento.TipoConsulta.CdConsulta = DbReader.GetInt32(DbReader.GetOrdinal("Cd_Consulta"));
                    atendimento.TipoConsulta.NmConsulta = DbReader.GetString(DbReader.GetOrdinal("Nm_Consulta"));
                    atendimento.DtAtendimento = DbReader.GetDateTime(DbReader.GetOrdinal("Dt_atendimento"));
                    atendimento.Prestador.CdPrestador = DbReader.GetInt32(DbReader.GetOrdinal("Cd_Prestador"));
                    atendimento.Prestador.NmPrestador = DbReader.GetString(DbReader.GetOrdinal("Nm_Prestador"));
                    atendimento.Procedimento.CdProcedimento = DbReader.GetString(DbReader.GetOrdinal("Cd_Procedimento"));
                    atendimento.Procedimento.NmProcedimento = DbReader.GetString(DbReader.GetOrdinal("Nm_Procedimento"));
                    retorno.Add(atendimento);
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
                throw new Exception("Falha ao Listar o(s) Atendimentos) " + ex.Message);
            }
            return retorno;
            #endregion
        }

        


    }
}

