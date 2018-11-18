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
        void AgendarAgendamento(Agendamento agendamento);

        [OperationContract]
        void RemarcarAgendamento(Agendamento agendamento);

        [OperationContract]
        void ExcluirAgendamento(Agendamento agendamento);

        [OperationContract]
        List<Agendamento> ListaAgendamentos(Agendamento agendamento);

        [OperationContract]
        void GerarAtendimento(Atendimento atendimento);

        [OperationContract]
        void ExcluirAtendimento(Atendimento atendimento);

        [OperationContract]
        void AtualizarAtendimento(Atendimento atendimento);

        [OperationContract]
        List<Atendimento> ListarAtendimentos(Atendimento atendimento);

        [OperationContract]
        void CadastrarConvenio(Convenio convenio);

        [OperationContract]
        void InativarConvenio(Convenio convenio);

        [OperationContract]
        List<Convenio> ListarConvenios(Convenio filtro);

        [OperationContract]
        void CadastrarPaciente(Paciente paciente);

        [OperationContract]
        void AlterarPaciente(Paciente paciente);

        [OperationContract]
        List<Paciente> ListaPaciente(Paciente filtro);

        [OperationContract]
        void CadastrarPrestador(Prestador prestador);

        [OperationContract]
        void InativarPrestador(Prestador prestador);

        [OperationContract]
        void AtualizarPrestador(Prestador prestador);

        [OperationContract]
        List<Prestador> ListaPrestadores(Prestador filtro);

        [OperationContract]
        void AdicionarProcedimento(Procedimento procedimento);

        [OperationContract]
        void AtuaizarProcedimento(Procedimento procedimento);

        [OperationContract]
        List<Procedimento> ListarProcedimento(Procedimento procedimento);

        [OperationContract]
        void InserirTipoConsulta(TipoConsulta tipoConsulta);

        [OperationContract]
        void InativarTipoConsulta(TipoConsulta tipoConsulta);

        [OperationContract]
        List<TipoConsulta> ListarTipoConsulta(TipoConsulta filtro);

        [OperationContract]
        void CadastrarUsuario(Usuario usuario);

        [OperationContract]
        void AlterarUsuario(Usuario usuario);

        [OperationContract]
        List<Usuario> ListarUsuarios(Usuario filtro);

    }

}
