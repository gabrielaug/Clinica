﻿using Biblioteca.Basicas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.interfaces
{
    public interface InterfacePaciente
    {

        void CadastrarPaciente(Paciente paciente);

        void AlterarPaciente(Paciente paciente);

        List<Paciente> ListaPaciente(Paciente filtro);

        bool VerificarCPF(Paciente paciente);
    }
}
