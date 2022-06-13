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
            double average, bin = 0, sum = 0;
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
                if (number[i] % 2 != 0)
                {
                    bin++;
                    sum += number[i];
                }
            }
            average = sum / bin;
            Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine($"A média dos número ímpares é: {average}");
            Console.ReadKey();
        }
    }
}
