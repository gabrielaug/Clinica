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

        public void AtualizarAtendimento(Atendimento atendimento)
        {
            dao.AtualizarAtendimento(atendimento);
        }

        public void ExcluirAtendimento(Atendimento atendimento)
        {
            Atendimento atend = new Atendimento();

            atend = dao.ListarAtendimentos(atendimento).Last();

            if (atend.CdAtendimento == atendimento.CdAtendimento)
            {
                if(atend.Procedimento.CdProcedimento.Trim().Equals("") || atend.Procedimento.CdProcedimento == null)
                {
                    dao.ExcluirAtendimento(atendimento);
                }
                else
                {
                    throw new Exception("Erro ao tentar excluir atendimento com Procedimento.");
                }
                

            }
            
        }

        public void GerarAtendimento(Atendimento atendimento)
        {
            if (ValidarAtributos(atendimento))
            {
                dao.GerarAtendimento(atendimento);
            }

        }

        public List<Atendimento> ListarAtendimentos(Atendimento atendimento)
        {
            return dao.ListarAtendimentos(atendimento);
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
