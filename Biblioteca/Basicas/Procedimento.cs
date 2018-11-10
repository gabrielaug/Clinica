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
		private string cdProcedimento;
		private string nmProcedimento;
		private double valor;
		private Convenio convenio;
        private string snAtivo;

        public Procedimento()
        {
            this.Convenio = new Convenio();
        }

        public string ToString()
        {
            string retorno;

            retorno = this.CdProcedimento + " " + this.NmProcedimento + " " + this.Valor + " " + this.Convenio.CdConvenio + " " + this.Convenio.NmConvenio + " " + this.SnAtivo;
            return retorno;
        }

        [DataMember(IsRequired = true)]
		public string CdProcedimento { get => cdProcedimento; set => cdProcedimento = value; }

		[DataMember(IsRequired = true)]
		public string NmProcedimento { get => nmProcedimento; set => nmProcedimento = value; }

		[DataMember(IsRequired = true)]
		public double Valor { get => valor; set => valor = value; }

		[DataMember(IsRequired = true)]
		public Convenio Convenio { get => convenio; set => convenio = value; }

        [DataMember(IsRequired = true)]
        public string SnAtivo { get => snAtivo; set => snAtivo = value; }

    }
}
