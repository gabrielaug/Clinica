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
		private DateTime hrAtendimento;
		private DateTime dtAtendimento;
		private Prestador prestador;
		private Agendamento agendamento;
		private Procedimento procedimento;
		private TipoConsulta tipoConsulta;
		private Usuario usuario;
		private DateTime dtAtendFinalizado;

        [DataMember(IsRequired = true)]
        public int CdAtendimento { get => cdAtendimento; set => cdAtendimento = value; }

        [DataMember(IsRequired = true)]
        public DateTime HrAtendimento { get => hrAtendimento; set => hrAtendimento = value; }

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
	}
}
