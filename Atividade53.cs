using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividades
{
    internal class ex53
    {
        static void Main(string[] args)
        {
            /*
                Criar um vetor A com 10 elementos inteiros. Desenvolver um programa
                que defina o percentual de elementos pares e ímpares, respectivamente,
                armazenados neste vetor.
             */
            int[] number = new int[10];
            double storeEven = 0, storeOdd = 0, pcEven, pcOdd;
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Digite um número inteiro positivo: ");
                number[i] = int.Parse(Console.ReadLine());
                while (number[i] < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red; Console.Write("ERRO! ");
                    Console.ForegroundColor = ConsoleColor.Gray; Console.Write("Digite um número inteiro positivo: ");
                    number[i] = int.Parse(Console.ReadLine());
                }
                if (number[i] % 2 == 0)
                {
                    binEven++;
                }
                else
                {
                    binOdd++;
                }
            }

            pcEven = (binEven * 100) / number.Length;
            pcOdd = (binOdd * 100) / number.Length;

            Console.ForegroundColor = ConsoleColor.DarkCyan; Console.Write($"Percentual de números pares: {pcEven}%\nPercentual de números ímpares: {pcOdd}%");
            Console.ReadKey();
        }
    }
}
