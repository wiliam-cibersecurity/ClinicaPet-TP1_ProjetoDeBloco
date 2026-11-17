using System;

namespace CliniciaPetApp
{
    class Program
    {

        //estipulei um limit de 100 cadastros para cada array para simplificar o cod.
        static string[] animalNome = new string[100];
        static string[] animalEspecie = new string[100];
        static int totalAnimais = 0;

        static string[] vetNome = new string[100];
        static string[] vetCrmv = new string[100];
        static int totalVeterinarios = 0;

        static string[] consultaAnimal = new string[100];
        static string[] consultaVet = new string[100];
        static string[] consultaDataHora = new string[100];
        static string[] consultaStatus = new string[100];
        static int[] totalConsultas = new int[100];

        //construcao do menu princiapl do sistema
        static void Main(string[] args)
        {
            bool executando = true;

            //o loop principal do sistema menu
            while (executando)
            {
                Console.Clear();
                Console.WriteLine("=== SISTEMA CLINICAPET ===");
                Console.WriteLine("1 - Acesso Recepcionista");
                Console.WriteLine("2 - Acesso Veterinário");
                Console.WriteLine("0 - Sair");
                Console.Write("Escolha o perfil de acesso: ");

                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        MenuRecepcionista();
                        break;
                    case "2":
                        MenuVeterinario();
                        Console.ReadLine();
                        break;
                    case "0":
                        executando = false;
                        Console.WriteLine("Encerrando o sistema...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida! Pressione ENTER para tentar novamente.");
                        Console.ReadLine();
                        break;
                }
            }
        }

        //construção do menu recepcionista
        static void MenuRecepcionista()
        {
               bool noMenuRecepcionista = true;

            while (noMenuRecepcionista)
            {
                Console.Clear();
                Console.WriteLine("=== MENU RECEPCIONISTA ===");
                Console.WriteLine("1 - Cadastrar Animal");
                Console.WriteLine("2 - Listar Animais");
                Console.WriteLine("3 - Cadastrar Veterinário");
                Console.WriteLine("4 - Listar Veterinários");
                Console.WriteLine("5 - Agendar Consulta");
                Console.WriteLine("6 - Cancelar Consulta");
                Console.WriteLine("0 - Voltar ao Menu Principal");
                Console.Write("Escolha uma opção: ");
                string opcao = Console.ReadLine();
                switch (opcao)
                {
                    case "1":
                        Console.WriteLine("\nPágina de cadastro de animal em construção...");
                        Console.WriteLine("\nPressione ENTER para retornar...");
                        Console.ReadLine();
                        break;
                    case "2":
                        Console.WriteLine("\nPágina de listagem de animais em construção...");
                        Console.WriteLine("\nPressione ENTER para retornar...");
                        Console.ReadLine();
                        break;
                    case "3":
                        Console.WriteLine("\nPágina de cadastro de veterinário em construção...");
                        Console.WriteLine("\nPressione ENTER para retornar...");
                        Console.ReadLine();
                        break;
                    case "4":
                        Console.WriteLine("\nPágina de listagem de veterinários em construção...");
                        Console.WriteLine("\nPressione ENTER para retornar...");
                        Console.ReadLine();
                        break;
                    case "5":
                        Console.WriteLine("\nPágina de agendamento de consulta em construção...");
                        Console.WriteLine("\nPressione ENTER para retornar...");
                        Console.ReadLine();
                        break;
                    case "6":
                        Console.WriteLine("\nPágina de cancelamento de consulta em construção...");
                        Console.WriteLine("\nPressione ENTER para retornar...");
                        Console.ReadLine();
                        break;
                    case "0":
                        noMenuRecepcionista = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida! Pressione ENTER para tentar novamente.");
                        Console.ReadLine();
                        Console.ReadLine();
                        break;
                }
            }
        }

        //construcao do menu veterinario
        static void MenuVeterinario()
        {
            bool noMenuVeterinario = true;
            while (noMenuVeterinario)
            {
                Console.Clear();
                Console.WriteLine("=== MENU VETERINÁRIO ===");
                Console.WriteLine("1 - Consultar Animal");
                Console.WriteLine("2 - Registrar Atendimento");
                Console.WriteLine("3 - Consultar Agenda");
                Console.WriteLine("0 - Voltar ao Menu Principal");
                Console.Write("Escolha uma opção: ");

                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.WriteLine("\nPágina de consulta de animal em construção...");
                        Console.WriteLine("\nPressione ENTER para retornar...");
                        Console.ReadLine();
                        break;
                    case "2":
                        Console.WriteLine("\nPágina de registro de atendimento em construção...");
                        Console.WriteLine("\nPressione ENTER para retornar...");
                        Console.ReadLine();
                        break;

                    case "3":
                        Console.WriteLine("\nPágina de consulta de agenda em construção...");
                        Console.WriteLine("\nPressione ENTER para retornar...");
                        Console.ReadLine();
                        break;
                    case "0":
                        noMenuVeterinario = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida! Pressione ENTER para tentar novamente.");
                        Console.WriteLine("\nPressione ENTER para retornar...");
                        Console.ReadLine();
                        break;
                }
            }
        }
    }
}