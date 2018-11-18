using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Biblioteca.Basicas;
using Biblioteca.dados;

namespace ServidorWCF
{
    // OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da classe "Service1" no arquivo de código, svc e configuração ao mesmo tempo.
    // OBSERVAÇÃO: Para iniciar o cliente de teste do WCF para testar esse serviço, selecione Service1.svc ou Service1.svc.cs no Gerenciador de Soluções e inicie a depuração.
    public class Service1 : IService1
    {
        public void AdicionarProcedimento(Procedimento procedimento)
        {
            DAOProcedimento dao = new DAOProcedimento();
            dao.AdicionarProcedimento(procedimento);
        }

        public void AgendarAgendamento(Agendamento agendamento)
        {
            DAOAgendamento dao = new DAOAgendamento();
            dao.AgendarAgendamento(agendamento);
        }

        public void AlterarPaciente(Paciente paciente)
        {
            DAOPaciente dao = new DAOPaciente();
            dao.AlterarPaciente(paciente);
        }

        public void AlterarUsuario(Usuario usuario)
        {
            DAOUsuario dao = new DAOUsuario();
            dao.AlterarUsuario(usuario);
        }

        public void AtuaizarProcedimento(Procedimento procedimento)
        {
            DAOProcedimento dao = new DAOProcedimento();
            dao.AtualizarProcedimento(procedimento);
        }

        public void AtualizarAtendimento(Atendimento atendimento)
        {
            DAOAtendimento dao = new DAOAtendimento();
            dao.AtualizarAtendimento(atendimento);
        }

        public void AtualizarPrestador(Prestador prestador)
        {
            DAOPrestador dao = new DAOPrestador();
            dao.AtualizarPrestador(prestador);
        }

        public void CadastrarConvenio(Convenio convenio)
        {
            DAOConvenio dao = new DAOConvenio();
            dao.CadastrarConvenio(convenio);
        }

        public void CadastrarPaciente(Paciente paciente)
        {
            DAOPaciente dao = new DAOPaciente();
            dao.CadastrarPaciente(paciente);
        }

        public void CadastrarPrestador(Prestador prestador)
        {
            DAOPrestador dao = new DAOPrestador();
            dao.CadastrarPrestador(prestador);
        }

        public void CadastrarUsuario(Usuario usuario)
        {
            DAOUsuario dao = new DAOUsuario();
            dao.CadastrarUsuario(usuario);
        }

        public void ExcluirAgendamento(Agendamento agendamento)
        {
            DAOAgendamento dao = new DAOAgendamento();
            dao.ExcluirAgendamento(agendamento);
        }

        public void ExcluirAtendimento(Atendimento atendimento)
        {
            DAOAtendimento dao = new DAOAtendimento();
            dao.ExcluirAtendimento(atendimento);
        }

        public void GerarAtendimento(Atendimento atendimento)
        {
            DAOAtendimento dao = new DAOAtendimento();
            dao.GerarAtendimento(atendimento);
        }

        public void InativarConvenio(Convenio convenio)
        {
            DAOConvenio dao = new DAOConvenio();
            dao.InativarConvenio(convenio);
        }

        public void InativarPrestador(Prestador prestador)
        {
            DAOPrestador dao = new DAOPrestador();
            dao.InativarPrestador(prestador);
        }

        public void InativarTipoConsulta(TipoConsulta tipoConsulta)
        {
            DAOTipoConsulta dao = new DAOTipoConsulta();
            dao.InativarTipoConsulta(tipoConsulta);
        }

        public void InserirTipoConsulta(TipoConsulta tipoConsulta)
        {
            DAOTipoConsulta dao = new DAOTipoConsulta();
            dao.InserirTipoConsulta(tipoConsulta);
        }

        public List<Agendamento> ListaAgendamentos(Agendamento agendamento)
        {
            DAOAgendamento dao = new DAOAgendamento();
            return dao.ListaAgendamentos(agendamento);
        }

        public List<Paciente> ListaPaciente(Paciente filtro)
        {
            DAOPaciente dao = new DAOPaciente();
            return dao.ListaPaciente(filtro);
        }

        public List<Prestador> ListaPrestadores(Prestador filtro)
        {
            DAOPrestador dao = new DAOPrestador();
            return dao.ListaPrestadores(filtro);
        }

        public List<Atendimento> ListarAtendimentos(Atendimento atendimento)
        {
            DAOAtendimento dao = new DAOAtendimento();
            return dao.ListarAtendimentos(atendimento);
        }

        public List<Convenio> ListarConvenios(Convenio filtro)
        {
            DAOConvenio dao = new DAOConvenio();
            return dao.ListarConvenios(filtro);
        }

        public List<Procedimento> ListarProcedimento(Procedimento procedimento)
        {
            DAOProcedimento dao = new DAOProcedimento();
            return dao.ListarProcedimento(procedimento);
        }

        public List<TipoConsulta> ListarTipoConsulta(TipoConsulta filtro)
        {
            DAOTipoConsulta dao = new DAOTipoConsulta();
            return dao.ListarTipoConsulta(filtro);
        }

        public List<Usuario> ListarUsuarios(Usuario filtro)
        {
            DAOUsuario dao = new DAOUsuario();
            return dao.ListarUsuarios(filtro);
        }

        public void RemarcarAgendamento(Agendamento agendamento)
        {
            DAOAgendamento dao = new DAOAgendamento();
            dao.RemarcarAgendamento(agendamento);
        }
    }
}
