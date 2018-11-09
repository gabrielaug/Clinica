using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Basicas
{
    [DataContract]
    public class Agendamento 
    {
        
        private int cdAgendamento;
        private DateTime dtConsulta;
        private DateTime hrConsulta;
        private Paciente paciente;
        private Prestador prestador;
        private Usuario usuario;

        public Agendamento()
        {
            this.usuario = new Usuario();
            this.prestador = new Prestador();
            this.paciente = new Paciente();
        }



        [DataMember(IsRequired = true)]
        public int CdAgendamento { get => cdAgendamento; set => cdAgendamento = value; }
        [DataMember(IsRequired = true)]
        public DateTime DtConsulta { get => dtConsulta; set => dtConsulta = value; }
        [DataMember(IsRequired = true)]
        public DateTime HrConsulta { get => hrConsulta; set => hrConsulta = value; }
        [DataMember(IsRequired = true)]
        public Prestador Prestador { get => prestador; set => prestador = value; }
        [DataMember(IsRequired = true)]
        public Paciente Paciente { get => paciente; set => paciente = value; }
        [DataMember(IsRequired = true)]
        public Usuario Usuario { get => usuario; set => usuario = value; }

        public string ToString()
        {
            string retorno;

            retorno = this.CdAgendamento + " " + this.Paciente.CdPaciente + " " + this.Paciente.NmPaciente;
            retorno += " " + this.DtConsulta + " " + this.Prestador.CdPrestador + " " + this.Prestador.NmPrestador + " " + this.Usuario.UserName;
            return retorno;
        }
    }
}
