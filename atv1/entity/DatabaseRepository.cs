using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.atv1.entity
{
    class DatabaseRepository
    {

        public List<Paciente> Pacientes { get; set; }

        public List<Consulta> Consultas { get; set; }

        public void addPaciente(Paciente paciente)
        {
            this.Pacientes.Add(paciente);
        }

        public Paciente findPacienteByName(String nome)
        {
            Paciente paciente = null;
                
          
                Pacientes.ForEach((Paciente obj) =>
                {
                    if (obj.Nome.Equals(nome))
                    {
                        paciente = obj;
                       
                    }
                });
            
            return paciente;

        }

        public Paciente findPacienteByCPF(String cpf)
        {
            Paciente paciente = null;

         
                Pacientes.ForEach((Paciente obj) =>
                {
                    if (obj.CPF.Equals(cpf))
                    {
                        paciente = obj;

                    }
                });
            
            return paciente;

        }

        public Consulta findConsultaByPaciente(Paciente paciente)
        {
            Consulta consulta = null;
            Consultas.ForEach((Consulta obj) =>
            {
                if (obj.Paciente.Equals(paciente))
                {
                    consulta = obj;
                }
            });
            return consulta;
        }
    }


}

