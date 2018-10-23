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
        void importar(Procedimento procedimento);
        void atuaizar(Procedimento procedimento);
        void deletar(Procedimento procedimento);
    }
}
