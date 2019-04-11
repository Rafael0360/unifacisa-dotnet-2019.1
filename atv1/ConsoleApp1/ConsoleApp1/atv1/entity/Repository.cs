using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.atv1.entity
{
    class Repository
    {

        public List<Paciente> pacientes = new List<Paciente>();

        public void add(Paciente paciente)
        {
            pacientes.Add(paciente);
        }

        public Paciente find(String nome)
        {
            for (int i = 0; i < pacientes.Count; i++)
            {
                if (pacientes[i].Nome.Equals(nome))
                {
                    return pacientes[i];
                   
                }

            }
            return null;
        }

        public void saveProcedimentoByName(String name, Procedimento procedimento)
        {
            find(name).Procedimentos.Add(procedimento);

        }

    }
}
