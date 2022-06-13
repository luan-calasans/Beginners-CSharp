using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividades
{
    internal class ex51
    {
        static void Main(string[] args)
        {
            /*
                Criar um vetor A com 10 elementos inteiros. Implementar um programa
                que defina e escreva a soma de todos os elementos armazenados neste
                vetor.  
             */
            int[] number = new int[10];
            int sum = 0;

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
                sum += number[i];
            }
            Console.ForegroundColor = ConsoleColor.Blue; Console.WriteLine($"A soma dos números inteiros acima é igual a: {sum}");
            Console.ReadKey();
        }
    }
}
