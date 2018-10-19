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
            try
            {
                //abrir a conexão
                this.abrirConexao();
                string sql = "INSERT INTO Paciente (matricula,nome,";
                sql += "Nm_Paciente,Nm_Mae,Nm_Pai,Nm_Social,CPF,RG,Dt_Nascimento,Telefone,Endereco,Email,Cidade,Bairro,Estado)";
                sql += "values(@Nm_Paciente,@Nm_Mae,@Nm_Pai,@Nm_Social,@CPF,@RG,@Dt_Nascimento,@Telefone,@Endereco,@Email,@Cidade,@Bairro,@Estado)";
                //instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

                cmd.Parameters.Add("@matricula", SqlDbType.Int);
                cmd.Parameters["@matricula"].Value = aluno.Matricula;

                cmd.Parameters.Add("@nome", SqlDbType.VarChar);
                cmd.Parameters["@nome"].Value = aluno.Nome;

                //executando a instrucao 
                cmd.ExecuteNonQuery();
                //liberando a memoria 
                cmd.Dispose();
                //fechando a conexao
                this.fecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conecar e inserir " + ex.Message);
            }
        }

        public void Cadastrar(Paciente paciente)
        {
            throw new NotImplementedException();
        }

        public List<Paciente> ListaPaciente()
        {
            throw new NotImplementedException();
        }
    }
}
