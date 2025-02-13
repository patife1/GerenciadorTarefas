namespace Layout
{
    class Formatacao
    {
       
        public static void ImprimirCabecalho(string texto)

        {

              Console.WriteLine("╔════════════════════════════════════╗");
            Console.WriteLine("║       GERENCIADOR DE TAREFAS       ║");
            Console.WriteLine("╚════════════════════════════════════╝\n");
            Console.ResetColor();
        }

        public static void Cor(string texto, ConsoleColor cor)
        {
            Console.ForegroundColor = cor;
            Console.WriteLine(texto);
            Console.ResetColor();
        }

    }
}