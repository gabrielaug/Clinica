using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Basicas;

namespace Biblioteca.interfaces
{
    public interface InterfaceTipoConsulta
    {
        void InserirTipoConsulta(TipoConsulta tipoConsulta);
        void InativarTipoConsulta(TipoConsulta tipoConsulta);
        List<TipoConsulta> ListarTipoConsulta(TipoConsulta filtro);
    }
}
