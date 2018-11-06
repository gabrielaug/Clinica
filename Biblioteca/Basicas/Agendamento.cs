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
            return "Codigo:" + this.cdAgendamento + "Data Consulta:" + this.dtConsulta + "prestador:" + this.Prestador.CdPrestador + "nome prestador:" + this.Prestador.NmPrestador + "paciente:" + this.Paciente.CdPaciente;
        }
    }
}
