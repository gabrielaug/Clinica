using Biblioteca.Basicas;
using Biblioteca.dados;
using Biblioteca.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.negocio
{
    public class RNAtendimento: InterfaceAtendimento
    {
        DAOAtendimento dao;

        public RNAtendimento()
        {
            dao = new DAOAtendimento();
        }

        public void atualizar(Atendimento atendimento)
        {
            throw new NotImplementedException();
        }

        public void excluir(Atendimento atendimento)
        {
            throw new NotImplementedException();
        }

        public void gerar(Atendimento atendimento)
        {
            if()
        }

        public List<Atendimento> listarAtendimentos(Atendimento atendimento)
        {
            throw new NotImplementedException();
        }
    }
}
