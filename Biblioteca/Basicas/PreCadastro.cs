using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Basicas
{
    [DataContract]
    public class PreCadastro
    {
        private string cpf;
        private string nome;
        private string telefone;
        private DateTime dtNascimento;

        [DataMember(IsRequired = true)]
        public string Cpf { get => cpf; set => cpf = value; }

        [DataMember(IsRequired = true)]
        public string Nome { get => nome; set => nome = value; }

        [DataMember(IsRequired = true)]
        public string Telefone { get => telefone; set => telefone = value; }

        [DataMember(IsRequired = true)]
        public DateTime DtNascimento { get => dtNascimento; set => dtNascimento = value; }
    }
}
