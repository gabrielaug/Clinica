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

        public void Agendar(Agendamento agendamento)
        {
            DAOPaciente daoPaciente = new DAOPaciente();


       



        }

        public void Excluir(Agendamento agendamento)
        {
            throw new NotImplementedException();
        }

        public List<Agendamento> ListaAgendamentos(Agendamento agendamento)
        {
            throw new NotImplementedException();
        }

        public void Remarcar(Agendamento agendamento)
        {
            throw new NotImplementedException();
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
