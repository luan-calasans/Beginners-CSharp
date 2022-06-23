using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividades
{
    internal class ex58
    {
        static void Main(string[] args)
        {
            int cont = 0, number;
            double evenSum = 0, oddSum = 0;
            do
            {
                cont++;
                Console.Write("Digite um número: ");
                number = int.Parse(Console.ReadLine());
                if (number % 2 == 0)
                {
                    evenSum += number;
                }
                else
                {
                    oddSum += number;
                }
            } while (cont < 10 && evenSum < 100);
            Console.ForegroundColor = ConsoleColor.Yellow; Console.Write($"A soma dos números ímpares é: {oddSum}");
            Console.ReadKey();
        }
    }
}
