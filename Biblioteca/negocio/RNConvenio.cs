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


        public void cadastrar (Convenio convenio)
        {
            if (convenio != null)
            {
               

                    try
                    {
                        ValidarAtributos(convenio);
                        dao.cadastrar(convenio);
                    }
                    catch
                    {
                    throw new Exception("Convenio já cadastrado.");
                    }

               }   
               

            
        }

        public void inativar (Convenio convenio)
        {
            if (convenio.SnAtivo == "S")
            {
                try
                {
                    dao.inativar(convenio);
                }
                catch
                {

                }
            }
        }

        public List<Convenio> listarConvenios(Convenio filtro)
        {

            return dao.listarConvenios(filtro);
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
