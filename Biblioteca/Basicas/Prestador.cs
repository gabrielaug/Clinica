using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;


namespace Biblioteca.Basicas
{
    [DataContract]

    public class Prestador
    {
        private int cdPrestador;
        private string nmPrestador;
        private string cpf;
        private string telefone;
        private string nrConselho;
        private string snAtivo;

        
		[DataMember(IsRequired = true)]
		public string NrConselho { get => nrConselho; set => nrConselho = value; }

		[DataMember(IsRequired = true)]
		public int CdPrestador { get => cdPrestador; set => cdPrestador = value; }

		[DataMember(IsRequired = true)]
		public string NmPrestador { get => nmPrestador; set => nmPrestador = value; }

		[DataMember(IsRequired = true)]
		public string Cpf { get => cpf; set => cpf = value; }

        [DataMember(IsRequired = true)]
        public string SnAtivo { get => snAtivo; set => snAtivo = value; }

        [DataMember(IsRequired = true)]
        public string Telefone { get => telefone; set => telefone = value; }

        //public string ToString()
        //{
        //    string retorno;

        //    retorno = this.cd_prestador + " " + this.nm_prestador + " " + this.cpf + " " + this.telefone + " " + this.nr_conselho + " " + this.sn_ativo + " " ;
        //    return retorno;
        //}
    }
}
