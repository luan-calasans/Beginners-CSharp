using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj37461_ListaVetores_ex08
{
    internal class C37461_ListaVetores_ex08
    {
        static void Main(string[] args)
        {
            // Ler 10 elementos inteiros positivos em um vetor A e colocá-los em
            // ordem crescente e apresentar os elementos ordenados.

            int[] numeroInteiro = new int[10];
            int auxiliar, y;

            for (int x = 0; x < 10; x++)
            {
                Console.Write("Digite um número inteiro: ");
                numeroInteiro[x] = int.Parse(Console.ReadLine());
                for (y = 0;  y < 9; y++)
                {
                    if (numeroInteiro[x] < numeroInteiro[y])
                    {
                        auxiliar = numeroInteiro[x];
                        numeroInteiro[x] = numeroInteiro[y];
                        numeroInteiro[y] = auxiliar;
                    }
                }
            }
            Console.Write("Ordem crescente dos número digitados: ");
            for (int z = 0; z < 10; z++)
            {
                Console.Write($" {numeroInteiro[z]} ");
            }
            Console.ReadKey();
        }
    }
}
