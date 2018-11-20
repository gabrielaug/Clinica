using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Biblioteca.Basicas;
using Biblioteca.dados;
using Biblioteca.negocio;

namespace ServidorWCF
{
    // OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da classe "Service1" no arquivo de código, svc e configuração ao mesmo tempo.
    // OBSERVAÇÃO: Para iniciar o cliente de teste do WCF para testar esse serviço, selecione Service1.svc ou Service1.svc.cs no Gerenciador de Soluções e inicie a depuração.
    public class Service1 : IService1
    {
        public void AdicionarProcedimento(Procedimento procedimento)
        {
            RNProcedimento rn = new RNProcedimento();
            rn.AdicionarProcedimento(procedimento);
        }

        public void AgendarAgendamento(Agendamento agendamento)
        {
            RNAgendamento rn = new RNAgendamento();
            rn.AgendarAgendamento(agendamento);
        }

        public void AlterarPaciente(Paciente paciente)
        {
            RNPaciente rn = new RNPaciente();
            rn.AlterarPaciente(paciente);
        }

        public void AlterarUsuario(Usuario usuario)
        {
            RNUsuario rn = new RNUsuario();
            rn.AlterarUsuario(usuario);
        }

        public void AtuaizarProcedimento(Procedimento procedimento)
        {
            RNProcedimento rn = new RNProcedimento();
            rn.AtualizarProcedimento(procedimento);
        }

        public void AtualizarAtendimento(Atendimento atendimento)
        {
            RNAtendimento rn = new RNAtendimento();
            rn.AtualizarAtendimento(atendimento);
        }

        public void AtualizarPrestador(Prestador prestador)
        {
            RNPrestador rn = new RNPrestador();
            rn.AtualizarPrestador(prestador);
        }

        public void CadastrarConvenio(Convenio convenio)
        {
            RNConvenio rn = new RNConvenio();
            rn.CadastrarConvenio(convenio);
        }

        public void CadastrarPaciente(Paciente paciente)
        {
            RNPaciente rn = new RNPaciente();
            rn.CadastrarPaciente(paciente);
        }

        public void CadastrarPrestador(Prestador prestador)
        {
            RNPrestador rn = new RNPrestador();
            rn.CadastrarPrestador(prestador);
        }

        public void CadastrarUsuario(Usuario usuario)
        {
            RNUsuario rn = new RNUsuario();
            rn.CadastrarUsuario(usuario);
        }

        public void ExcluirAgendamento(Agendamento agendamento)
        {
            RNAgendamento rn = new RNAgendamento();
            rn.ExcluirAgendamento(agendamento);
        }

        public void ExcluirAtendimento(Atendimento atendimento)
        {
            RNAtendimento rn = new RNAtendimento();
            rn.ExcluirAtendimento(atendimento);
        }

        public void GerarAtendimento(Atendimento atendimento)
        {
            RNAtendimento rn = new RNAtendimento();
            rn.GerarAtendimento(atendimento);
        }

        public void InativarConvenio(Convenio convenio)
        {
            RNConvenio rn = new RNConvenio();
            rn.InativarConvenio(convenio);
        }

        public void InativarPrestador(Prestador prestador)
        {
            RNPrestador rn = new RNPrestador();
            rn.InativarPrestador(prestador);
        }

        public void InativarTipoConsulta(TipoConsulta tipoConsulta)
        {
            RNTipoConsulta rn = new RNTipoConsulta();
            rn.InativarTipoConsulta(tipoConsulta);
        }

        public void InserirTipoConsulta(TipoConsulta tipoConsulta)
        {
            RNTipoConsulta rn = new RNTipoConsulta();
            rn.InserirTipoConsulta(tipoConsulta);
        }

        public List<Agendamento> ListaAgendamentos(Agendamento agendamento)
        {
            RNAgendamento rn = new RNAgendamento();
            return rn.ListaAgendamentos(agendamento);
        }

        public List<Paciente> ListaPaciente(Paciente filtro)
        {
            RNPaciente rn = new RNPaciente();
            return rn.ListaPaciente(filtro);
        }

        public List<Prestador> ListaPrestadores(Prestador filtro)
        {
            RNPrestador rn = new RNPrestador();
            return rn.ListaPrestadores(filtro);
        }

        public List<Atendimento> ListarAtendimentos(Atendimento atendimento)
        {
            RNAtendimento rn = new RNAtendimento();
            return rn.ListarAtendimentos(atendimento);
        }

        public List<Convenio> ListarConvenios(Convenio filtro)
        {
            RNConvenio rn = new RNConvenio();
            return rn.ListarConvenios(filtro);
        }

        public List<Procedimento> ListarProcedimento(Procedimento procedimento)
        {
            RNProcedimento rn = new RNProcedimento();
            return rn.ListarProcedimento(procedimento);
        }

        public List<TipoConsulta> ListarTipoConsulta(TipoConsulta filtro)
        {
            RNTipoConsulta rn = new RNTipoConsulta();
            return rn.ListarTipoConsulta(filtro);
        }

        public List<Usuario> ListarUsuarios(Usuario filtro)
        {
            RNUsuario rn = new RNUsuario();
            return rn.ListarUsuarios(filtro);
        }

        public void RemarcarAgendamento(Agendamento agendamento)
        {
            RNAgendamento rn = new RNAgendamento();
            rn.RemarcarAgendamento(agendamento);
        }
    }
}
