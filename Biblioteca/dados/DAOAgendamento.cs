using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Basicas;
using Biblioteca.conexao;
using Biblioteca.interfaces;

namespace Biblioteca.dados
{
    class DAOAgendamento: ConexaoSqlServer, InterfaceAgendamento
    {
       public void Agendar(Agendamento agendamento)
        {
            throw new NotImplementedException();
        }
       
            public void Excluir(Agendamento agendamento)
        {
            throw new NotImplementedException();
        }

        public List<Agendamento> ListaAgendamentos()
        {
            throw new NotImplementedException();
        }

        public void Remarcar(Agendamento agendamento)
        {
            throw new NotImplementedException();
        }
    }
}
