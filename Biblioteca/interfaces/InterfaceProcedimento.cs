using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Basicas;

namespace Biblioteca.interfaces
{
    public interface InterfaceProcedimento
    {
        void AdicionarProcedimento(Procedimento procedimento);
        void AtualizarProcedimento(Procedimento procedimento);

        List<Procedimento> ListarProcedimento(Procedimento procedimento);
    }
}
