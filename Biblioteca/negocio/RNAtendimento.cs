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
    public class RNAtendimento : InterfaceAtendimento
    {
        DAOAtendimento dao;

        public RNAtendimento()
        {
            dao = new DAOAtendimento();
        }

        public void atualizar(Atendimento atendimento)
        {
            throw new NotImplementedException();
        }

        public void excluir(Atendimento atendimento)
        {
            throw new NotImplementedException();
        }

        public void gerar(Atendimento atendimento)
        {
            if (ValidarAtributos(atendimento))
            {
                dao.gerar(atendimento);
            }

        }

        public List<Atendimento> listarAtendimentos(Atendimento atendimento)
        {
            return dao.listarAtendimentos(atendimento);
        }
        private bool ValidarAtributos(Atendimento atendimento)
        {
            #region Validação
            if (atendimento.Prestador.CdPrestador == 0)
            {
                throw new Exception("Codigo do Prestador Invalido.");
            }

            if(atendimento.Agendamento.CdAgendamento == 0)
            {
                throw new Exception("Codigo de Agendamento Invalido.");
            }

            if(atendimento.TipoConsulta.CdConsulta == 0)
            {
                throw new Exception("Tipo de Consulta Invalida.");
            }

            if(atendimento.Usuario.UserName == null)
            {
                throw new Exception("Usuario Invalido.");
            }
            #endregion

            return true;
        }
    }
}
