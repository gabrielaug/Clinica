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


		public int CdAtendimento { get => cdAtendimento; set => cdAtendimento = value; }
		public DateTime HrAtendimento { get => hrAtendimento; set => hrAtendimento = value; }
		public DateTime DtAtendimento { get => dtAtendimento; set => dtAtendimento = value; }
		public Prestador Prestador { get => prestador; set => prestador = value; }
		public Agendamento Agendamento { get => agendamento; set => agendamento = value; }
		public Procedimento Procedimento { get => procedimento; set => procedimento = value; }
		public TipoConsulta TipoConsulta { get => tipoConsulta; set => tipoConsulta = value; }
		public Usuario Usuario { get => usuario; set => usuario = value; }
		public DateTime DtAtendFinalizado { get => dtAtendFinalizado; set => dtAtendFinalizado = value; }
	}
}
