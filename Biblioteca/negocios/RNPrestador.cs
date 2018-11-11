﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Basicas;
using Biblioteca.dados;
using Biblioteca.interfaces;

namespace Biblioteca.negocios
{
    public class RNPrestador : InterfacePrestador

    {
        private DAOPrestador dao;

        public RNPrestador()
        {
               dao = new DAOPrestador();
        }

        public void inativar(Prestador prestador)
        {
            if (prestador.SnAtivo == "S")
            {
                try
                {
                    dao.inativar(prestador);
                }
                catch
                {

                }
            }

        }

        public void atualizar(Prestador prestador)
        {
                
            if (prestador.CdPrestador > 0)
            {
                dao.VerificarCPF(prestador);
                try
                {

                    //  
                    
                    // ValidarAtributos(prestador);
                    dao.atualizar(prestador);

                }
                catch
                {

                }

            }

        }

        public void cadastrar(Prestador prestador)
        {
            if (prestador != null)
            {
                if (VerificarCPF(prestador))
                {

                    try
                    {
                        ValidarAtributos(prestador);
                        dao.cadastrar(prestador);
                    }
                    catch
                    {

                    }

                }
                else
                {
                    throw new Exception("CPF já cadastrado.");
                }

            }

             }

            public List<Prestador> ListaPrestadores(Prestador filtro)
        {

            return dao.ListaPrestadores(filtro);
        }

        public bool VerificarCPF(Prestador prestador)
        {
            return dao.VerificarCPF(prestador);
        }



        #region Validar Atributos de um Prestador

        bool ValidarAtributos(Prestador d)
        {
            if (d.NmPrestador == null || d.NmPrestador.Trim().Equals(""))
            {
                throw new Exception("Nome do Prestador invalido.");
            }

            if (d.NmPrestador.Length > 100)
            {
                throw new Exception("Quantidade de Caracteres Invalido Max: 100.");
            }

            if (d.Cpf == null || d.Cpf.Trim().Equals(""))
            {
                throw new Exception("CPF é Obrigatorio.");
            }

            if (d.Cpf.Length > 11)
            {
                throw new Exception("Quantidade de Caracteres Invalido Max: 11.");
            }


            if (d.Telefone == null || d.Telefone.Trim().Equals(""))
            {
                throw new Exception("Telefone invalido.");
            }

            if (d.Telefone.Length > 15)
            {
                throw new Exception("Quantidade de Caracteres Invalido Max: 15.");
            }

            return true;
        }

        #endregion
    }
}

