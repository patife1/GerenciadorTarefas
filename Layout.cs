namespace Layout
{
    public class Formatacao
    {
        
        public static void ImprimirCabecalho()
        {
            Console.WriteLine("╔════════════════════════════════════╗");
            Console.WriteLine("║       GERENCIADOR DE TAREFAS       ║");
            Console.WriteLine("╚════════════════════════════════════╝\n");
        }

  
        public static void Cor(string mensagem, ConsoleColor cor)
        {
            Console.ForegroundColor = cor;
            Console.WriteLine(mensagem);
            Console.ResetColor();  
        }
    }
}
