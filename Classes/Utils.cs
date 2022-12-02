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

            for (int contador = 0; contador < 6; contador++)
            {
                Thread.Sleep(500);
                Console.Write($".");
            }

            Console.ResetColor();

        }
    }
}