using Biblioteca.Basicas;
using Biblioteca.dados;
using Biblioteca.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.negocio
{
    public class RNPaciente : InterfacePaciente
    {

        private DAOPaciente dao;

        public RNPaciente()
        {
            dao = new DAOPaciente();
        }

        public void Alterar(Paciente paciente)
        {
            if(paciente.CdPaciente > 0)
            {
                try
                {
                    ValidarAtributos(paciente);
                    dao.Alterar(paciente);
                }
                catch
                {
                    
                }
                
            }
            
        }

        public void Cadastrar(Paciente paciente)
        {

            if (paciente != null)
            {
                if (VerificarCPF(paciente))
                {

                    try
                    {
                        ValidarAtributos(paciente);
                        dao.Cadastrar(paciente);
                    }
                    catch
                    {

                    }

                }
                else
                {
                    throw new Exception("CPF já cadastrado.");
                }

            }
        }

        public List<Paciente> ListaPaciente(Paciente filtro)
        {

            return dao.ListaPaciente(filtro);
        }

        public bool VerificarCPF(Paciente paciente)
        {
            return dao.VerificarCPF(paciente);
        }



        #region Validar Atributos de um Paciente

        Boolean ValidarAtributos(Paciente p)
        {
            if (p.NmPaciente == null || p.NmPaciente.Trim().Equals(""))
            {
                throw new Exception("Nome do Paciente invalido.");
            }

            if (p.NmPaciente.Length > 100)
            {
                throw new Exception("Quantidade de Caracteres Invalido Max: 100.");
            }

            if (p.Cpf == null || p.Cpf.Trim().Equals(""))
            {
                throw new Exception("CPF é Obrigatorio.");
            }

            if (p.Cpf.Length > 11)
            {
                throw new Exception("Quantidade de Caracteres Invalido Max: 11.");
            }


            if (p.DtNascimento == null || p.DtNascimento.Equals(""))
            {
                throw new Exception("Data de Nascimento invalido.");
            }

            if (p.Telefone == null || p.Telefone.Trim().Equals(""))
            {
                throw new Exception("Telefone invalido.");
            }

            if (p.Telefone.Length > 15)
            {
                throw new Exception("Quantidade de Caracteres Invalido Max: 15.");
            }

            return true;
        }

        #endregion
    }
}
