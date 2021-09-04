using System;

namespace cebolinha
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write(" cite uma frase para o cebolinha dizer");
            string texto =Console.ReadLine( );


            Console.ForegroundColor= ConsoleColor.DarkRed;
            Console.Write("Cebolinha");

            Console.ResetColor( );
            Console.WriteLine( texto
            .Replace("r", "l")
            .Replace("R", "L") );

            Console.ResetColor();

        }
    }
}
