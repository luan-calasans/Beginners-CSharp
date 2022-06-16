using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividades
{
    internal class ex56
    {
        static void Main(string[] args)
        {
            // Ler 10 elementos inteiros positivos em um vetor A e colocá-los em
            // ordem crescente e apresentar os elementos ordenados.

            int[] number = new int[10];
            int aux, y;

            for (int x = 0; x < 10; x++)
            {
                Console.Write("Digite um número inteiro: ");
                number[x] = int.Parse(Console.ReadLine());
                for (y = 0;  y < 9; y++)
                {
                    if (number[x] < number[y])
                    {
                        aux = number[x];
                        number[x] = number[y];
                        number[y] = aux;
                    }
                }
            }
            Console.Write("Ordem crescente dos número digitados: ");
            for (int z = 0; z < 10; z++)
            {
                Console.Write($" {number[z]} ");
            }
            Console.ReadKey();
        }
    }
}
