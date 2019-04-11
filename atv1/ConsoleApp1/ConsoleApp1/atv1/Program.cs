using ConsoleApp1.atv1;
using ConsoleApp1.atv1.entity;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Repository repository = new Repository();
                
            while (true) { 

            
            Console.WriteLine("\n");
            Console.WriteLine("Bem vindo ! \n escolha a opção desejada:");
            Console.WriteLine("1- Cadastrar paciente");
            Console.WriteLine("2- Pesquisar paciente");
            Console.WriteLine("3- Cadastrar procedimento");
            Console.WriteLine("4- Realizar procedimento");
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
                            repository.add(paciente);
                            break;
                        }


                    case 2:
                        {
                            Console.WriteLine("Digite o nome");
                            String nome = Console.ReadLine();
                          
                            Paciente paciente = repository.find(nome);

                            if(paciente != null)
                            {
                                Console.WriteLine(paciente.Nome);
                            }else
                            {
                                Console.WriteLine("Não encontrado");
                            }
                            break;

                        }
                    case 3:
                        {
                            Console.Write("Digite o nome do procedimento: ");
                            string nomeProcedimento = Console.ReadLine();
                            Console.Write("Digite o nome do paciente: ");
                            string pacienteProcedimento = Console.ReadLine();
                            Procedimento procedimento = new Procedimento(nomeProcedimento);
                            repository.saveProcedimentoByName(pacienteProcedimento, procedimento);
                            break;

                        }
                }


            }
        }
    }
}
