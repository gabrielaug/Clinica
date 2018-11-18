using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Basicas;
using Biblioteca.dados;
using Biblioteca.interfaces;

namespace Biblioteca.negocio
{
    

    public class RNUsuario: InterfaceUsuario
    {

        private DAOUsuario dao;

        public RNUsuario()
        {
              dao = new DAOUsuario();
        }


        public void CadastrarUsuario(Usuario usuario)
        {
            if (usuario != null)
            {


                try
                {
                    ValidarAtributos(usuario);
                    dao.CadastrarUsuario(usuario);
                }
                catch
                {
                    throw new Exception("Usuário já cadastrado.");
                }

            }
            
        }

        public void AlterarUsuario(Usuario usuario)
        {
            if (usuario != null)
            {


                try
                {
                    ValidarAtributos(usuario);
                    dao.AlterarUsuario(usuario);
                }
                catch
                {
                    throw new Exception("Registro alterado com sucesso.");
                }

            }

        }

        public List<Usuario> ListarUsuarios(Usuario filtro)
        {
            return dao.ListarUsuarios(filtro);
        }


        bool ValidarAtributos(Usuario us)
        {
            if (us.UserName == null || us.UserName.Trim().Equals(""))
            {
                throw new Exception("Nome do Usuário invalido.");
            }

            return true;

        }


    }
}
