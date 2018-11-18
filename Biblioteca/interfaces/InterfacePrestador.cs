using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Basicas;

namespace Biblioteca.interfaces
{
    public interface InterfacePrestador
    {
        void CadastrarPrestador(Prestador prestador);
        void InativarPrestador(Prestador prestador);
        void AtualizarPrestador(Prestador prestador);
        List<Prestador> ListaPrestadores(Prestador filtro);
        bool VerificarCPF(Prestador prestador);
    }
}
