using System;
using GerenciarTarefa;
using Layout;

class Program
{
    static void Main(string[] args)
    {
   
        Formatacao.ImprimirCabecalho();

        GerenciadorTarefas gerenciador = new GerenciadorTarefas();

        bool continuar = true;

        while (continuar)
        {
            
            Formatacao.Cor("Escolha uma opção:", ConsoleColor.White);
            Formatacao.Cor("1. Adicionar Tarefa", ConsoleColor.Cyan);
            Formatacao.Cor("2. Remover Tarefa", ConsoleColor.Cyan);
            Formatacao.Cor("3. Sair", ConsoleColor.Cyan);
            Console.Write("Digite sua opção: ");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    
                    gerenciador.AdicionarTarefa();
                    break;

                case "2":
                    
                    gerenciador.RemoverTarefa();
                    break;

                case "3":
                    
                    gerenciador.Sair();
                    continuar = false;
                    break;

                default:
                    
                    Formatacao.Cor("Opção inválida. Tente novamente.", ConsoleColor.Red);
                    break;
            }

            Console.WriteLine();
        }
    }
}
