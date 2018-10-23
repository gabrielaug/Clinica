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
    class DAOPaciente : ConexaoSqlServer, InterfacePaciente
    {
        
        public void Alterar(Paciente paciente)
        {
            #region Alterar o Paciente
            try
            {
                //abrir a conexão
                this.abrirConexao();
                string sql = "UPDATE Paciente SET";
                sql += "Nm_Paciente = @Nm_Paciente,Nm_Mae = @Nm_Mae ,Nm_Pai = @Nm_Pai,Nm_Social = @Nm_Social,CPF = @CPF,RG = @RG,Dt_Nascimento = @Dt_Nascimento,";
                sql += "Telefone = @Telefone,Endereco = @Endereco,Email = @Email,Cidade = @Cidade,Bairro = @Bairro,Estado = @Estado WHERE Cd_Paciente = @Cd_Paciente;";

                //instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

                cmd.Parameters.Add("@Nm_Paciente", SqlDbType.VarChar);
                cmd.Parameters["@Nm_Paciente"].Value = paciente.NmPaciente;

                cmd.Parameters.Add("@Nm_Mae", SqlDbType.VarChar);
                cmd.Parameters["@Nm_Mae"].Value = paciente.NmMae;

                cmd.Parameters.Add("@Nm_Pai", SqlDbType.VarChar);
                cmd.Parameters["@Nm_Pai"].Value = paciente.NmPai;

                cmd.Parameters.Add("@Nm_Social", SqlDbType.VarChar);
                cmd.Parameters["@Nm_Social"].Value = paciente.NmSocial;

                cmd.Parameters.Add("@CPF", SqlDbType.VarChar);
                cmd.Parameters["@CPF"].Value = paciente.Cpf;

                cmd.Parameters.Add("@RG", SqlDbType.VarChar);
                cmd.Parameters["@RG"].Value = paciente.Rg;

                cmd.Parameters.Add("@Dt_Nascimento", SqlDbType.DateTime);
                cmd.Parameters["@Dt_Nascimento"].Value = paciente.DtNascimento;

                cmd.Parameters.Add("@Telefone", SqlDbType.VarChar);
                cmd.Parameters["@Telefone"].Value = paciente.Telefone;

                cmd.Parameters.Add("@Endereco", SqlDbType.VarChar);
                cmd.Parameters["@Endereco"].Value = paciente.Endereco;

                cmd.Parameters.Add("@Email", SqlDbType.VarChar);
                cmd.Parameters["@Email"].Value = paciente.Email;

                cmd.Parameters.Add("@Cidade", SqlDbType.VarChar);
                cmd.Parameters["@Cidade"].Value = paciente.Cidade;

                cmd.Parameters.Add("@Bairro", SqlDbType.VarChar);
                cmd.Parameters["@Bairro"].Value = paciente.Bairro;

                cmd.Parameters.Add("@Estado", SqlDbType.VarChar);
                cmd.Parameters["@Estado"].Value = paciente.Estado;

                cmd.Parameters.Add("@Cd_Paciente", SqlDbType.Int);
                cmd.Parameters["@Cd_Paciente"].Value = paciente.CdPaciente;


                //executando a instrucao 
                cmd.ExecuteNonQuery();
                //liberando a memoria 
                cmd.Dispose();
                //fechando a conexao
                this.fecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception("Falha ao tentar Alterar o Paciente. " + ex.Message);
            }
            #endregion
        }

        public void Cadastrar(Paciente paciente)
        {
        #region Cadastro de Paciente
            try
            {
                //abrir a conexão
                this.abrirConexao();
                string sql = "INSERT INTO Paciente";
                sql += "(Nm_Paciente,Nm_Mae,Nm_Pai,Nm_Social,CPF,RG,Dt_Nascimento,Telefone,Endereco,Email,Cidade,Bairro,Estado)";
                sql += "values(@Nm_Paciente,@Nm_Mae,@Nm_Pai,@Nm_Social,@CPF,@RG,@Dt_Nascimento,@Telefone,@Endereco,@Email,@Cidade,@Bairro,@Estado)";
                //instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

                cmd.Parameters.Add("@Nm_Paciente", SqlDbType.VarChar);
                cmd.Parameters["@Nm_Paciente"].Value = paciente.NmPaciente;

                cmd.Parameters.Add("@Nm_Mae", SqlDbType.VarChar);
                cmd.Parameters["@Nm_Mae"].Value = paciente.NmMae;

                cmd.Parameters.Add("@Nm_Pai", SqlDbType.VarChar);
                cmd.Parameters["@Nm_Pai"].Value = paciente.NmPai;

                cmd.Parameters.Add("@Nm_Social", SqlDbType.VarChar);
                cmd.Parameters["@Nm_Social"].Value = paciente.NmSocial;

                cmd.Parameters.Add("@CPF", SqlDbType.VarChar);
                cmd.Parameters["@CPF"].Value = paciente.Cpf;

                cmd.Parameters.Add("@RG", SqlDbType.VarChar);
                cmd.Parameters["@RG"].Value = paciente.Rg;

                cmd.Parameters.Add("@Dt_Nascimento", SqlDbType.DateTime);
                cmd.Parameters["@Dt_Nascimento"].Value = paciente.DtNascimento;

                cmd.Parameters.Add("@Telefone", SqlDbType.VarChar);
                cmd.Parameters["@Telefone"].Value = paciente.Telefone;

                cmd.Parameters.Add("@Endereco", SqlDbType.VarChar);
                cmd.Parameters["@Endereco"].Value = paciente.Endereco;

                cmd.Parameters.Add("@Email", SqlDbType.VarChar);
                cmd.Parameters["@Email"].Value = paciente.Email;

                cmd.Parameters.Add("@Cidade", SqlDbType.VarChar);
                cmd.Parameters["@Cidade"].Value = paciente.Cidade;

                cmd.Parameters.Add("@Bairro", SqlDbType.VarChar);
                cmd.Parameters["@Bairro"].Value = paciente.Bairro;

                cmd.Parameters.Add("@Estado", SqlDbType.VarChar);
                cmd.Parameters["@Estado"].Value = paciente.Estado;




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

        public List<Paciente> ListaPaciente(Paciente filtro)
        {


            List<Paciente> retorno = new List<Paciente>();

            try
            {

                this.abrirConexao();

                string sql;

                sql = "SELECT Nm_Paciente,Nm_Mae,Nm_Pai,Nm_Social,CPF,RG,Dt_Nascimento,Telefone,Endereco,Email,Cidade,Bairro,Estado FROM Paciente ";

                if(filtro.CdPaciente > 0)
                {
                    sql += "WHERE Cd_Paciente = @Cd_Paciente";

                }

                if (filtro.NmPaciente != null && filtro.NmPaciente.Trim().Equals("") == false)
                {
                    sql += "WHERE LIKE @NmPaciente";
                
                }

                SqlCommand cmd = new SqlCommand(sql, sqlConn);

                if (filtro.CdPaciente > 0)
                {
                    cmd.Parameters.Add("@Cd_Paciente", SqlDbType.Int);
                    cmd.Parameters["@Cd_Paciente"].Value = filtro.CdPaciente;
                }

                if (filtro.NmPaciente != null && filtro.NmPaciente.Trim().Equals("") == false)
                {
                    cmd.Parameters.Add("@nome", SqlDbType.VarChar);
                    cmd.Parameters["@nome"].Value = filtro.NmPaciente;

                }

                SqlDataReader DbReader = cmd.ExecuteReader();

                
                while (DbReader.Read())
                {
                    Paciente paciente = new Paciente();
                    //acessando os valores das colunas do resultado
                    paciente.CdPaciente = DbReader.GetInt32(DbReader.GetOrdinal("Cd_Paciente"));
                    paciente.NmPaciente = DbReader.GetString(DbReader.GetOrdinal("Nm_Paciente"));
                    paciente.NmMae = DbReader.GetString(DbReader.GetOrdinal("Nm_Mae"));
                    paciente.NmPai = DbReader.GetString(DbReader.GetOrdinal("Nm_Pai"));
                    paciente.NmSocial = DbReader.GetString(DbReader.GetOrdinal("Nm_Social"));
                    paciente.Cpf = DbReader.GetString(DbReader.GetOrdinal("CPF"));
                    paciente.Rg = DbReader.GetString(DbReader.GetOrdinal("RG"));
                    paciente.DtNascimento = DbReader.GetDateTime(DbReader.GetOrdinal("Dt_Nascimento"));
                    paciente.Telefone = DbReader.GetString(DbReader.GetOrdinal("Telefone"));
                    paciente.Endereco = DbReader.GetString(DbReader.GetOrdinal("Endereco"));
                    paciente.Email = DbReader.GetString(DbReader.GetOrdinal("Email"));
                    paciente.Cidade = DbReader.GetString(DbReader.GetOrdinal("Cidade"));
                    paciente.Bairro = DbReader.GetString(DbReader.GetOrdinal("Bairro"));
                    paciente.Estado = DbReader.GetString(DbReader.GetOrdinal("Estado"));

                    retorno.Add(paciente);
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
                throw new Exception("Falha ao Listar o  Paciente " + ex.Message);
            }
            return retorno;

        }
    }
}
