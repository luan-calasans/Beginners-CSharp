using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividades
{
    internal class ex50
    {
        static void Main(string[] args)
        {
            /*
               Criar um vetor A com 10 elementos inteiros. Implementar um programa
               que defina e escreva a quantidade de elementos armazenados neste vetor
               que são pares.
             */
            int[] number = new int[10];
            int binNumber = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Digite um número inteiro positivo: ");
                number[i] = int.Parse(Console.ReadLine());
                while (number[i] < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red; Console.Write("ERRO! ");
                    Console.ForegroundColor = ConsoleColor.Gray;  Console.Write("Digite um número inteiro positivo: ");
                    number[i] = int.Parse(Console.ReadLine());
                }
                if (number[i] % 2 == 0)
                {
                    binNumber++;
                }
            }
            Console.ForegroundColor = ConsoleColor.Blue; Console.WriteLine($"Existem {binNumber} números inteiros pares acima");
            Console.ReadKey();
        }
    }
}
