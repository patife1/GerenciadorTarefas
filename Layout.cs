namespace Layout
{
    class Formatacao
    {
        public static void Cor(string texto, ConsoleColor cor)
        {
            Console.ForegroundColor = cor;
            Console.WriteLine(texto);
            Console.ResetColor();
        }

        public static void ImprimirCabecalho(string texto)

        {

            
            Console.WriteLine(texto);
            Console.ResetColor();
        }
    }
}