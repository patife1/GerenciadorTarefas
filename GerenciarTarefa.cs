using Tarefas;
using Layout;
using System;
using System.Collections.Generic;

namespace GerenciarTarefa
{
    public class GerenciadorTarefas
    {
        private List<Tarefa> tarefas = new List<Tarefa>();  

  
        public void AdicionarTarefa()
        {
           
            Formatacao.Cor("Digite a descrição da tarefa:", ConsoleColor.White);
            string descricao = Console.ReadLine();

            int novoId = tarefas.Count + 1;
            Tarefa novaTarefa = new Tarefa(novoId, descricao);
            tarefas.Add(novaTarefa);

           
            Formatacao.Cor("Tarefa adicionada com sucesso!", ConsoleColor.Green);
        }

     
        public void RemoverTarefa()
        {
            // Listando todas as tarefas antes de pedir o ID para remover
            Formatacao.Cor("A lista com todas as tarefas impressas:", ConsoleColor.Yellow);
            ListarTarefas();

     
            Formatacao.Cor("Digite o ID da tarefa a remover:", ConsoleColor.White);
            int id = int.Parse(Console.ReadLine());

            Tarefa tarefa = tarefas.Find(t => t.Id == id);
            if (tarefa != null)
            {
                tarefas.Remove(tarefa);
             
                Formatacao.Cor("Tarefa removida com sucesso!", ConsoleColor.Red);
            }
            else
            {
                Formatacao.Cor($"Tarefa com ID {id} não encontrada.", ConsoleColor.Red);
            }
        }

        
        public void ListarTarefas()
        {
            if (tarefas.Count == 0)
            {
                Formatacao.Cor("Não há tarefas cadastradas.", ConsoleColor.Red);
                return;
            }

            foreach (var tarefa in tarefas)
            {
                tarefa.ExibirTarefa();
            }
        }

      
        public void Sair()
        {
            // Mensagem de despedida
            Formatacao.Cor("Saindo...", ConsoleColor.Red);
        }
    }
}
