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
    class DAOAgendamento : ConexaoSqlServer, InterfaceAgendamento
    {
        #region Agendar Paciente
        public void Agendar(Agendamento agendamento)
        {
            try
            {
                //abrir a conexão
                this.abrirConexao();
                string sql = "INSERT INTO agendamento(dt_consulta, hr_consulta, cd_paciente, cd_prestador, username)";
                sql += "VALUES(@dt_consulta, @hr_consulta, @cd_paciente, @cd_prestador, @username)";
                //instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

                cmd.Parameters.Add("@dt_consulta", SqlDbType.DateTime);
                cmd.Parameters["@dt_consulta"].Value = agendamento.DtConsulta;

                cmd.Parameters.Add("@hr_consulta", SqlDbType.DateTime);
                cmd.Parameters["@hr_consulta"].Value = agendamento.HrConsulta;

                cmd.Parameters.Add("@cd_paciente", SqlDbType.Int);
                cmd.Parameters["@cd_paciente"].Value = agendamento.Paciente.CdPaciente;

                cmd.Parameters.Add("@cd_prestador", SqlDbType.Int);
                cmd.Parameters["@cd_prestador"].Value = agendamento.Prestador.CdPrestador;

                cmd.Parameters.Add("@username", SqlDbType.VarChar);
                cmd.Parameters["@username"].Value = agendamento.Usuario.UserName;

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
        public void Excluir(Agendamento agendamento)
        {
            try
            {
                //abrir a conexão
                this.abrirConexao();
                string sql = "delete from agendamento where cd_agendamento = @cd_agendamento";
                //instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);
                cmd.Parameters.Add("@cd_agendamento", SqlDbType.Int);
                cmd.Parameters["@cd_agendamento"].Value = agendamento.CdAgendamento;
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

        }

        public void Remarcar(Agendamento agendamento)
        {
            try
            {
                //abrir a conexão
                this.abrirConexao();
                string sql = "update agendamento set dt_consulta = @dt_consulta,hr_consulta = @hr_consulta, cd_paciente = @cd_paciente, cd_prestador = @cd_prestador, username = @username where cd_agendamento = @cd_agendamento";

                //instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

                cmd.Parameters.Add("@dt_consulta", SqlDbType.DateTime);
                cmd.Parameters["@dt_consulta"].Value = agendamento.DtConsulta;

                cmd.Parameters.Add("@hr_consulta", SqlDbType.DateTime);
                cmd.Parameters["@hr_consulta"].Value = agendamento.HrConsulta;

                cmd.Parameters.Add("@cd_paciente", SqlDbType.Int);
                cmd.Parameters["@cd_paciente"].Value = agendamento.Paciente.CdPaciente;

                cmd.Parameters.Add("@cd_prestador", SqlDbType.Int);
                cmd.Parameters["@cd_prestador"].Value = agendamento.Prestador.CdPrestador;

                cmd.Parameters.Add("@username", SqlDbType.VarChar);
                cmd.Parameters["@username"].Value = agendamento.Usuario.UserName;

                //executando a instrucao 
                cmd.ExecuteNonQuery();
                //liberando a memoria 
                cmd.Dispose();
                //fechando a conexao
                this.fecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conectar e remarcar " + ex.Message);
            }
        }

        public List<Agendamento> ListaAgendamentos(Agendamento filtro)
        {
            List<Agendamento> retorno = new List<Agendamento>();

            try
            {

                this.abrirConexao();

                string sql;

                sql = " select a.cd_agendamento, a.cd_paciente, b.nm_paciente, a.dt_consulta, a.hr_consulta, a.cd_prestador, c.nm_prestador nome_prestador, a.username usuario"

                sql += " from Agendamento as a inner join paciente as b on a.cd_paciente = b.cd_paciente";
                sql += " inner join prestador as c on a.cd_prestador = c.cd_prestador";
                sql += "inner join usuario as d on a.username = d.username";
 

                if (filtro.CdAgendamento > 0)
                {
                    sql += " and cd_agendamento = @cd_agendamento ";
                }

                if (filtro.Prestador != null && filtro.Prestador.CdPrestador > 0)
                {
                    sql += " and cd_prestador = @cd_prestador ";
                }

                SqlCommand cmd = new SqlCommand(sql, sqlConn);

                if (filtro.CdAgendamento > 0)
                {
                    cmd.Parameters.Add("@cd_agendamento", SqlDbType.Int);
                    cmd.Parameters["@cd_agendamento"].Value = filtro.CdAgendamento;
                }
                if (filtro.Prestador != null && filtro.Prestador.CdPrestador > 0)
                {
                    cmd.Parameters.Add("@cd_prestador", SqlDbType.Int);
                    cmd.Parameters["@cd_prestador"].Value = filtro.Prestador.CdPrestador;
                }


                SqlDataReader DbReader = cmd.ExecuteReader();


                while (DbReader.Read())
                {
                    Agendamento agendamento = new Agendamento();
                    //acessando os valores das colunas do resultado
                    agendamento.CdAgendamento = DbReader.GetInt32(DbReader.GetOrdinal("Cd_Agendamento"));
                    agendamento.Paciente.CdPaciente = DbReader.GetInt32(DbReader.GetOrdinal("Cd_Paciente"));
                    agendamento.Paciente.NmPaciente = DbReader.GetString(DbReader.GetOrdinal("Nm_Paciente"));
                    agendamento.DtConsulta = DbReader.GetDateTime(DbReader.GetOrdinal("Dt-Consulta"));
                    agendamento.HrConsulta = DbReader.GetDateTime(DbReader.GetOrdinal("Hr-Consulta"));
                    agendamento.Prestador.CdPrestador = DbReader.GetInt32(DbReader.GetOrdinal("Cd_prestador"));
                    agendamento.Prestador.NmPrestador = DbReader.GetString(DbReader.GetOrdinal("Nm_prestador"));
                    agendamento.Usuario.UserName = DbReader.GetString(DbReader.GetOrdinal("UserName"));
                // retorno.Add(agendamento);
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
                throw new Exception("Falha ao Listar o(s) Agendamento9s) " + ex.Message);
            }
            return retorno;

        }

        public List<Agendamento> ListaAgendamentos()
        {
            throw new NotImplementedException();
        }
    }

}