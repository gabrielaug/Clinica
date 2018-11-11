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
        void inserir(TipoConsulta tipoConsulta);
        //void atualizar(TipoConsulta tipoConsulta);
        void inativar(TipoConsulta tipoConsulta);
        List<TipoConsulta> listarTipoConsulta(TipoConsulta filtro);
    }
}
