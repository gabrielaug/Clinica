using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Basicas
{
    [DataContract]
    public class TipoConsulta
    {
        private int cdConsulta;
        private string nmConsulta;
        private string snAtivo;

        [DataMember(IsRequired = true)]
        public int CdConsulta { get => cdConsulta; set => cdConsulta = value; }

        [DataMember(IsRequired = true)]
        public string NmConsulta { get => nmConsulta; set => nmConsulta = value; }

        [DataMember(IsRequired = true)]
        public string SnAtivo { get => snAtivo; set => snAtivo = value; }

    }
}
