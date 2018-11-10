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
        void Adicionar(Procedimento procedimento);
        void Atuaizar(Procedimento procedimento);

        List<Procedimento> ListarProcedimento(Procedimento procedimento);
    }
}
