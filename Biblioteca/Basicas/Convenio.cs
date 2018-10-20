using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Basicas
{
	[DataContract]
	public class Convenio
	{
		private int cdConvenio;
		private string nmConvenio;

		[DataMember (IsRequired = true)]
		public int CdConvenio { get => cdConvenio; set => cdConvenio = value; }

		[DataMember(IsRequired = true)]
		public string NmConvenio { get => nmConvenio; set => nmConvenio = value; }
	}
}
