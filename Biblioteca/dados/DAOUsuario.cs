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
    public class DAOUsuario : ConexaoSqlServer, InterfaceUsuario
    {

        public void CadastrarUsuario(Usuario usuario)
        {
            #region Cadastro de Usuario
            try
            {
                this.abrirConexao();
                string sql = "INSERT INTO Usuario";
                sql += "(UserName,Senha,Nome) VALUES (@UserName,@Senha,@Nome)";
                //instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

                cmd.Parameters.Add("@UserName", SqlDbType.VarChar);
                cmd.Parameters["@UserName"].Value = usuario.UserName;

                cmd.Parameters.Add("@Senha", SqlDbType.VarChar);
                cmd.Parameters["@Senha"].Value = usuario.Senha;

                cmd.Parameters.Add("@Nome", SqlDbType.VarChar);
                cmd.Parameters["@Nome"].Value = usuario.Nome;

                //executando a instrucao 
                cmd.ExecuteNonQuery();
                //liberando a memoria 
                cmd.Dispose();
                //fechando a conexao
                this.fecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception("Falha ao tentar Cadastrar Usuario. " + ex.Message);

            }


    #endregion
}

        public void AlterarUsuario(Usuario usuario)
        {
            #region Alterar Usuario
            try
            {
                this.abrirConexao();
                string sql = "UPDATE Usuario SET sn_Ativo = @sn_Ativo ";

                if(usuario.Senha != null && !usuario.Senha.Trim().Equals(""))
                {
                    sql += ",Senha = @Senha WHERE UserName = @UserName ";
                }
                else
                {
                    sql += "WHERE UserName = @UserName ";
                }

                //instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

                if (usuario.Senha != null && !usuario.Senha.Trim().Equals(""))
                {
                    cmd.Parameters.Add("@Senha", SqlDbType.VarChar);
                    cmd.Parameters["@Senha"].Value = usuario.Senha; ;

                    cmd.Parameters.Add("@UserName", SqlDbType.VarChar);
                    cmd.Parameters["@UserName"].Value = usuario.UserName;
                }
                else
                {

                    cmd.Parameters.Add("@UserName", SqlDbType.VarChar);
                    cmd.Parameters["@UserName"].Value = usuario.UserName;

                }
                cmd.Parameters.Add("@sn_Ativo", SqlDbType.VarChar);
                cmd.Parameters["@sn_Ativo"].Value = usuario.SnAtivo;


                //executando a instrucao 
                cmd.ExecuteNonQuery();
                //liberando a memoria 
                cmd.Dispose();
                //fechando a conexao
                this.fecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception("Falha ao tentar Alterar Usuario. " + ex.Message);

            }


            #endregion

        }

        public List<Usuario> ListarUsuarios(Usuario filtro)
        {
            #region Listar Usuario
            List<Usuario> retorno = new List<Usuario>();

            try
            {

                this.abrirConexao();

                string sql;

                sql = "SELECT UserName,Senha,Nome,sn_Ativo FROM Usuario ";


                if (filtro.UserName != null && filtro.UserName.Trim().Equals("") == false)
                {
                    sql += " WHERE UserName LIKE @UserName";

                }

                SqlCommand cmd = new SqlCommand(sql, sqlConn);

                if (filtro.UserName != null && filtro.UserName.Trim().Equals("") == false)
                {
                    cmd.Parameters.Add("@UserName", SqlDbType.VarChar);
                    cmd.Parameters["@UserName"].Value = "%" + filtro.UserName+ "%";

                }

                SqlDataReader DbReader = cmd.ExecuteReader();


                while (DbReader.Read())
                {
                    Usuario usuario = new Usuario();
                    //acessando os valores das colunas do resultado
                    usuario.UserName = DbReader.GetString(DbReader.GetOrdinal("UserName"));
                    usuario.Senha = DbReader.GetString(DbReader.GetOrdinal("Senha"));
                    usuario.Nome = DbReader.GetString(DbReader.GetOrdinal("Nome"));
                    usuario.SnAtivo = DbReader.GetString(DbReader.GetOrdinal("sn_Ativo"));
                    retorno.Add(usuario);
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
                throw new Exception("Falha ao Listar o  Usuario " + ex.Message);
            }
            return retorno;

            #endregion
        }
    }
}
