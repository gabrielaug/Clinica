using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Basicas
{
    [DataContract]
    public class Usuario
    {

        private string userName;
        private string senha;
        private string nome;
        private string snAtivo;

        [DataMember(IsRequired = true)]
        public string UserName { get => userName; set => userName = value; }

        [DataMember(IsRequired = true)]
        public string Senha { get => senha; set => senha = value; }

        [DataMember(IsRequired = true)]
        public string Nome { get => nome; set => nome = value; }

        [DataMember(IsRequired = true)]
        public string SnAtivo { get => snAtivo; set => snAtivo = value; }

    }
}
