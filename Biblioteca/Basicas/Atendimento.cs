using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Basicas
{
	[DataContract]
	public class Atendimento
	{

		private int cdAtendimento;
		private DateTime dtAtendimento;
		private Prestador prestador;
		private Agendamento agendamento;
		private Procedimento procedimento;
		private TipoConsulta tipoConsulta;
		private Usuario usuario;
		private DateTime dtAtendFinalizado;

        public Atendimento()
        {
           this.Prestador = new Prestador();
           this.Agendamento = new Agendamento();
           this.Procedimento = new Procedimento();
           this.tipoConsulta = new TipoConsulta();
           this.Usuario = new Usuario();
        }

        [DataMember(IsRequired = true)]
        public int CdAtendimento { get => cdAtendimento; set => cdAtendimento = value; }

        [DataMember(IsRequired = true)]
        public DateTime DtAtendimento { get => dtAtendimento; set => dtAtendimento = value; }

        [DataMember(IsRequired = true)]
        public Prestador Prestador { get => prestador; set => prestador = value; }

        [DataMember(IsRequired = true)]
        public Agendamento Agendamento { get => agendamento; set => agendamento = value; }

        [DataMember(IsRequired = true)]
        public Procedimento Procedimento { get => procedimento; set => procedimento = value; }

        [DataMember(IsRequired = true)]
        public TipoConsulta TipoConsulta { get => tipoConsulta; set => tipoConsulta = value; }

        [DataMember(IsRequired = true)]
        public Usuario Usuario { get => usuario; set => usuario = value; }

        [DataMember(IsRequired = true)]
        public DateTime DtAtendFinalizado { get => dtAtendFinalizado; set => dtAtendFinalizado = value; }

        //public string ToString()
        //{
        //    string retorno;

        //    retorno = "Codigo:" + this.cdAtendimento  + "Data Atendimento:" + this.DtAtendimento + "Data Atendimento Finalizado:" + this.dtAtendFinalizado +"Codigo Prestador:"+this.Prestador.CdPrestador+ "nome prestador:" + this.Prestador.NmPrestador + "paciente:" + this.Agendamento.Paciente.CdPaciente;
        //    return retorno;
        //}
    }
}
