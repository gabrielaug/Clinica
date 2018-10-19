using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Basicas
{
    [DataContract]
    public class Paciente
    {

        private int cdPaciente;
        private string nmPaciente;
        private string nmMae;
        private string nmPai;
        private string nmSocial;
        private string cpf;
        private string rg;
        private DateTime dtNascimento;
        private string telefone;
        private string endereco;
        private string email;
        private string cidade;
        private string bairro;
        private string estado;

        [DataMember(IsRequired = true)]
        public int CdPaciente { get => cdPaciente; set => cdPaciente = value; }

        [DataMember(IsRequired = true)]
        public string NmPaciente { get => nmPaciente; set => nmPaciente = value; }

        [DataMember(IsRequired = true)]
        public string NmMae { get => nmMae; set => nmMae = value; }

        [DataMember(IsRequired = true)]
        public string NmPai { get => nmPai; set => nmPai = value; }

        [DataMember(IsRequired = true)]
        public string NmSocial { get => nmSocial; set => nmSocial = value; }

        [DataMember(IsRequired = true)]
        public string Cpf { get => cpf; set => cpf = value; }

        [DataMember(IsRequired = true)]
        public string Rg { get => rg; set => rg = value; }

        [DataMember(IsRequired = true)]
        public DateTime DtNascimento { get => dtNascimento; set => dtNascimento = value; }

        [DataMember(IsRequired = true)]
        public string Telefone { get => telefone; set => telefone = value; }

        [DataMember(IsRequired = true)]
        public string Endereco { get => endereco; set => endereco = value; }

        [DataMember(IsRequired = true)]
        public string Email { get => email; set => email = value; }

        [DataMember(IsRequired = true)]
        public string Cidade { get => cidade; set => cidade = value; }

        [DataMember(IsRequired = true)]
        public string Bairro { get => bairro; set => bairro = value; }

        [DataMember(IsRequired = true)]
        public string Estado { get => estado; set => estado = value; }
    }
}
