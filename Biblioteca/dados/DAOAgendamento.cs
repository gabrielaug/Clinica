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
   public class DAOAgendamento : ConexaoSqlServer, InterfaceAgendamento
    {
        
        public void Agendar(Agendamento agendamento)
        {
            #region Agendar atendimento
            try
            {
                //abrir a conexão
                this.abrirConexao();
                string sql = "INSERT INTO Agendamento (Dt_Consulta, Cd_Paciente, Cd_Prestador, UserName)";
                sql += " VALUES(@Dt_Consulta, @Cd_Paciente, @Cd_Prestador, @UserName)";
                //instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

                cmd.Parameters.Add("@Dt_Consulta", SqlDbType.DateTime);
                cmd.Parameters["@Dt_Consulta"].Value = agendamento.DtConsulta;

                cmd.Parameters.Add("@Cd_Paciente", SqlDbType.Int);
                cmd.Parameters["@Cd_Paciente"].Value = agendamento.Paciente.CdPaciente;

                cmd.Parameters.Add("@Cd_Prestador", SqlDbType.Int);
                cmd.Parameters["@Cd_Prestador"].Value = agendamento.Prestador.CdPrestador;

                cmd.Parameters.Add("@UserName", SqlDbType.VarChar);
                cmd.Parameters["@UserName"].Value = agendamento.Usuario.UserName;

                //executando a instrucao 
                cmd.ExecuteNonQuery();
                //liberando a memoria 
                cmd.Dispose();
                //fechando a conexao
                this.fecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar gerar agendamento " + ex.Message);
            }
            #endregion
        }

        public void Excluir(Agendamento agendamento)
        {
            #region Excluir Agendamento
            try
            {
                //abrir a conexão
                this.abrirConexao();
                string sql = "DELETE FROM Agendamento WHERE Cd_Agendamento = @Cd_Agendamento";
                //instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);
                cmd.Parameters.Add("@Cd_Agendamento", SqlDbType.Int);
                cmd.Parameters["@Cd_Agendamento"].Value = agendamento.CdAgendamento;
                //executando a instrucao 
                cmd.ExecuteNonQuery();
                //liberando a memoria 
                cmd.Dispose();
                //fechando a conexao
                this.fecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar excluir Agendamento " + ex.Message);
            }
            #endregion
        }

        public void Remarcar(Agendamento agendamento)
        {
            #region Remarcar agendamento
            try
            {
                //abrir a conexão
                this.abrirConexao();
                string sql = "UPDATE Agendamento SET Dt_Consulta = @Dt_Consulta, ";
                sql += " Cd_Prestador = @Cd_Prestador, UserName = @UserName WHERE Cd_Agendamento = @Cd_Agendamento";

                //instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

                cmd.Parameters.Add("@Dt_Consulta", SqlDbType.DateTime);
                cmd.Parameters["@Dt_Consulta"].Value = agendamento.DtConsulta;

                cmd.Parameters.Add("@Cd_Prestador", SqlDbType.Int);
                cmd.Parameters["@Cd_Prestador"].Value = agendamento.Prestador.CdPrestador;

                cmd.Parameters.Add("@UserName", SqlDbType.VarChar);
                cmd.Parameters["@UserName"].Value = agendamento.Usuario.UserName;

                cmd.Parameters.Add("@Cd_Agendamento", SqlDbType.Int);
                cmd.Parameters["@Cd_Agendamento"].Value = agendamento.CdAgendamento;


                //executando a instrucao 
                cmd.ExecuteNonQuery();
                //liberando a memoria 
                cmd.Dispose();
                //fechando a conexao
                this.fecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar Remarcar agendamento " + ex.Message);
            }
            #endregion

        }

               
        public List<Agendamento> ListaAgendamentos(Agendamento filtro)
        {
            #region Listar Agendamentos
            List<Agendamento> retorno = new List<Agendamento>();

            try
            {

                this.abrirConexao();

                string sql;

                sql = " SELECT a.Cd_Agendamento, a.Cd_Paciente, b.Nm_Paciente, a.Dt_Consulta, a.Cd_Prestador, c.Nm_Prestador, a.UserName";

                sql += " FROM Agendamento as a INNER JOIN Paciente as b on a.Cd_Paciente = b.Cd_Paciente";
                sql += " INNER JOIN Prestador as c on a.Cd_Prestador = c.Cd_Prestador";
                sql += " INNER JOIN Usuario as d on a.UserName = d.UserName";


                if (filtro.CdAgendamento > 0)
                {
                    sql += " WHERE a.Cd_Agendamento = @Cd_Agendamento ";
                }

                SqlCommand cmd = new SqlCommand(sql, sqlConn);

                if (filtro.CdAgendamento > 0)
                {
                    cmd.Parameters.Add("@Cd_Agendamento", SqlDbType.Int);
                    cmd.Parameters["@Cd_Agendamento"].Value = filtro.CdAgendamento;
                }


                SqlDataReader DbReader = cmd.ExecuteReader();


                while (DbReader.Read())
                {
                    Agendamento agendamento = new Agendamento();
                    //acessando os valores das colunas do resultado
                    agendamento.CdAgendamento = DbReader.GetInt32(DbReader.GetOrdinal("Cd_Agendamento"));
                    agendamento.Paciente.CdPaciente = DbReader.GetInt32(DbReader.GetOrdinal("Cd_Paciente"));
                    agendamento.Paciente.NmPaciente = DbReader.GetString(DbReader.GetOrdinal("Nm_Paciente"));
                    agendamento.DtConsulta = DbReader.GetDateTime(DbReader.GetOrdinal("Dt_Consulta"));
                    agendamento.Prestador.CdPrestador = DbReader.GetInt32(DbReader.GetOrdinal("Cd_Prestador"));
                    agendamento.Prestador.NmPrestador = DbReader.GetString(DbReader.GetOrdinal("Nm_Prestador"));
                    agendamento.Usuario.UserName = DbReader.GetString(DbReader.GetOrdinal("UserName"));
                    retorno.Add(agendamento);
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
                throw new Exception("Falha ao Listar os Agendamentos " + ex.Message);
            }
            return retorno;
            #endregion
        }


        public Agendamento PesqAgendamento(Agendamento filtro)
        {
            #region Verificar se existe Agendamento pro paciente na mesma data e hora.
            Agendamento retorno = new Agendamento();

            try
            {

                this.abrirConexao();

                string sql;

                sql = "SELECT Cd_Agendamento,Dt_Consulta,Cd_Paciente,Cd_Prestador,UserName FROM Agendamento ";
                sql += "WHERE Cd_Paciente = @Cd_Paciente AND Dt_Consulta = @Dt_Consulta";


                SqlCommand cmd = new SqlCommand(sql, sqlConn);

                cmd.Parameters.Add("@Cd_Paciente", SqlDbType.Int);
                cmd.Parameters["@Cd_Paciente"].Value = filtro.Paciente.CdPaciente;

                cmd.Parameters.Add("@Dt_Consulta", SqlDbType.DateTime);
                cmd.Parameters["@Dt_Consulta"].Value = filtro.DtConsulta;


                SqlDataReader DbReader = cmd.ExecuteReader();


                if (DbReader.Read())
                {
                    Agendamento agendamento = new Agendamento();
                    agendamento.CdAgendamento = DbReader.GetInt32(DbReader.GetOrdinal("Cd_Agendamento"));
                    agendamento.Paciente.CdPaciente = DbReader.GetInt32(DbReader.GetOrdinal("Cd_Paciente"));
                    agendamento.DtConsulta = DbReader.GetDateTime(DbReader.GetOrdinal("Dt_Consulta"));
                    agendamento.Prestador.CdPrestador = DbReader.GetInt32(DbReader.GetOrdinal("Cd_Prestador"));
                    agendamento.Usuario.UserName = DbReader.GetString(DbReader.GetOrdinal("UserName"));
                    retorno = agendamento;

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
                throw new Exception("Falha ao Pesquisar Agendamento " + ex.Message);
            }

            return retorno;
            #endregion

        }


        public Agendamento PesqAgendamentoPrestador(Agendamento filtro)
        {
            #region Verificar se existe Agendamento pro prestador na mesma data e hora.
            Agendamento retorno = new Agendamento();

            try
            {

                this.abrirConexao();

                string sql;

                sql = "SELECT Cd_Agendamento,Dt_Consulta,Cd_Paciente,Cd_Prestador,UserName FROM Agendamento ";
                sql += "WHERE Cd_Prestador = @Cd_Prestador AND Dt_Consulta = @Dt_Consulta";


                SqlCommand cmd = new SqlCommand(sql, sqlConn);

                cmd.Parameters.Add("@Cd_Prestador", SqlDbType.Int);
                cmd.Parameters["@Cd_Prestador"].Value = filtro.Prestador.CdPrestador;

                cmd.Parameters.Add("@Dt_Consulta", SqlDbType.DateTime);
                cmd.Parameters["@Dt_Consulta"].Value = filtro.DtConsulta;


                SqlDataReader DbReader = cmd.ExecuteReader();


                if (DbReader.Read())
                {
                    Agendamento agendamento = new Agendamento();
                    agendamento.CdAgendamento = DbReader.GetInt32(DbReader.GetOrdinal("Cd_Agendamento"));
                    agendamento.Paciente.CdPaciente = DbReader.GetInt32(DbReader.GetOrdinal("Cd_Paciente"));
                    agendamento.DtConsulta = DbReader.GetDateTime(DbReader.GetOrdinal("Dt_Consulta"));
                    agendamento.Prestador.CdPrestador = DbReader.GetInt32(DbReader.GetOrdinal("Cd_Prestador"));
                    agendamento.Usuario.UserName = DbReader.GetString(DbReader.GetOrdinal("UserName"));
                    retorno = agendamento;

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
                throw new Exception("Falha ao Pesquisar Agendamento por Prestador " + ex.Message);
            }

            return retorno;
            #endregion

        }




    }

}