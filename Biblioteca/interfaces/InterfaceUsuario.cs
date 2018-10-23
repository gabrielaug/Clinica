﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Basicas;

namespace Biblioteca.interfaces
{
    public interface InterfaceUsuario
    {
        void cadastrar(Usuario usuario);
        void inativar(Usuario usuario);
        List<Usuario> listarUsuarios();
    }
}