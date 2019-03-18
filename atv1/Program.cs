using ConsoleApp1.atv1;
using ConsoleApp1.atv1.entity;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            DatabaseRepository repository = new DatabaseRepository();
            Console.WriteLine("Bem vindo ! \n escolha a opção desejada:");
            Console.WriteLine("1- Cadastrar paciente");
            Console.WriteLine("2- Pesquisar paciente");
            Console.WriteLine("3- Cadastrar atendimento");
            Console.WriteLine("4- Realizar atendimento");
            int escolha = int.Parse(Console.ReadLine());
            switch (escolha)
            {
                case 1:
                    {
                        Console.WriteLine("Digite o nome");
                        String nome = Console.ReadLine();
                        Console.WriteLine("Digite o cpf");
                        String cpf = Console.ReadLine();
                        Paciente paciente = new Paciente(nome, cpf);
                        repository.addPaciente(paciente);

                        break;
                    }
                    

                case 2:
                    {
                        Console.WriteLine("Digite o nome");
                        String nome = Console.ReadLine();
                        Console.WriteLine(repository.findPacienteByName(nome).ToString());
                        break;
                     
                    }
                case 3:
                    {

                        Console.WriteLine("Digite o cpf do paciente");
                        String cpf = Console.ReadLine();
                        Paciente paciente = repository.findPacienteByCPF(cpf);
                        Console.WriteLine("Digite o procedimento");
                        String proc = Console.ReadLine();
                        repository.Consultas.Add(new Consulta(paciente, proc));


                        break;
                        
                    }


            }
        }
    }
}
