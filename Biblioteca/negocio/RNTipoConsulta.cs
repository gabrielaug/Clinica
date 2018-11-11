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
    public class RNTipoConsulta : InterfaceTipoConsulta
    {
        private DAOTipoConsulta dao;

        public RNTipoConsulta()
        {

            dao = new DAOTipoConsulta();

        }

        public void inativar(TipoConsulta tipoConsulta)
        {
            if (tipoConsulta.SnAtivo == "S")
            {
                try
                {
                    dao.inativar(tipoConsulta);
                }
                catch
                {

                }
            }
        }

        public void inserir(TipoConsulta tipoConsulta)
        {
            if (tipoConsulta != null)
            {
               
                    try
                    {
                        ValidarAtributos(tipoConsulta);
                        dao.inserir(tipoConsulta);
                    }
                    catch
                    {

                    }
            }
               
            else
                {
                    throw new Exception("Tipo consulta já cadastrado.");
                }

            

        }

        public List<TipoConsulta> ListaPrestadores(TipoConsulta filtro)
        {
            return dao.listarTipoConsulta(filtro);
        }

        bool ValidarAtributos(TipoConsulta d)
        {
            if (d.NmConsulta == null || d.NmConsulta.Trim().Equals(""))
            {
                throw new Exception("Nome do Tipo Consulta invalido.");
            }

            return true;

        }
    }
}
