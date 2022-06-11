using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividades
{
    internal class ex52
    {
        static void Main(string[] args)
        {
            /*
                Criar um vetor A com 10 elementos inteiros. Implementar um programa
                que defina e escreva a média aritmética simples dos elementos ímpares
                armazenados neste vetor.
             */
            int[] number = new int[10];
            double average, storeOdd = 0;
            for (int i = 0; i < 10; i++)
            {
                number[i] = i;
                if (number[i] % 2 != 0)
                {
                    storeOdd++;
                }
                Console.WriteLine($"Número inteiro: {numeroInteiro[i]}");
            }
            average = storeOdd / number.Length;
            Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine($"A média dos número ímpares é: {average}");
            Console.ReadKey();
        }
    }
}
