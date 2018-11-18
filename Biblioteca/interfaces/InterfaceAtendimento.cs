using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Basicas;

namespace Biblioteca.interfaces
{
    public interface InterfaceAtendimento
    {
        void GerarAtendimento(Atendimento atendimento);
        void ExcluirAtendimento(Atendimento atendimento);
        void AtualizarAtendimento(Atendimento atendimento);
        List<Atendimento> ListarAtendimentos(Atendimento atendimento);
    }
}
