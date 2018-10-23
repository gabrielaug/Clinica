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
        void cadastrar(Convenio convenio);
        void atualizar(Convenio convenio);
        void inativar(Convenio convenio);
        List<Convenio> listarConvenios();
    }
}
