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
        void gerar(Atendimento atendimento);
        void excluir(Atendimento atendimento);
        void atualizar(Atendimento atendimento);
        List<Atendimento> listarAtendimentos(Atendimento atendimento);
    }
}
