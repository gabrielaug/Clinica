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
    public class RNProcedimento: InterfaceProcedimento
    {
        DAOProcedimento dao = new DAOProcedimento();

        public void AdicionarProcedimento(Procedimento procedimento)
        {
            dao.AdicionarProcedimento(procedimento);
        }

        public void AtualizarProcedimento(Procedimento procedimento)
        {
            dao.AtualizarProcedimento(procedimento);
        }

        public List<Procedimento> ListarProcedimento(Procedimento procedimento)
        {
            return dao.ListarProcedimento(procedimento);
        }
    }
}
