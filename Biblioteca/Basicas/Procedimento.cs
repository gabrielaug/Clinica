using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Basicas
{
	[DataContract]
	public class Procedimento
	{
		private int cdProcedimento;
		private string nmProcedimento;
		private double valor;
		private Convenio convenio;
        private string snAtivo;
		public Procedimento()
		{
			this.convenio = new Convenio();
		}

		[DataMember(IsRequired = true)]
		public int CdProcedimento { get => cdProcedimento; set => cdProcedimento = value; }

		[DataMember(IsRequired = true)]
		public string NmProcedimento { get => nmProcedimento; set => nmProcedimento = value; }

		[DataMember(IsRequired = true)]
		public double Valor { get => valor; set => valor = value; }

		[DataMember(IsRequired = true)]
		internal Convenio Convenio { get => convenio; set => convenio = value; }

        [DataMember(IsRequired = true)]
        public string SnAtivo { get => snAtivo; set => snAtivo = value; }

    }
}
