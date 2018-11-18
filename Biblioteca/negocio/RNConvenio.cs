using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Basicas;
using Biblioteca.dados;
using Biblioteca.interfaces;

namespace Biblioteca.negocio
{
    public class RNConvenio: InterfaceConvenio

    {
        private DAOConvenio dao;
        public RNConvenio()
        {
            dao = new DAOConvenio();
        }


        public void CadastrarConvenio(Convenio convenio)
        {
            if (convenio != null)
            {
               

                    try
                    {
                        ValidarAtributos(convenio);
                        dao.CadastrarConvenio(convenio);
                    }
                    catch
                    {
                    throw new Exception("Convenio já cadastrado.");
                    }

               }   
               

            
        }

        public void InativarConvenio(Convenio convenio)
        {
            if (convenio.SnAtivo == "S")
            {
                try
                {
                    dao.InativarConvenio(convenio);
                }
                catch
                {

                }
            }
        }

        public List<Convenio> ListarConvenios(Convenio filtro)
        {

            return dao.ListarConvenios(filtro);
        }


        bool ValidarAtributos(Convenio co)
        {
            if (co.NmConvenio == null || co.NmConvenio.Trim().Equals(""))
            {
                throw new Exception("Nome do Convenio invalido.");
            }

            return true;

             }
        }
}
