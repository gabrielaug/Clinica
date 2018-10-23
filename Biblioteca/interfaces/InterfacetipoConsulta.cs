using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Basicas;

namespace Biblioteca.interfaces
{
    public interface InterfacetipoConsulta
    {
        void inserir(TipoConsulta tipoconsulta);
        void atualizar(TipoConsulta tipoconsulta);
        void deletar(TipoConsulta tipoconsulta);
        List<TipoConsulta> listarTipoConsulta();
    }
}
