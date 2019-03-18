using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.atv1
{
    class Paciente
    {
        public String Nome { get; set; }
        public String CPF { get; set;  }

        public Paciente(String nome, String cpf)
        {
            Nome = nome;
            CPF = cpf;
        }
    }
}
