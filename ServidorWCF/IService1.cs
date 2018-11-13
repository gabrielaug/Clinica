using Biblioteca.Basicas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ServidorWCF
{
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        void Agendar(Agendamento agendamento);

        [OperationContract]
        void Remarcar(Agendamento agendamento);

        [OperationContract]
        void Excluir(Agendamento agendamento);

        [OperationContract]
        List<Agendamento> ListaAgendamentos(Agendamento agendamento);

        [OperationContract]
        void gerar(Atendimento atendimento);

        [OperationContract]
        void excluir(Atendimento atendimento);

        [OperationContract]
        void atualizar(Atendimento atendimento);

        [OperationContract]
        List<Atendimento> listarAtendimentos(Atendimento atendimento);

        [OperationContract]
        void cadastrar(Convenio convenio);

        [OperationContract]
        void inativar(Convenio convenio);

        [OperationContract]
        List<Convenio> listarConvenios(Convenio filtro);

        [OperationContract]
        void Cadastrar(Paciente paciente);

        [OperationContract]
        void Alterar(Paciente paciente);

        [OperationContract]
        List<Paciente> ListaPaciente(Paciente filtro);

        [OperationContract]
        void cadastrar(Prestador prestador);

        [OperationContract]
        void inativar(Prestador prestador);

        [OperationContract]
        void atualizar(Prestador prestador);

        [OperationContract]
        List<Prestador> ListaPrestadores(Prestador filtro);

        [OperationContract]
        void Adicionar(Procedimento procedimento);

        [OperationContract]
        void Atuaizar(Procedimento procedimento);

        [OperationContract]
        List<Procedimento> ListarProcedimento(Procedimento procedimento);

        [OperationContract]
        void inserir(TipoConsulta tipoConsulta);

        [OperationContract]
        void inativar(TipoConsulta tipoConsulta);

        [OperationContract]
        List<TipoConsulta> listarTipoConsulta(TipoConsulta filtro);

        [OperationContract]
        void cadastrar(Usuario usuario);

        [OperationContract]
        void alterar(Usuario usuario);

        [OperationContract]
        List<Usuario> listarUsuarios(Usuario filtro);

    }

}
