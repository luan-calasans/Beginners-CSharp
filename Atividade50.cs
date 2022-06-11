using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj37461_ListaVetores_ex01
{
    internal class C37461_ListaVetores_ex01
    {
        static void Main(string[] args)
        {
            /*
               Criar um vetor A com 10 elementos inteiros. Implementar um programa
               que defina e escreva a quantidade de elementos armazenados neste vetor
               que são pares.
             */
            int[] numeroInteiro = new int[10];
            int armazenaInteiro = 0;
            for (int i = 0; i < 10; i++)
            {
                numeroInteiro[i] = i;
                Console.WriteLine($"Número inteiro: {numeroInteiro[i]}");
                if (numeroInteiro[i] % 2 == 0)
                {
                    armazenaInteiro++;
                }
            }
            Console.ForegroundColor = ConsoleColor.Blue; Console.WriteLine($"Existem {armazenaInteiro} números inteiros pares acima");
            Console.ReadKey();
        }
    }
}
