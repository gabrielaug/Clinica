using Biblioteca.Basicas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.interfaces
{
  
     public interface InterfaceAgendamento
    {
        void AgendarAgendamento(Agendamento agendamento);

        void RemarcarAgendamento(Agendamento agendamento);

        void ExcluirAgendamento(Agendamento agendamento);

        List<Agendamento> ListaAgendamentos(Agendamento agendamento); 
    }
}
