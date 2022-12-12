using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd.Classes
{
    public static class Utils
    {
        public static void BarraCarregamento(string texto)
        {
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write($"{texto}");

            for (int contador = 0; contador < 3; contador++)
            {
                Thread.Sleep(500);
                Console.Write($".");
            }

            Console.ResetColor();

        }

        public static void ParadaNoConsole(string txt)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"{txt}");
            Console.WriteLine("Tecle 'ENTER' para continuar");
            Console.ResetColor();
            Console.ReadLine();
        }
    }
}