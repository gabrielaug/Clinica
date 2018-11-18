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
    public class RNAgendamento: InterfaceAgendamento
    {
        private DAOAgendamento dao;


        public RNAgendamento()
        {
            dao = new DAOAgendamento();
        }

        public void AgendarAgendamento(Agendamento agendamento)
        {
            #region Agendar atendimento
            Agendamento agend = new Agendamento();

            agend = dao.PesqAgendamento(agendamento);
            if (agend.DtConsulta != agendamento.DtConsulta)
            {
                if(dao.PesqAgendamentoPrestador(agendamento).DtConsulta != agendamento.DtConsulta)
                {
                    dao.AgendarAgendamento(agendamento);
                }
                else
                {
                    throw new Exception("Já existe agendamento para este prestador nessa mesma data e hora.");
                }
                

            }else
            {
                throw new Exception("Já existe agendamento para este paciente neste horário.");
            }
            #endregion
        }

        public void ExcluirAgendamento(Agendamento agendamento)
        {
            #region Excluir Agendamento se não possuir atendimento
            

                Atendimento atendimento = new Atendimento();
                DAOAtendimento daoA = new DAOAtendimento();

                Agendamento agend = new Agendamento();

                atendimento.Agendamento = agendamento;

                foreach (Atendimento i in daoA.ListarAtendimentos(atendimento))
                {
                    agend = i.Agendamento;
                }

                if (agend.CdAgendamento == agendamento.CdAgendamento)
                {
                    throw new Exception("Não é possivel Excluir Agendamento com Atendimento.");
                }
                else
                {
                    dao.ExcluirAgendamento(agendamento);
                }

            
            #endregion
        }

        public List<Agendamento> ListaAgendamentos(Agendamento agendamento)
        {
            return dao.ListaAgendamentos(agendamento);
        }

        public void RemarcarAgendamento(Agendamento agendamento)
        {
            #region Remarcar Agendamento sem Atendimento
            Atendimento atendimento = new Atendimento();
            DAOAtendimento daoA = new DAOAtendimento();

            Agendamento agend = new Agendamento();

            atendimento.Agendamento = agendamento;

            foreach(Atendimento i in daoA.ListarAtendimentos(atendimento))
            {
                agend = i.Agendamento;
            }
            
            if(agend.CdAgendamento == agendamento.CdAgendamento)
            {
                throw new Exception("Não é possivel remarcar um agendamento que possui um atendimento.");
            }
            else
            {
                dao.RemarcarAgendamento(agendamento);
            }

            #endregion
        }

        #region Verificar Atributos
        bool VerificarAtributos(Agendamento agendamento)
        {
            if (agendamento.DtConsulta == null)
            {
                throw new Exception("Data da consulta invalido.");
            }


            return true;
        }
        #endregion
    }
}
