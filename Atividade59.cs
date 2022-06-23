using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividades
{
    internal class ex59
    {
        static void Main(string[] args)
        {
            int highestValue = 0;
            double average = 0, sum = 0;
            int[] number = new int[10];

            for (int x = 0; x < 10; x++)
            {
                Console.Write("Digite um valor positivo: ");
                number[x] = int.Parse(Console.ReadLine());
                for (int y = 0; y < 10; y++)
                {
                    if (number[x] < 0)
                    {
                        Console.Write("ERRO! Digite um valor positivo: ");
                        numeroDigitado[x] = int.Parse(Console.ReadLine());
                    }
                    else
                    {
                        if (number[x] > highestValue)
                        {
                            highestValue = number[x];
                        }
                    }
                }
                soma += number[x];
            }
            average = sum / 10;
            Console.ForegroundColor = ConsoleColor.Cyan; Console.Write($"O maior valor é {highestValue}\nA soma é: {sum}\nA média é: {average}");
            Console.ReadKey();
        }
    }
}
