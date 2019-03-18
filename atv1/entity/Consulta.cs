using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.atv1
{
    class Consulta
    {
        public String Procedimento { get; set; }
        public Paciente Paciente { get; set; }

        public Consulta(Paciente paciente, String procedimento)
        {
            Paciente = paciente;
            Procedimento = procedimento;
        }


    }
}
