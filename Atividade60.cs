using System;
using System.Collections.Generic;
using System.Text;

namespace Atividades
{
    class ex60
    {
        static void Main(string[] args)
        {
            double average = 0.0;
            Console.Clear();
            dataInput();
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(10, 5);
            average = calc();
            Console.WriteLine("Media Aritmética = {0}", average.ToString("#0.00"));
            Console.CursorVisible = false;
            Console.ReadKey();
        }
        private static double calc()
        {
            return (p1 + p2) / 2;
        }

        static double p1, p2;

        static void dataInput()
        {
            try
            {
                Console.Clear();
                Console.SetCursorPosition(10, 5);
                Console.Write("Digite o valor da P1: ");
                p1 = double.Parse(Console.ReadLine());
                Console.SetCursorPosition(10, 7);
                Console.Write("Digite o valor da P2: ");
                p2 = double.Parse(Console.ReadLine());
            }
            catch
            {
                Console.SetCursorPosition(10, 9);
                Console.Write("Digite só numeros!");
                Console.ReadKey();
                dataInput();
            }
        }
    }
}
