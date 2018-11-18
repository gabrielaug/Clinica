using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Basicas;

namespace Biblioteca.interfaces
{
    public interface InterfaceConvenio
    {
        void CadastrarConvenio(Convenio convenio);
        void InativarConvenio(Convenio convenio);
        List<Convenio> ListarConvenios(Convenio filtro);
    }
}
