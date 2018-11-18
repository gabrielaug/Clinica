using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Basicas;

namespace Biblioteca.interfaces
{
    public interface InterfaceUsuario
    {
        void CadastrarUsuario(Usuario usuario);
        void AlterarUsuario(Usuario usuario);
        List<Usuario> ListarUsuarios(Usuario filtro);
    }
}
