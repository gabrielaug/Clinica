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
        void Agendar(Agendamento agendamento);

        void Remarcar(Agendamento agendamento);

        void Excluir(Agendamento agendamento);

        List<Agendamento> ListaAgendamentos(Agendamento agendamento); 
    }
}
