using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividades
{
    internal class ex57
    {
        static void Main(string[] args)
        {
            // Ler 10 elementos inteiros quaisquer em um vetor A e colocá-los em
            // ordem crescente e apresentar os elementos ordenados.


            int[] number = new int[10];
            int aux;

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Digite um número: ");
                number[i] = int.Parse(Console.ReadLine());
            }

            for (int x = 0; x < 9; x++)
            {
                for (int y = x + 1; y < 10; y++)
                {
                    if (number[x] > number[y])
                    {
                        aux = number[x];
                        number[x] = number[y];
                        number[y] = aux;
                    }
                }
            }

            Console.Write("Ordem dos números digitados: ");

            for (int z = 0; z < 10; z++)
            {
                Console.Write($" {number[z]} ");
            }

            Console.ReadKey();
        }
    }
}
